using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimicJourney.StringAlgorithms
{
    public class StringAlgorithms
    {
        static Boolean IsUpperCase(string s)
        {
            return s.All(char.IsUpper);
        }
        static Boolean IsLowerCase(string s)
        {
            return s.All(char.IsLower);
        }

        public static Boolean IsPasswordComplex(string s)
        {
            return s.Any(char.IsDigit) && s.Any(char.IsUpper) && s.Any(char.IsLower);
        }

        public static String NormalizeString(string s)
        {
            return s.ToLower().Trim().Replace(",", "");      //Trim removes white spaces from start and end
        }

        public static String Reverse(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }
            StringBuilder reverse = new StringBuilder(s.Length);

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse.Append(s[i]);
            }

            return reverse.ToString();
        }

        public static string ReverseEachWord(string s)
        {
            if(string.IsNullOrEmpty(s))
            { 
            return s;
            }

            StringBuilder result = new StringBuilder(s.Length);

            string[] arr = s.Split(" ");
            for(int i = 0; i < arr.Length; i++)
            {
                result.Append(Reverse(arr[i]));
                if(i != arr.Length - 1)
                {
                    result.Append(' ');
                }
            }

            return result.ToString();
        }
    }
}
