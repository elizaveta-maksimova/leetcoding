using System;
using System.Net;

namespace Sandbox
{
    public class RotateArray
    {
        public static void Execute()
        {
            int[] nums = new[] {1, 2, 0 ,5, 0 ,0, 6};
            
            for (int lastNonZeroFoundAt = 0, cur = 0; cur < nums.Length; cur++) {
                if (nums[cur] != 0) 
                {
                    swap(ref nums[lastNonZeroFoundAt++], ref nums[cur]);
                }
            }
            
            
            Console.WriteLine(string.Join(",", Rotate(nums, 5)));
        }

        private static void swap(ref int i, ref int j)
        {
            (i, j) = (j, i);
        }
        
        public static int[] Rotate(int[] nums, int k)
        {
            while (k > nums.Length)
            {
                k = k > nums.Length ? k - nums.Length : k;
            }
            
            int index = nums.Length - k;
            int[] temp = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < index)
                {
                    temp[i + k] = nums[i];
                }
                else
                {
                    temp[i - index] = nums[i];
                }
            }

            nums = temp;
            return nums;
        }
    }
}