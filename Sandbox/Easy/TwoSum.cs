using System.Collections.Generic;
using System.Linq;

namespace Sandbox
{
    public class TwoSum
    {
        // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        // You may assume that each input would have exactly one solution, and you may not use the same element twice.
        // You can return the answer in any order.

        public static int[] Execute(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            var indices = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                dict.Add(nums[i], i);
                int complement = target - nums[i];
                if (!dict.ContainsKey(complement))
                {
                    continue;
                }

                indices.Add(i);
                indices.Add(dict[complement]);
            }

            return indices.ToArray();
        }
    }
}