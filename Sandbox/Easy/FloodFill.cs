using System.Data;

namespace Sandbox
{
    //#DFS
    //LeetCode 733
    public class FloodFill
    {
        public static void Execute()
        {
            int[][] image = new[]
            {
                new int[] {1, 1, 1},
                new int[] {1, 1, 0},
                new int[] {1, 0, 1}
            };

            Fill(image, 1, 1, 2);
        }

        public static int[][] Fill(int[][] image, int sr, int sc, int newColor)
        {
            if (image[sr][sc] == newColor)
            {
                return image;
            }

            Search(image, sr, sc, image[sr][sc], newColor);
            return image;
        }

        private static void Search(int[][] image, int sr, int sc, int sourceColor, int newColor)
        {
            if (sr >= image.GetLength(0) || sr < 0 ||
                sc >= image[0].GetLength(0) || sc < 0)
            {
                return;
            }

            if (image[sr][sc] != sourceColor)
            {
                return;
            }

            image[sr][sc] = newColor;

            Search(image, sr - 1, sc, sourceColor, newColor);
            Search(image, sr + 1, sc, sourceColor, newColor);
            Search(image, sr, sc - 1, sourceColor, newColor);
            Search(image, sr, sc + 1, sourceColor, newColor);
        }
    }
}