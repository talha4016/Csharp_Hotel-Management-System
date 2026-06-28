using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System_Database
{
    internal class customersData
    {
        private string conn = "server=localhost;user=root;password=sheismine24;database=hotel_database;";

        public int ID { get; set; }
        public string BookID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNum { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string RoomID { get; set; }
        public string Price { get; set; }
        public string StatusPayment { get; set; }
        public string Status { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string BookDate { get; set; }



        public List<customersData> customerListData()
        {
            List<customersData> listData = new List<customersData>();



            using (MySqlConnection connect = new MySqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM customer";

                using (MySqlCommand cmd = new MySqlCommand(selectData, connect))

                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                customersData cData = new customersData();

                                cData.ID = Convert.ToInt32(reader["id"]);
                                cData.BookID = reader["book_id"].ToString();
                                cData.FullName = reader["full_name"].ToString();
                                cData.Email = reader["email"].ToString();
                                cData.ContactNum = reader["contact"].ToString();
                                cData.Gender = reader["gender"].ToString();
                                cData.Address = reader["address"].ToString();
                                cData.RoomID = reader["room_id"].ToString();
                                cData.Price = reader["price"].ToString();
                                cData.StatusPayment = reader["status_payment"].ToString();
                                cData.Status = reader["status"].ToString();
                                cData.CheckIn = reader["date_from"].ToString();
                                cData.CheckOut = reader["date_to"].ToString();
                                cData.BookDate = reader["date_book"].ToString();

                                listData.Add(cData);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                return listData;
            }

        }
    }
}