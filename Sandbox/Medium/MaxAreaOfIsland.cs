using System;

namespace Sandbox
{
    //#DFS
    //LeetCode 695
    public class MaxAreaOfIsland
    {
        public static void Execute()
        {
            int[][] grid = new[]
            {
                new int[] {1, 1, 1},
                new int[] {1, 1, 0},
                new int[] {1, 0, 1}
            };

            Console.WriteLine(FindMaxAreaOfIsland(grid));
        }

        public static int FindMaxAreaOfIsland(int[][] grid)
        {
            int rows = grid.GetLength(0);
            int columns = grid[0].GetLength(0);

            int maxLength = 0;

            bool[,] visited = new bool[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    var result = FindArea(grid, i, j, visited);
                    maxLength = Math.Max(maxLength, result);
                }
            }

            return maxLength;
        }

        public static int FindArea(int[][] grid, int row, int column, bool[,] visited)
        {
            if (row >= grid.GetLength(0) || row < 0 ||
               column >= grid[0].GetLength(0) || column < 0)
            {
                return 0;
            }

            if (grid[row][column] == 0 || visited[row,column])
            {
                return 0;
            }

            visited[row,column] = true;

            int left = FindArea(grid, row, column - 1, visited);
            int right = FindArea(grid, row, column + 1, visited);
            int top = FindArea(grid, row - 1, column, visited);
            int bottom = FindArea(grid, row  + 1, column, visited);

            return 1 + left + right + top + bottom;
        }
    }
}