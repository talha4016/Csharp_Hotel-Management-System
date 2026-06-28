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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Hotel_Management_System_Database
{
    public partial class clientinfo : Form
    {
        DBConnect connect = new DBConnect();

        public clientinfo()
        {
            InitializeComponent();
            displayBookID();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
                this.Hide();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }




        public void displayBookID()
        {
            try
            {
                connect.OpenCon();

                string selectID = "SELECT COUNT(id) FROM customer;";
                using (MySqlCommand cmd = new MySqlCommand(selectID, connect.GetConnection()))
                {
                    object result = cmd.ExecuteScalar();

                    int getBookID = 0;
                    if (result != DBNull.Value)
                    {
                        getBookID = Convert.ToInt32(result);
                    }

                    getBookID++; // increment to get the new ID

                    client_bookID.Text = "B-" + getBookID.ToString("0000");  // Example format: B-0001
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.CloseCon();
            }
        }









        private void client_bookBtn_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (string.IsNullOrEmpty(client_fullName.Text) ||
                client_gender.SelectedIndex == -1 ||
                string.IsNullOrEmpty(client_address.Text) ||
                string.IsNullOrEmpty(client_email.Text) ||
                string.IsNullOrEmpty(client_contact.Text) ||
                string.IsNullOrEmpty(hotelData.roomID))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to book this room now?",
                "Confirm Booking",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return; // User canceled
            }

            try
            {
                // Open MySQL connection
                connect.OpenCon();

                // Prepare insert query
                string insertData = "INSERT INTO customer " +
                                    "(book_id, full_name, email, contact, gender, address, room_id, price, status_payment, status, date_from, date_to, date_book) " +
                                    "VALUES (@bookID, @fullname, @email, @contact, @gender, @address, @roomID, @price, @statusp, @status, @dateFrom, @dateTo, @dateBook)";

                using (MySqlCommand cmd = new MySqlCommand(insertData, connect.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@bookID", client_bookID.Text.Trim());
                    cmd.Parameters.AddWithValue("@fullname", client_fullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", client_email.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", client_contact.Text.Trim());
                    cmd.Parameters.AddWithValue("@gender", client_gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@address", client_address.Text.Trim());
                    cmd.Parameters.AddWithValue("@roomID", hotelData.roomID);
                    cmd.Parameters.AddWithValue("@price", hotelData.price);
                    cmd.Parameters.AddWithValue("@statusp", "Paid");
                    cmd.Parameters.AddWithValue("@status", "Checked In");
                    cmd.Parameters.AddWithValue("@dateFrom", hotelData.fromDate);
                    cmd.Parameters.AddWithValue("@dateTo", hotelData.toDate);

                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@dateBook", today);

                    cmd.ExecuteNonQuery();
                    updateRoomstatus();
                    MessageBox.Show("Booked successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.CloseCon(); 
            }
        }

        public void updateRoomstatus()
        {
            try
            {
                connect.OpenCon();

                string updateStatus = "UPDATE rooms SET status = @status WHERE room_id = @roomID";
                using (MySqlCommand cmd = new MySqlCommand(updateStatus, connect.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@status", "Unavailable");
                    cmd.Parameters.AddWithValue("@roomID", hotelData.roomID);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.CloseCon();
            }
        }

        

      



        private void client_clearBtn_Click(object sender, EventArgs e)
        {

            client_fullName.Text = "";
            client_email.Text = "";
            client_contact.Text = "";
            client_gender.SelectedIndex = -1;
            client_address.Text = "";

        }
    }
}
