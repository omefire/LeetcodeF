using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _173_BinarySearchIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n10 = new Node(10);

            var n5 = new Node(5);
            var n12 = new Node(12);

            var n2 = new Node(2);
            var n7 = new Node(7);
            var n11 = new Node(11);

            var n3 = new Node(3);
            var n6 = new Node(6);

            n2.Right = n3;
            n5.Left = n2;
            n7.Left = n6;
            n5.Right = n7;

            n10.Left = n5;

            n12.Left = n11;
            n10.Right = n12;


            var root = n10;
            var iterator = new BinarySearchIterator(root);
            while(iterator.hasNext())
            {
                Console.Write(iterator.next() + ", ");
            }
            Console.ReadLine();
        }
    }

    class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int v)
        {
            this.Value = v;
        }
    }

    class BinarySearchIterator
    {
        Stack<Node> stack = new Stack<Node>();

        public BinarySearchIterator(Node root)
        {
            var currNode = root;
            while (currNode != null)
            {
                stack.Push(currNode);
                currNode = currNode.Left;
            }
        }

        public bool hasNext()
        {
            return stack.Count > 0;
        }

        public int next()
        {
            if (hasNext())
            {
                var next = stack.Pop();
                var currNode = next.Right;
                while(currNode != null)
                {
                    stack.Push(currNode);
                    currNode = currNode.Left;
                }

                return next.Value;
            }
            else
            {
                throw new Exception("No more items in the iterator");
            }
        }
    }
}
