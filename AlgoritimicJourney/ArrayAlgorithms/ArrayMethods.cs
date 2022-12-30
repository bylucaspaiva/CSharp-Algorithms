using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimicJourney.ArrayAlgorithms;

public class ArrayMethods
{
    //An static method can be accessed without an instance of an class be created
    public static bool LinearSearch(int[] input, int n)
    {
        foreach(int current in input)
        {
            if(current== n) return true;
        }
        return false;
    }

    public static bool BinarySearch(int[] input, int n)
    {
        int end = input.Length - 1;
        int start = 0;
        int i = 1;
        while(start <= end)
        {
            Console.WriteLine($"Iteration {i}");
            int mid = (start + end) / 2;
            if(n == input[mid])
            {
                return true;
            }else if(n > input[mid])
            {
                start = mid + 1;
            }else
            {
                end = mid - 1;
            }
            i++;
        }
        return false;
    }
}

