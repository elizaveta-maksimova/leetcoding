using System;
using System.Collections.Generic;

namespace Sandbox
{
    //#SlidingWindow
    public class LongestSubstring
    {
        public static void Execute()
        {
            Console.WriteLine(LengthOfLongestSubstring("b"));
        }

        public static int LengthOfLongestSubstring(string s)
        {
            HashSet<char> temp = new HashSet<char>();

            int length = 0;

            if (string.IsNullOrEmpty(s))
            {
                return length;
            }

            if (s.Length == 1)
            {
                return 1;
            }

            int leftAnchor = 0;

            foreach (var sChar in s)
            {
                while (temp.Contains(sChar))
                {
                    temp.Remove(s[leftAnchor]);
                    leftAnchor++;
                }

                temp.Add(sChar);
                length = Math.Max(temp.Count, length);
            }

            return length;
        }
    }
}