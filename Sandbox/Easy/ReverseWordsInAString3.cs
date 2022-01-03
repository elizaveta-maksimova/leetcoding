using System;
using System.Text;

namespace Sandbox
{
    public class ReverseWordsInAString3
    {
        public static void Execute()
        {
            var result = ReverseWords2("Let's LeetCode amigo");
            Console.WriteLine(result);
        }
        
        public static string ReverseWords(string s)
        {
            var words = s.Split(' ');

            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < words.Length; i++)
            {
                var array = words[i].ToCharArray();
                ReverseString.ReverseStringChars(array);

                sb.Append(array);
                sb.Append(' ');
            }

            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }
        
        public static string ReverseWords2(string s)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sbFinal = new StringBuilder();
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    var array = sb.ToString().ToCharArray();
                    ReverseString.ReverseStringChars(array);
                    sbFinal.Append(array);
                    sbFinal.Append(' ');

                    sb.Clear();
                }
                else if (i == s.Length - 1)
                {
                    sb.Append(s[i]);
                    var array = sb.ToString().ToCharArray();
                    ReverseString.ReverseStringChars(array);
                    sbFinal.Append(array);
                } else
                {
                    sb.Append(s[i]);
                }
            }

            return sbFinal.ToString();
        }
    }
}