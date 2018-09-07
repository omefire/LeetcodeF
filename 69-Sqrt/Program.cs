using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69_Sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sqrt(8));
            Console.ReadLine();
        }

        static int sqrt(int x)
        {
            if(x == 0 || x == 1)
            {
                return x;
            }

            int lo = 1; int hi = x / 2;
            while(lo <= hi)
            {
                int mid = (lo + hi) / 2;
                int mid1 = mid + 1;
                if( ((mid * mid) <= x) && ((mid1 * mid1) > x) ) {
                    return mid;
                }
                else if( (mid * mid) <= x )
                {
                    lo = mid + 1;
                } else
                {
                    hi = mid;
                }
            }

            return -1; // This should never occur
        }
    }
}
