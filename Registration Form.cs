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

namespace Hotel_Management_System_Database
{
    
    public partial class Registration_Form : Form
    {
        DBConnect connect = new DBConnect();
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == "" || register_password.Text == "" || register_cpassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DBConnect connect = new DBConnect();
                    connect.OpenCon();

                    // Check if username exists
                    string checkUserQuery = "SELECT username FROM users WHERE username = @usern";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkUserQuery, connect.GetConnection()))
                    {
                        checkCmd.Parameters.AddWithValue("@usern", signup_username.Text.Trim());
                        MySqlDataAdapter adapter = new MySqlDataAdapter(checkCmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            string tempName = signup_username.Text.Substring(0, 1).ToUpper() + signup_username.Text.Substring(1);
                            MessageBox.Show($"{tempName} is already existing", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (register_password.Text.Length < 8)
                        {
                            MessageBox.Show("Password must be at least 8 characters long", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (register_password.Text != register_cpassword.Text)
                        {
                            MessageBox.Show("Passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Insert user into database
                            string insertQuery = "INSERT INTO users (username, password, role, status, date_register) VALUES (@usern, @pass, @role, @status, @regDate)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connect.GetConnection()))
                            {
                                insertCmd.Parameters.AddWithValue("@usern", signup_username.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@role", "Staff");
                                insertCmd.Parameters.AddWithValue("@status", "Active");
                                insertCmd.Parameters.AddWithValue("@regDate", DateTime.Today);

                                int rows = insertCmd.ExecuteNonQuery();
                                if (rows > 0)
                                {
                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Registration failed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
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

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_signinbtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (register_showPass.Checked)
            {
                // Show the password (remove masking)
                register_password.PasswordChar = '\0';
                register_cpassword.PasswordChar = '\0';
            }
            else
            {
                // Hide the password (mask with *)
                register_password.PasswordChar = '*';
                register_cpassword.PasswordChar = '*';
            }
        }

        private void signup_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
