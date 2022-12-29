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
}

