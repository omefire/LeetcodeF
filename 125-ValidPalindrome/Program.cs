using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _125_ValidPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPalindrome("A man, a plan, a canal: Panama"));
            Console.ReadLine();
        }

        static bool isPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return true;
            }

            int i = 0;
            int j = s.Length - 1;

            var arr = s.ToCharArray();

            while (i < j)
            {
                if (!(Char.IsLetterOrDigit(arr[i])))
                {
                    i++;
                }
                else if (!Char.IsLetterOrDigit(arr[j]))
                {
                    j--;
                }
                else
                {
                    if (Char.ToLower(arr[i]) != Char.ToLower(arr[j]))
                    {
                        return false;
                    }
                    i++;
                    j--;
                }
            }

            return true;
        }
    }
}
