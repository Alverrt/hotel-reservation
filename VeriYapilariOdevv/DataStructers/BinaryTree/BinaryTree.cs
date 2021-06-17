using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdevv.DataStructers.BinaryTree
{
    class BinaryTree
    {
        public BTNode Root = new BTNode();
        public BTNode Temp = new BTNode();

        public BinaryTree()
        {
            this.Root = null;
        }

        public BTNode AddNode(BTNode node)
        {
            if (Root == null)
            {
                Root = node;
                return Root;
            }

            if (String.Compare(Root.Data.HotelName, node.Data.HotelName) < 0)
            {
                Root.Left = AddNode(Root.Left);
            }
            else
            {
                Root.Right = AddNode(Root.Right);
            }

            return Root;
        }
    }
}
