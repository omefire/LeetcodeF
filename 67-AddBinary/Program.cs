using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_AddBinary
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static string AddBinary(string a, string b)
        {
            // Assumption: we get non-empty strings, not null strings
            // ... and our strings are only made-up of '0' and '1' 's
            var result = new StringBuilder();
            a = Pad(a, Math.Max(a.Length, b.Length));
            b = Pad(b, Math.Max(a.Length, b.Length));

            char carry = '0';

            for(int j = a.Length - 1; j >= 0; j--)
            {
                var x = a[j];
                var y = b[j];

                var r = Add(x, y, carry);
                result.Append(r.Item1);
                carry = r.Item2;
            }

            if(carry == '1')
            {
                result.Append('1');
            }

            return result.ToString().Reverse().ToString();
        }

        static Tuple<Char, Char> Add(char x, char y, char carry)
        {
            var r = Add(x, y); // (result, carry)

        }

        static Tuple<Char, Char> Add(char x, char y)
        {

        }

        static string Pad(string s, int len)
        {
            if(len < 0)
            {
                throw new Exception("Invalid argument");
            }

            if(s.Length >= len)
            {
                return s;
            }

            var sb = new StringBuilder();
            for(int i = 0; i < (s.Length - len); i++)
            {
                sb.Append("0");
            }

            sb.Append(s);
            return sb.ToString();
        }
    }
}
