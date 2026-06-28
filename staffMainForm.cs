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
    public partial class staffMainForm : Form
    {
        public staffMainForm()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginform = new Form1();
                loginform.Show();

                this.Hide();
            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void staff_bookRoom1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = true;
            staff_bookRoom1.Visible = false;
            admin_customers1.Visible = false;

            admin_dashboard adDashboard = admin_dashboard1 as admin_dashboard;
            if (adDashboard != null)
            {
                adDashboard.refreshData();
            }

        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            staff_bookRoom1.Visible =  true;
            admin_customers1.Visible = false;

          

            staff_bookRoom adStaff = staff_bookRoom1 as staff_bookRoom;
            if (adStaff != null)
            {
                adStaff.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            staff_bookRoom1.Visible = false;
            admin_customers1.Visible = true;


            admin_customers adCustomers = admin_customers1 as admin_customers;
            if (adCustomers != null)
            {
                adCustomers.refreshData();
            }
        }
    }
}









