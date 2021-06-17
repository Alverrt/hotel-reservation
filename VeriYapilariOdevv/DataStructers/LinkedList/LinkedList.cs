using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdevv.DataStructers.LinkedList
{
    class ILinkedList
    {
        public LLNode Head { get; set; }
        public LLNode Temp { get; set; }
        public LLNode Last { get; set; }
        public ILinkedList()
        {
            this.Head = null;
            this.Temp = null;
            this.Last = null;
        }
        public void AddNode(LLNode node)
        {
            // Listeye eklenecek ilk elemansa
            if (this.Head == null)
            {
                this.Head = node;
                this.Head.Next = null;
                return;
            }
            
            // Listeye eklenecek 2. elemansa
            if (this.Head.Next == null)
            {
                this.Temp = node;
                this.Head.Next = Temp;
                this.Last = this.Head.Next;
            }
            else
            {
                this.Temp = this.Last;
                this.Last = node;
                this.Temp.Next = Last;
            }

            
        }
    }
}
