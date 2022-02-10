using System.Collections.Generic;
using System.Linq;

namespace Sandbox
{
    // LeetCode 77
    // Given two integers n and k, return all possible combinations of k numbers out of the range [1, n]
    public class Combinations
    {
        public static void Execute()
        {
            int k = 2;
            int n = 4;

            Combine(n, k);
        }

        public static IList<IList<int>> Combine(int n, int k)
        {
            var list = new List<IList<int>>();
            GetCombination(n, k, new List<int>(), 1, list);
            return list;
        }

        private static void GetCombination(int n, int k, List<int> visited, int start, IList<IList<int>> result)
        {
            if (visited.Count == k)
            {
                result.Add(new List<int>(visited));
            }

            for (int i = start; i <= n; i++)
            {
                visited.Add(i);
                GetCombination(n, k, visited, i + 1, result);

                visited.RemoveAt(visited.Count - 1);
            }
        }
    }
}