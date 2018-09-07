using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88_MergeSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var e in MergeSortedArray(
                new int[] { 1, 2, 3, 0, 0, 0 },
                3,
                new int[] { 2, 5, 6 },
                3
                ))
            {
                Console.Write(e + ", ");
            }

            Console.ReadLine();
        }

        static int[] MergeSortedArray(int[] nums1, int len1, int[] nums2, int len2)
        {
            int k = nums1.Length - 1;
            int i = len1 - 1;
            int j = len2 - 1;

            while ((i >= 0) && (j >= 0))
            {
                if (nums1[i] >= nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }

            while (i >= 0)
            {
                nums1[k--] = nums1[i--];
            }

            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }

            return nums1;
        }
    }
}
