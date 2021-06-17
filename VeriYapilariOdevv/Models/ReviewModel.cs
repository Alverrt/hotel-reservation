using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdevv.Models
{
    class ReviewModel
    {
        public string Comment { get; set; }
        public int Score { get; set; }
        public int HotelID { get; set; }
        public int ClientID { get; set; }
    }
}
