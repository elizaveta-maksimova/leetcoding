using System;
using System.Linq;

namespace Sandbox
{
    public class SquaresOfSortedArray
    {
        public static void Execute()
        {
            int[] array = {-5,-3,-2,-1};

            var result = SortedSquaresPointers(array);
            Console.WriteLine(string.Join(",", result));
        }

        public static int[] SortedSquaresPointers(int[] nums)
        {
            int positiveIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 0)
                {
                    positiveIndex = i;
                    break;
                }
            }

            int[] temp = new int[nums.Length];

            int leftIndex = positiveIndex != -1 ? positiveIndex - 1 : nums.Length - 1;
            int leftEnd = 0;

            int rightIndex = positiveIndex != -1 ? positiveIndex : 0;
            int rightEnd = nums.Length - 1;

            int tempIndex = 0;

            while (leftIndex >= 0 && rightIndex < nums.Length)
            {
                int leftSquare = nums[leftIndex] * nums[leftIndex];
                int rightSquare = nums[rightIndex] * nums[rightIndex];

                if (leftSquare <= rightSquare)
                {
                    temp[tempIndex] = leftSquare;
                    leftIndex--;
                }
                else
                {
                    temp[tempIndex] = rightSquare;
                    rightIndex++;
                }

                tempIndex++;
            }

            while (leftIndex > 0 && tempIndex < nums.Length)
            {
                temp[tempIndex++] = nums[leftIndex] * nums[leftIndex];
                leftIndex--;

            }

            while (rightIndex < nums.Length && tempIndex < nums.Length)
            {
                temp[tempIndex++] = nums[rightIndex] * nums[rightIndex];
                rightIndex++;
            }

            return temp;
        }
        
        public static int[] SortedSquares(int[] nums)
        { 
             var squares = nums.Select(n => n * n).ToArray();
             Array.Sort(squares);

             return squares;
        }
    }
}