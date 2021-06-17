using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriYapilariOdevv.Models;
using VeriYapilariOdevv.ORM;

namespace VeriYapilariOdevv.Controllers
{
    class RoomController
    {
        RoomORM orm = new RoomORM();

        public object AddRoom(RoomModel model)
        {
            return orm.AddNewRoom(model);
        }
    }
}
