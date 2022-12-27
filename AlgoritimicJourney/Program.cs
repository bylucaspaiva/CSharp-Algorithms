using System;

namespace Algorithms {
    class Program
    {
        static int findMaximum(int a, int b, int c)
        {
            // this is the most efficient way of test which variable is the max value
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                c = max;
            }

            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(findMaximum(8, 2, 4));
        }
    }
}

