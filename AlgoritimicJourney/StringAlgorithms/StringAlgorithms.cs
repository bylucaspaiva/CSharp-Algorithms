using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimicJourney.StringAlgorithms
{
    internal class StringAlgorithms
    {
        static Boolean IsUpperCase(string s)
        {
            return s.All(char.IsUpper);
        }
        static Boolean IsLowerCase(string s)
        {
            return s.All(char.IsLower);
        }
    }
}
