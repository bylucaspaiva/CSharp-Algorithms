using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimicJourney.LinkedListAlgorithms
{
    static public class LinkedListMethods
    {
        public static void LinkedListOperations()
        {
            LinkedList<string> listy = new LinkedList<string>();
            //AddLast, AddFirst
            listy.AddLast("Lucas");
            listy.AddLast("Kessia");
            listy.AddLast("Arthur");

            foreach(string item in listy)
            {
                Console.Write(item + "->");
            }
            Console.Write("null");

        }
    }
}
