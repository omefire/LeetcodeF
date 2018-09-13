using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _168_ExcelSheetColumnTitle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("abc".Substring(0, 2));
            Console.ReadLine();
            return;

            Console.WriteLine(ColTitle(1));
            Console.WriteLine(ColTitle(26));
            Console.WriteLine(ColTitle(27));
            Console.WriteLine(ColTitle(702));
            Console.WriteLine(ColTitle(705));
            Console.ReadLine();
        }

        static string ColTitle(int n)
        {
            return ColTitleHelper(n, new StringBuilder());
        }

        static string ColTitleHelper(int n, StringBuilder sb)
        {
            // We assume n > 0

            var map = new Dictionary<int, string>();
            map.Add(1, "A");
            map.Add(2, "B");
            map.Add(3, "C");
            map.Add(4, "D");
            map.Add(5, "E");
            map.Add(6, "F");
            map.Add(7, "G");
            map.Add(8, "H");
            map.Add(9, "I");
            map.Add(10, "J");
            map.Add(11, "K");
            map.Add(12, "L");
            map.Add(13, "M");
            map.Add(14, "N");
            map.Add(15, "O");
            map.Add(16, "P");
            map.Add(17, "Q");
            map.Add(18, "R");
            map.Add(19, "S");
            map.Add(20, "T");
            map.Add(21, "U");
            map.Add(22, "V");
            map.Add(23, "W");
            map.Add(24, "X");
            map.Add(25, "Y");
            map.Add(26, "Z");

            if (n <= 26)
            {
                sb.Append(map[n]);
                var s = sb.ToString().ToCharArray();
                Array.Reverse(s);
                return new string(s);
            }

            int q = n / 26;
            int r = n % 26;

            if (r > 0)
            {
                sb.Append(map[r]);
            }

            return ColTitleHelper(q, sb);
        }
    }
}
