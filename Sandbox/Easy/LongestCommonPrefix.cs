using System;
using System.Linq;

namespace Sandbox
{
    public class LongestCommonPrefix
    {
        // Write a function to find the longest common prefix string amongst an array of strings.
        // If there is no common prefix, return an empty string "".

        public static void Execute()
        {
            string[] array = new[] {"flower", "flow", "flowing", "flight"};
            // string[] array = new[] {"ab", "a"};
            Console.WriteLine(Execute(array));
        }

        public static string Execute(string[] strs)
        {
            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "") return prefix;
                }
            }

            return prefix;
        }
    }
}