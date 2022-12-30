using System;
using AlgoritimicJourney.ArrayAlgorithms;
using AlgoritimicJourney.SimpleAlgorithms;
using AlgoritimicJourney.StringAlgorithms;

namespace Algorithms {
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1, 2, 3, 4, 9, 756, 5, 10};
            int[] arr2 = { -4, 5, -6, 8, 22, 36 };
            int[] result = ArrayMethods.FindEvenNumbers(arr1, arr2);
            Array.ForEach(result, Console.WriteLine);
        }

      
    }
}

