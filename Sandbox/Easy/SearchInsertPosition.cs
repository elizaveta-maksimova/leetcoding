using System;

namespace Sandbox
{
    public class SearchInsertPosition
    {
        public static void Execute()
        {
            int[] nums = {-1, 0, 3, 5, 6, 16, 21, 33, 50};
            int target = -3;

            Console.WriteLine(Search(nums, target));
        }
        
        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (nums[mid] == target)
                {
                    return mid;
                }
                
                if (target > nums[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left;
        }
    }
}