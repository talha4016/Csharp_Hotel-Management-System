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
    public partial class admin_customers : UserControl
    {
        public admin_customers()
        {
            InitializeComponent();
            displayCustomers();
        }


        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke( (MethodInvoker)refreshData);
                return;
            }
            displayCustomers();
        }


        public void displayCustomers()
        {
            customersData cData = new customersData();
            List<customersData> listData = cData.customerListData ();

            dataGridView1.DataSource = listData;


        }
        private void admin_customers_Load(object sender, EventArgs e)
        {


        }
    }
}
