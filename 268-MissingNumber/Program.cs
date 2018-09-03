using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _268_MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MissingNumber1(new int[] { 0, 1, 3 }));
            Console.ReadLine();
        }

        static int MissingNumber1(int[] nums)
        {
            int expected = 0;
            for(int i = 0; i <= nums.Length; i++)
            {
                expected += i;
            }

            for(int i = 0; i < nums.Length; i++)
            {
                expected -= nums[i];
            }

            return expected;
        }

        static int MissingNumber2(int[] nums)
        {
            int expected = (nums.Length * (nums.Length + 1)) / 2;
            int actual = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                actual += nums[i];
            }
            return expected - actual;
        }
    }
}
