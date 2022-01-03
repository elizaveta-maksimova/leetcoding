using System;
using System.Runtime.CompilerServices;

namespace Sandbox
{
    public class TwoSumSorted
    {
        public static void Execute()
        {
            int[] numbers = new[] {-1 ,0};
            int target = -1;
            Console.WriteLine(string.Join(",", TwoSum(numbers, target)));
        }
        
        public static int[] TwoSum(int[] numbers, int target)
        {
            int pointer1 = 0;
            int pointer2 = numbers.Length - 1;

            while (pointer1 != pointer2)
            {
                int sum = numbers[pointer1] + numbers[pointer2];
                if (sum > target)
                {
                    pointer2--;
                }
                else if (sum < target)
                {
                    pointer1++;
                }
                else
                {
                    return new int[] {pointer1 + 1, pointer2 + 1};
                }
            }

            return Array.Empty<int>();
        }
    }
}