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
    }
}
