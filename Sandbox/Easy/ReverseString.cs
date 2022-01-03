namespace Sandbox
{
    public class ReverseString
    {
        public static void Execute()
        {
            char[] array = new[] {'H', 'a', 'n'};
            ReverseStringChars(array);
        }

        public static void ReverseStringChars(char[] s)
        {
            int j = s.Length - 1;
            char temp;
            for (int i = 0; i < s.Length; i++)
            {
                if (i > j)
                {
                    break;
                }

                temp = s[j];
                s[j] = s[i];
                s[i] = temp;
                j--;
            }
        }
    }
}