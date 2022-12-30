using System;
using AlgoritimicJourney.ArrayAlgorithms;
using AlgoritimicJourney.SimpleAlgorithms;
using AlgoritimicJourney.StringAlgorithms;

namespace Algorithms {
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = {1, 2, 3, 4, 9, 756, 5, 10};
            bool result = ArrayMethods.BinarySearch(n, 756);
            Console.WriteLine(result);
        }

      
    }
}

