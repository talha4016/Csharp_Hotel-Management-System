using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System_Database
{
    internal class usersData
    {
        private string conn = "server=localhost;user=root;password=sheismine24;database=hotel_database;";

        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string date_register { get; set; }

        public List<usersData> listUsersData()
        {
            List<usersData> listData = new List<usersData>();

            using (MySqlConnection connect = new MySqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM users";
                using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usersData uData = new usersData();
                            uData.ID = reader.GetInt32("ID");
                            uData.Username = reader["Username"].ToString();
                            uData.Password = reader["Password"].ToString();
                            uData.Role = reader["Role"].ToString();
                            uData.Status = reader["Status"].ToString();
                            uData.date_register = reader["date_register"].ToString();

                            listData.Add(uData);
                        }
                    }
                }
            }

            return listData;
        }
    }
}
