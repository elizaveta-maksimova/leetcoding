using System;
using System.Collections.Generic;

namespace Sandbox
{
    public class MaximumSubArray
    {
        public static void Execute()
        {
            FindMaximumSubArray(new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4});
        }
        
        public static int FindMaximumSubArray(int[] nums)
        {
            int max = nums[0];
            int currentMax = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                int temp = currentMax+nums[i];
                currentMax = Math.Max(temp, nums[i]);
                max = System.Math.Max(max, currentMax);
            }
        
            return max;
        }
    }
}