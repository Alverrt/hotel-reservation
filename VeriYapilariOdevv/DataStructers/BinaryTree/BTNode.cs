using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriYapilariOdevv.DataStructers.LinkedList;
using VeriYapilariOdevv.Models;

namespace VeriYapilariOdevv.DataStructers.BinaryTree
{
    class BTNode
    {
        public HotelModel Data { get; set; }
        public BTNode Left { get; set; }
        public BTNode Right { get; set; }
        public ILinkedList list;

        public BTNode()
        {
            this.Left = null;
            this.Right = null;
        }
    }
}
