using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimicJourney.SimpleAlgorithms;

public static class SimpleAlgorithms
{
    public static int findMaximum(int a, int b, int c)
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

}
