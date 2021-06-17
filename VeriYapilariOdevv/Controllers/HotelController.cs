using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriYapilariOdevv.DataStructers.BinaryTree;
using VeriYapilariOdevv.Models;
using VeriYapilariOdevv.ORM;

namespace VeriYapilariOdevv.Controllers
{
    class HotelController
    {
        HotelModel model = new HotelModel();
        HotelORM orm = new HotelORM();
        BinaryTree bt = new BinaryTree();

        public object AddHotel(HotelModel data)
        {
            BTNode btnode = new BTNode();

            btnode.Data = data;
            //bt.AddNode(btnode);
            return orm.AddNewHotel(data);
        }

        public List<HotelModel> GetHotels()
        {
            return orm.GetAllHotels();
        }
    }
}
