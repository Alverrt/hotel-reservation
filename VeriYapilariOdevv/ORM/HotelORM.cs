using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriYapilariOdevv.Models;

namespace VeriYapilariOdevv.ORM
{
    class HotelORM
    {
        private readonly string DbPath = "Data Source = db/HotelReservation.db";
        private ReturnIDLastInserted id = new ReturnIDLastInserted();
        public List<HotelModel> GetAllHotels()
        {
            SQLiteConnection connect = new SQLiteConnection();
            connect.ConnectionString = DbPath;
            connect.Open();

            string query = "SELECT * FROM hotels";
            SQLiteCommand cmd = new SQLiteCommand(query, connect);

            SQLiteDataReader dr = cmd.ExecuteReader();

            List<HotelModel> list = new List<HotelModel>();

            while (dr.Read())
            {
                HotelModel model = new HotelModel();

                model.HotelId = Convert.ToInt32(dr["Id"]);
                model.HotelName = (string)dr["name"];
                model.Province = (string)dr["province"];
                model.Town = (string)dr["town"];
                model.Adress = (string)dr["adress"];
                model.Email = (string)dr["email"];
                model.PhoneNumber = (string)dr["phone_number"];
                model.NumberOfRooms = Convert.ToInt32(dr["number_of_rooms"]);
                model.Stars = Convert.ToInt32(dr["stars"]);
                model.Score = Convert.ToInt32(dr["hotel_score"]);

                list.Add(model);
            }
            connect.Close();
            return list;
        }

        public object AddNewHotel(HotelModel data)
        {
            SQLiteConnection connect = new SQLiteConnection();
            connect.ConnectionString = DbPath;
            connect.Open();

            string query = "INSERT INTO hotels (name, province, town, adress, email, phone_number, number_of_rooms, stars) VALUES (@name, @province, @town, @adress, @email, @phone_number, @number_of_rooms, @stars)";
            SQLiteCommand cmd = new SQLiteCommand(query, connect);
            cmd.Parameters.AddWithValue("name", data.HotelName);
            cmd.Parameters.AddWithValue("province", data.Province);
            cmd.Parameters.AddWithValue("town", data.Town);
            cmd.Parameters.AddWithValue("adress", data.Adress);
            cmd.Parameters.AddWithValue("email", data.Email);
            cmd.Parameters.AddWithValue("phone_number", data.PhoneNumber);
            cmd.Parameters.AddWithValue("number_of_rooms", data.NumberOfRooms);
            cmd.Parameters.AddWithValue("stars", data.Stars);
            try
            {
                cmd.ExecuteNonQuery();
                return id.GetIDOfLastInserted(connect, "hotels");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            
        }
    }
}
