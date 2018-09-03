using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _206_ReverseLinkedList
{
    class Node
    {
        public int Val;
        public Node Next;

        public Node(int val)
        {
            this.Val = val;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new Node(1);
            var b = new Node(2);
            var c = new Node(3);
            var d = new Node(4);

            d.Next = null;
            c.Next = d;
            b.Next = c;
            a.Next = b;

            ReverseLinkedList(a);
        }

        static Node ReverseLinkedList(Node head)
        {
            Node prev = null;
            Node curr = head;

            while(curr != null)
            {
                var tmp = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = tmp;
            }

            return prev;
        }
    }
}
