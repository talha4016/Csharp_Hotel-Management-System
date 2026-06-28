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
    public partial class MainForm_Dashboard : UserControl
    {

        DBConnect connect = new DBConnect();

        public MainForm_Dashboard()
        {


            InitializeComponent();
            displayTotalStaff();
            displayAvailableRooms();
            displayProfitToday();
            displayProfitTotal();
            displayAllRooms();

        }

        public void displayAllRooms()
        {
            roomsData rData = new roomsData();
            List<roomsData> listData = rData.roomsDataList();

            dataGridView1.DataSource = listData;
        }



        public void displayTotalStaff()
        {

            try
            {
                connect.OpenCon();

                string selectData = "SELECT COUNT(id) FROM users WHERE role = 'Staff'";

                using (MySqlCommand cmd = new MySqlCommand(selectData, connect.GetConnection()))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        totalStaff.Text = result.ToString();
                    }
                    else
                    {
                        totalStaff.Text = "0";
                    }
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




        public void displayAvailableRooms()
        {

            try
            {
                connect.OpenCon();

                string selectData = "SELECT COUNT(id) FROM rooms WHERE status = 'Active' OR status = 'Available'";

                using (MySqlCommand cmd = new MySqlCommand(selectData, connect.GetConnection()))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        AvailableRooms.Text = result.ToString();
                    }
                    else
                    {
                        AvailableRooms.Text = "0";
                    }
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




        public void displayProfitToday()
        {
            try
            {
                connect.OpenCon();

                string selectData = "SELECT SUM(price) FROM customer WHERE  date_book = @dbook";

                using (MySqlCommand cmd = new MySqlCommand(selectData, connect.GetConnection()))
                {

                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@dbook", today);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        profitToday.Text = "$" + result.ToString() + ".00";
                    }
                   
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




        public void displayProfitTotal()
        {
            try
            {
                connect.OpenCon();

                string selectData = "SELECT SUM(price) FROM customer ";

                using (MySqlCommand cmd = new MySqlCommand(selectData, connect.GetConnection()))
                {

                   

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                      totalprofit .Text = "$" + result.ToString() + ".00";
                    }
                    else
                    {
                        totalprofit.Text = "0";
                    }
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




        private void MainForm_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void AvailableRooms_Click(object sender, EventArgs e)
        {

        }

        private void profitToday_Click(object sender, EventArgs e)
        {

        }

        private void totalprofit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
