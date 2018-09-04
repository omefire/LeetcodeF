using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_CountAndSay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountAndSay(3));
            Console.WriteLine(CountAndSay(4));
            Console.WriteLine(CountAndSay(5));
            Console.ReadLine();
        }

        static string CountAndSay(int n)
        {
            if(n <= 0)
            {
                throw new Exception("Invalid Argument");
            }

            if(n == 1)
            {
                return "1";
            }

            var prev = CountAndSay(n - 1);
            int i = 0;
            StringBuilder result = new StringBuilder();
            while(i < prev.Length)
            {
                int count = 0;
                int j = i;
                while(j < prev.Length && (prev[i] == prev[j]))
                {
                    j++;
                    count++;
                }

                result.Append(count);
                result.Append(prev[i]);
                i = j;
            }

            return result.ToString();
        }
    }
}
