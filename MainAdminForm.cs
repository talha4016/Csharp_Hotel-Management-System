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
    public partial class MainAdminForm : Form
    {
        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginform = new Form1();
                loginform.Show();

                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = true;
            admin_addUsers1.Visible = false;
            admin_rooms1.Visible = false;
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
            admin_addUsers1.Visible = true;
            admin_rooms1.Visible = false;
            admin_customers1.Visible = false;


            Admin_addUsers adUser = admin_addUsers1 as Admin_addUsers;
            if (adUser != null)
            {
                adUser.refreshData();
            }
        }

        private void rooms_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_addUsers1.Visible = false;
            admin_rooms1.Visible = true;
            admin_customers1.Visible = false;

            admin_rooms adRooms = admin_rooms1 as admin_rooms;
            if (adRooms != null)
            {
                adRooms.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {

            admin_dashboard1.Visible = false;
            admin_addUsers1.Visible = false;
            admin_rooms1.Visible = false;
            admin_customers1.Visible = true;

            admin_customers adCustomer = admin_customers1 as admin_customers;
            if (adCustomer != null)
            {
                adCustomer.refreshData();
            }
        }
    }
}
