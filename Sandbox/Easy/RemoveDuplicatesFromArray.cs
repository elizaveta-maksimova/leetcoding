using System;

namespace Sandbox
{
    public class RemoveDuplicatesFromArray
    {
        public static void Execute()
        {
            int[] numbers = new[] {1,1, 2};
            Console.WriteLine(Remove(numbers));
            
            // 1, 2, 4, 1, 4, 4
        }

        public static int Remove(int[] nums)
        {
            int j = 0; // unique

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[j+1] = nums [i]; 
                    j++;
                }
            }

            return j + 1;
        }
    }
}