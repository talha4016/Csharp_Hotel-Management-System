using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Hotel_Management_System_Database
{
    public partial class admin_rooms : UserControl
    {
        DBConnect connect = new DBConnect();
        public admin_rooms()
        {
            InitializeComponent();
            displayRoomsData();
        }





        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayRoomsData();

        }




        public void displayRoomsData()
        {
            roomsData rData = new roomsData();
            List<roomsData> listD = rData.roomsDataList();

            dataGridView1.DataSource = listD;
        }

        public bool isEmpty()
        {
            if (string.IsNullOrEmpty(room_roomID.Text) ||
                string.IsNullOrEmpty(room_roomName.Text) ||
                string.IsNullOrEmpty(room_price.Text) ||
                room_type.SelectedIndex == -1 ||
                room_status.SelectedIndex == -1 ||
                room_picture.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private void admin_rooms_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void room_Addbtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please fill all blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.OpenCon();

                string checkQuery = "SELECT room_id FROM rooms WHERE room_id = @roomID";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, connect.GetConnection());
                checkCmd.Parameters.AddWithValue("@roomID", room_roomID.Text.Trim());

                DataTable table = new DataTable();
                new MySqlDataAdapter(checkCmd).Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Room ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "room_directory");
                    if (!Directory.Exists(basePath)) Directory.CreateDirectory(basePath);

                    string imagePath = Path.Combine(basePath, room_roomID.Text.Trim() + ".jpg");
                    File.Copy(room_picture.ImageLocation, imagePath, true);

                    string insertQuery = @"INSERT INTO rooms (room_id, type, room_name, price, image_path, status, date_register)
                                           VALUES (@roomID, @type, @roomName, @price, @path, @status, @dateReg)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, connect.GetConnection());

                    insertCmd.Parameters.AddWithValue("@roomID", room_roomID.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@type", room_type.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@roomName", room_roomName.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@price", room_price.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@path", imagePath);
                    insertCmd.Parameters.AddWithValue("@status", room_status.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@dateReg", DateTime.Now);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Room successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearfields();
                    displayRoomsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.CloseCon();
            }
        }




        private void room_importbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    room_picture.ImageLocation = file.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image import failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void room_updatebtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = connect.GetConnection())
                {
                    conn.Open();

                    string imagePath = room_picture.ImageLocation;

                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "room_directory");
                        if (!Directory.Exists(basePath)) Directory.CreateDirectory(basePath);

                        string newPath = Path.Combine(basePath, room_roomID.Text.Trim() + ".jpg");
                        File.Copy(imagePath, newPath, true);
                        imagePath = newPath;
                    }

                    string updateQuery = @"UPDATE rooms SET type = @type, room_name = @roomName, 
                                           price = @price, image_path = @path, status = @status, 
                                           date_register = @dateReg WHERE room_id = @roomID";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@roomID", room_roomID.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@type", room_type.SelectedItem.ToString());
                    updateCmd.Parameters.AddWithValue("@roomName", room_roomName.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@price", room_price.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@path", imagePath);
                    updateCmd.Parameters.AddWithValue("@status", room_status.SelectedItem.ToString());
                    updateCmd.Parameters.AddWithValue("@dateReg", DateTime.Now);

                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Room updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearfields();
                    displayRoomsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void room_deletebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(room_roomID.Text))
            {
                MessageBox.Show("Enter Room ID to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.OpenCon();
                string deleteQuery = "DELETE FROM rooms WHERE room_id = @roomID";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connect.GetConnection());
                deleteCmd.Parameters.AddWithValue("@roomID", room_roomID.Text.Trim());

                if (deleteCmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Room deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearfields();
                    displayRoomsData();
                }
                else
                {
                    MessageBox.Show("Room ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.CloseCon();
            }
        }



        public void clearfields()
        {
            room_roomID.Clear();
            room_roomName.Clear();
            room_price.Clear();
            room_type.SelectedIndex = -1;
            room_status.SelectedIndex = -1;
            room_picture.Image = null;
        }
        private void room_clearbtn_Click(object sender, EventArgs e)
        {
            clearfields();
        }




        private int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                room_roomID.Text = row.Cells[1].Value.ToString();
                room_type.Text = row.Cells[2].Value.ToString();
                room_roomName.Text = row.Cells[3].Value.ToString();
                room_price.Text = row.Cells[4].Value.ToString();
                room_status.Text = row.Cells[5].Value.ToString();

                try
                {
                    room_picture.ImageLocation = row.Cells[6].Value.ToString();
                }
                catch
                {
                    room_picture.Image = null;
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }


