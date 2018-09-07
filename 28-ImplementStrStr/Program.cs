using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_ImplementStrStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrStr("hello", "ll"));
            Console.ReadLine();
        }

        static int StrStr(string haystack, string needle)
        {
            if (String.IsNullOrEmpty(haystack))
            {
                return -1;
            }

            if (String.IsNullOrEmpty(needle))
            {
                return -1;
            }

            for (int i = 0; i < (haystack.Length - needle.Length); i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (((i + j) < haystack.Length) && (haystack[i + j] != needle[j]))
                    {
                        break;
                    }

                    if (j == (needle.Length - 1))
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
