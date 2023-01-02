using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimicJourney.LinkedListAlgorithms;

public class CustomLinkedList
{
    Node head;
    public class Node
    {
        public int data;

        public Node next;
        public Node(int d) { data = d; }
    }
}
static public class LinkedListMethods
{
    public static void LinkedListOperations()
    {
        LinkedList<string> listy = new LinkedList<string>();
        //AddLast, AddFirst
        listy.AddLast("Lucas");
        listy.AddLast("Kessia");
        listy.AddLast("Arthur");
        listy.AddFirst("strings");
        listy.RemoveFirst();

        foreach(string item in listy)
        {
            Console.Write(item + "->");
        }
        Console.Write("null");

    }
};


