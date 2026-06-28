using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System_Database
{
    public partial class Form1 : Form
    {
        DBConnect connect = new DBConnect();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (signin_username.Text == "" || signin_password.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.OpenCon();

                    string query = "SELECT role FROM users WHERE username = @username AND password = @password AND status = 'Active'";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@username", signin_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", signin_password.Text.Trim());

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string userRole = result.ToString();
                            MessageBox.Show("Login successful! Role: " + userRole, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (userRole == "Admin")
                            {
                                MainAdminForm adminForm = new MainAdminForm();
                                adminForm.Show(); // or ShowDialog() for test
                                this.Hide();
                            }
                            else if (userRole == "Staff")
                            {
                                staffMainForm staffForm = new staffMainForm();
                                staffForm.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    connect.CloseCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void TextBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_registrationBtn_Click(object sender, EventArgs e)
        {
            Registration_Form regForm = new Registration_Form();
            regForm.Show();

            this.Hide();
        }

        private void register_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (register_showpassword.Checked)
            {
                signin_password.PasswordChar = '\0'; // Show the password
            }
            else
            {
                signin_password.PasswordChar = '*'; // Mask the password
            }
          

        }

        private void AdminMainFormTest_Click(object sender, EventArgs e)
        {
           
        }
    }
}
