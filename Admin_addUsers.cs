using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System_Database
{
    public partial class Admin_addUsers : UserControl
    {
        DBConnect connect = new DBConnect();
        public Admin_addUsers()
        {
            InitializeComponent();
            displayData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }
            displayData();
        }



        public void displayData()
        {
            usersData uData = new usersData();
            dataGridView1.DataSource = uData.listUsersData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" ||
        addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (addUsers_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnect connect = new DBConnect();

            try
            {
                connect.OpenCon();

                // Check if username already exists
                string checkQuery = "SELECT username FROM users WHERE username = @username";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connect.GetConnection()))
                {
                    checkCmd.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());

                    object result = checkCmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Insert user into database
                string insertQuery = "INSERT INTO users (username, password, role, status, date_register) " +
                                     "VALUES (@username, @password, @role, @status, @date)";

                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connect.GetConnection()))
                {
                    insertCmd.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@password", addUsers_password.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@date", DateTime.Now);

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    ClearFields();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.CloseCon();
            }
        }
        private void ClearFields()
        {
            addUsers_username.Text = "";
            addUsers_password.Text = "";
            addUsers_role.SelectedIndex = -1;
            addUsers_status.SelectedIndex = -1;
        }

        private void addUsers_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void addUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == ""
        || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update ID: " + getID + "?",
                                                      "Confirmation Message",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                          DBConnect connect = new DBConnect();
                        {
                            connect.OpenCon();

                            string updateQuery = "UPDATE users SET password = @pass, role = @role, status = @status WHERE username = @usern";

                            using (MySqlCommand cmd = new MySqlCommand(updateQuery, connect.GetConnection()))
                            {
                                cmd.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayData(); // Refresh DataGridView
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    
          private int getID;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                addUsers_username.Text = row.Cells[1].Value.ToString();
                addUsers_password.Text = row.Cells[2].Value.ToString();
                addUsers_role.Text = row.Cells[3].Value.ToString();
                addUsers_status.Text = row.Cells[4].Value.ToString();
            }
        }

        private void addUsers_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == ""
       || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete ID: " + getID + "?",
                                                      "Confirmation Message",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DBConnect connect = new DBConnect();
                        {
                            connect.OpenCon();

                            string updateQuery = "DELETE FROM users  WHERE username = @usern";

                            using (MySqlCommand cmd = new MySqlCommand(updateQuery, connect.GetConnection()))
                            {
                               
                                cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayData(); // Refresh DataGridView
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
