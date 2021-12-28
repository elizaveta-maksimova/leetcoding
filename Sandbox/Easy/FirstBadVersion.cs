using System;

namespace Sandbox
{
    public class FirstBadVersion
    {
        public static void Execute()
        {
            Console.WriteLine(Search(5));
        }
        
        public static int Search(int n)
        {
            int left = 0;
            int right = n;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (!IsBadVersion(mid))
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

        private static bool IsBadVersion(int n)
        {
            return n == 4;
        }
    }
}