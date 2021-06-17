using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriYapilariOdevv.Models;

namespace VeriYapilariOdevv.ORM
{
    class RoomORM
    {
        private readonly string DbPath = "Data Source = db/HotelReservation.db";
        private ReturnIDLastInserted id = new ReturnIDLastInserted();
        public List<RoomModel> GetAllHotels()
        {
            SQLiteConnection connect = new SQLiteConnection();
            connect.ConnectionString = DbPath;
            connect.Open();

            string query = "SELECT * FROM hotels";
            SQLiteCommand cmd = new SQLiteCommand(query, connect);

            SQLiteDataReader dr = cmd.ExecuteReader();

            List<RoomModel> list = new List<RoomModel>();

            while (dr.Read())
            {
                RoomModel model = new RoomModel();

                

                list.Add(model);
            }
            connect.Close();
            return list;
        }

        public object AddNewRoom(RoomModel data)
        {
            SQLiteConnection connect = new SQLiteConnection();
            connect.ConnectionString = DbPath;
            connect.Open();

            string query = "INSERT INTO rooms (room_no, phone_number, room_capaticy, room_view, availability, price, hotel_id) VALUES (@room_no, @phone_number, @room_capaticy, @room_view, @availability, @price, @hotel_id)";
            SQLiteCommand cmd = new SQLiteCommand(query, connect);
            cmd.Parameters.AddWithValue("room_no", data.RoomNo);
            cmd.Parameters.AddWithValue("phone_number", data.PhoneNumber);
            cmd.Parameters.AddWithValue("room_capaticy", data.RoomCapaticy);
            cmd.Parameters.AddWithValue("room_view", data.RoomView);
            cmd.Parameters.AddWithValue("availability", data.Availability);
            cmd.Parameters.AddWithValue("price", data.Price);
            cmd.Parameters.AddWithValue("hotel_id", data.HotelID);

            try
            {
                cmd.ExecuteNonQuery();
                return id.GetIDOfLastInserted(connect, "rooms");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
    }
}
