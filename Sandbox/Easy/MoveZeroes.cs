using System;
using System.Net;

namespace Sandbox
{
    public class MoveZeroes
    {
        public static void Execute()
        {
            int[] nums = {1, 2, 0 ,5, 0 ,0, 6};
            
            for (int j = 0, i = 0; i < nums.Length; i++) {
                if (nums[i] != 0) 
                {
                    Swap(ref nums[j++], ref nums[i]);
                }
            }
        }

        private static void Swap(ref int i, ref int j)
        {
            (i, j) = (j, i);
        }
    }
}