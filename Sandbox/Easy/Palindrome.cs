namespace Sandbox
{
    public class Palindrome
    {
        public static bool IsPalindrome(int x) 
        {
            string array = x.ToString();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != array[array.Length - i - 1])
                {
                    return false;
                }
                    
            }
            
            return true;
        }
    }
}