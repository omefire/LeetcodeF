using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _234_PalindromeLinkedList
{
    class Program
    {
        [Serializable]
        class Node
        {
            public int Value;
            public Node Next;

            public Node(int val)
            {
                this.Value = val;
            }
        }

        static void Main(string[] args)
        {
            var n1 = new Node(1);
            var n2 = new Node(2);
            var n3 = new Node(2);
            var n4 = new Node(1);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = null;

            Console.WriteLine(isPalindrome(n1));
            Console.ReadKey();
        }

        static T Copy<T>(T obj)
        {
            var ms = new MemoryStream();
            var fmter = new BinaryFormatter();
            fmter.Serialize(ms, obj);

            ms.Seek(0, SeekOrigin.Begin);
            return (T)fmter.Deserialize(ms);
        }
        static bool isPalindrome(Node head)
        {
            if(head == null)
            {
                return false;
            }

            // 0- Keep original list's head
            var origHead = Copy(head);

            // 1- Calculate the list's length
            int length = 0;
            var cHead = Copy(head);
            while(cHead != null)
            {
                cHead = cHead.Next;
                length++;
            }

            // 2- Reverse the second half of the list
            var beforeMidNode = Copy(head);
            int counter = 0;

            while((counter < ((length / 2) - 1)) && (beforeMidNode != null))
            {
                beforeMidNode = beforeMidNode.Next;
                counter++;
            }

            var midNode = beforeMidNode.Next;

            var p = Copy(midNode);
            var n = p.Next;

            while(n != null)
            {
                var tmp = Copy(n);
                n.Next = p; p.Next = null;
                p = tmp;
                n = tmp.Next;
            }
            var bM = Copy(beforeMidNode);
            bM.Next = p;

            // 3- Compare between (beg->mid) AND (mid->end)
            cHead = Copy(head);
            var midN = Copy(midNode);

            bool result = true;
            counter = 0;
            while((counter < (length / 2)) && (cHead != null) && (midN != null))
            {
                if(cHead.Value != midN.Value)
                {
                    result = false;
                    break;
                }

                cHead = cHead.Next;
                midN = midN.Next;
            }

            // 4- Reverse the second half back to what it was originally


            return result;
        }
    }
}
