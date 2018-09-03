using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _283_MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = MoveZeroes1(new int[] { 0, 1, 0, 3, 12 });
            results.ToList().ForEach(r =>
            {
                Console.Write(r + " ");
            });

            Console.ReadLine();
        }

        static int[] MoveZeroes1(int[] nums)
        {
            if(nums == null || nums.Length == 0)
            {
                return nums;
            }

            var ans = new List<int>();

            int countOfZeroes = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    countOfZeroes++;
                }
            }

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    ans.Add(nums[i]);
                }
            }

            while(countOfZeroes > 0)
            {
                ans.Add(0);
                countOfZeroes--;
            }

            return ans.ToArray();
        }

        static int[] MoveZeroes2(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    int j = i - 1;
                    while((j >= 0) && (nums[j] == 0))
                    {
                        // swap
                        nums[j] = nums[i];
                        nums[i] = 0;
                    }
                }
            }

            return nums;
        }

        static int[] MoveZeroes3(int[] nums)
        {
            int lastFoundNonZero = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    nums[lastFoundNonZero] = nums[i];
                    lastFoundNonZero++;
                }
            }

            for(int i = lastFoundNonZero; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            return nums;
        }
    }
}
