using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdevv.Models
{
    class HotelModel
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string Province { get; set; }
        public string Town { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int NumberOfRooms { get; set; }
        public int Stars { get; set; }
        public int Score { get; set; }
    }
}
