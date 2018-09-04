using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicates1(new int[] { 1, 1, 2, 2, 3, 4, 5, 5 }));
            Console.WriteLine(RemoveDuplicates1(new int[] { 1, 2, 3 }));
            Console.WriteLine(RemoveDuplicates1(new int[] { 1, 2, 2, 2, 3, 3, 4, 5, 5, 6 }));
            Console.ReadLine();
        }

        static int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new Exception("Invalid Input");
            }

            if (nums.Length == 1)
            {
                return nums.Length;
            }

            int i = 0;
            int j = i + 1;

            while ((i < nums.Length) && (j < nums.Length))
            {
                while ((j < nums.Length) && (nums[i] == nums[j]))
                {
                    j++;
                }

                if (j >= nums.Length)
                {
                    break; // Or just return i
                }

                // Swap
                int temp = nums[i + 1];
                nums[i + 1] = nums[j];
                nums[j] = temp;

                i++; j++;
            }

            return i + 1;
        }

        static int RemoveDuplicates2(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    i++;
                    int tmp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = tmp;
                }
            }

            return i + 1;
        }
    }
}
