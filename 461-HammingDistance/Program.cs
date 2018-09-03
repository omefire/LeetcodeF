using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _461_HammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HammingDistance1(1, 4));
            Console.WriteLine(HammingDistance2(1, 4));
            Console.ReadLine();
        }

        static int HammingDistance1(int x, int y)
        {
            int m = x;
            int n = y;
            int count = 0;

            while(m > 0 || n > 0)
            {
                if (((m & 1) ^ (n & 1)) == 1)
                {
                    count++;
                }
                n = n >> 1;
                m = m >> 1;
            }

            return count;
        }

        static int HammingDistance2(int x, int y)
        {
            int m = x ^ y;
            int count = 0;

            while(m > 0)
            {
                if((m & 1) == 1)
                {
                    count++;
                }

                m >>= 1;
            }

            return count;
        }
    }
}
