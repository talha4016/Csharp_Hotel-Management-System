using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System_Database
{
    internal class roomsData
    {
        private string conn = "server=localhost;user=root;password=sheismine24;database=hotel_database;";
       

        public int ID { get; set; }
        public string RoomID { get; set; }
        public string RoomType { get; set; }
        public string RoomName { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        public List<roomsData> roomsDataList()
        {
            List<roomsData> listData = new List<roomsData>();


            using (MySqlConnection connect = new MySqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM rooms WHERE date_delete IS NULL";

                using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roomsData rData = new roomsData();

                            rData.ID = Convert.ToInt32(reader["id"]);
                            rData.RoomID = reader["room_id"].ToString();
                            rData.RoomType = reader["type"].ToString();
                            rData.RoomName = reader["room_name"].ToString();
                            rData.Price = reader["price"].ToString();
                            rData.Image = reader["image_path"].ToString();
                            rData.Status = reader["status"].ToString();
                            rData.Date = reader["date_register"].ToString();

                            listData.Add(rData);
                        }
                    }
                }
            }

            return listData;
        }
    }
}
