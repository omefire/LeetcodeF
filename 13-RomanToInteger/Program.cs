using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInteger("MCMXCIV"));
            Console.ReadLine();
        }

        static int RomanToInteger(string roman)
        {
            if(roman == null || roman.Length == 0)
            {
                throw new InvalidOperationException();
            }

            roman = roman.ToUpper();
            var map = new Dictionary<Char, int> {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            if(roman.Length == 1)
            {
                if (map.ContainsKey(roman[0])) {
                    return map[roman[0]];
                } else
                {
                    throw new Exception("Invalid Input");
                }
            }

            int result = 0; int i = 0;
            while(i < roman.Length)
            {
                Char first = roman[i];
                Char second = roman[i];

                if((!map.ContainsKey(first)) || (!map.ContainsKey(second)) ) {
                    throw new Exception("Invalid Input");
                }

                if(isSubstration(first, second))
                {
                    result += (map[second] - map[first]);
                    i += 2;
                } else
                {
                    result += map[first];
                    i++;
                }
            }
            
            return result;
        }

        static bool isSubstration(Char x, Char y)
        {
            if(x == 'I' && (y == 'V' || y == 'X'))
            {
                return true;
            }

            if(x == 'X' && (y == 'L' || y == 'C'))
            {
                return true;
            }

            if(x == 'C' && (y == 'D' || y == 'M'))
            {
                return true;
            }

            return false;
        }
    }
}
