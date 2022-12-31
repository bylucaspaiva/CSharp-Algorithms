using System;
using System.Collections;
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

    private static int[] IsEvenArrayNumbers(int[] arr)
    {
        ArrayList result = new ArrayList();
        foreach(int num in arr)
        {
            if(num % 2 == 0)
            {
                result.Add(num);
            }
        }
        return (int[])result.ToArray(typeof(int));
    }

    // take 2 arrays and aggregate only the even numbers in a new array
    public static int[] FindEvenNumbers(int[] arr1, int[] arr2)
    {
        ArrayList result = new ArrayList();

        foreach(int number in arr1)
        {
            if (number % 2 == 0)
            {
                result.Add(number);
            }
        }

        foreach (int number in arr2)
        {
            if (number % 2 == 0)
            {
                result.Add(number);
            }
        }

        return (int[])result.ToArray(typeof(int));
    }

    public static int[] ReverseArray(int[] array)
    {
        int[] reverse = new int[array.Length];

        for(int i = array.Length - 1; i >= 0 ; i--)
        {
            reverse[array.Length - 1 - i] = array[i];
        }

        return reverse;
    }

    public static void RotateArray(int[] array, int n)
    {
        int[] temp = new int[array.Length];
        
        if(n > 0)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                temp[i] = array[array.Length - n + i];
            }
            for (int i = array.Length - 1; i >= n; --i)
            {
                array[i] = array[i - n];
            }
            for(int i = 0; i < n; ++i)
            {
                array[i] = temp[i];
            }
        }
        else
        {
            for (int i = 0; i < array.Length; ++i)
            {
                temp[i] = array[i];
            }

            for (int i = 0; i < array.Length - n; ++i)
            {
                array[i] = array[i + n];
            }
            for (int i = 0; i < n; ++i)
            {
                array[array.Length - n + i] = array[i];
            }
        }



    }
}

