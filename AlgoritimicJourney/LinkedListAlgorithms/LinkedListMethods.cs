using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimicJourney.LinkedListAlgorithms
{

    

    public class CustomLinkedList
    {
        public Node head;

        public class Node
        {
            public int data;

            public Node next;
            public Node(int d) { data = d; }
        }

        public static void LinkedListOperations()
        {
            LinkedList<string> listy = new LinkedList<string>();
            //AddLast, AddFirst
            listy.AddLast("Lucas");
            listy.AddLast("Kessia");
            listy.AddLast("Arthur");
            listy.AddFirst("strings");
            listy.RemoveFirst();

            foreach (string item in listy)
            {
                Console.Write(item + "->");
            }
            Console.Write("null");
        }

        public void CustomLinkedListOperations()
        {
            CustomLinkedList linkedList = new CustomLinkedList();

            Node firstNode = new Node(1);
            Node secondNode = new Node(2);
            Node thirdNode = new Node(3);
            linkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;

            DeleteBackHalf(firstNode);

        }

        public void DeleteBackHalf(Node node)
        {   
            while(node != null)
            {
                Console.Write(node.data + "->");
                node = node.next;
            }
            Console.Write("null");

        }
    }
    

}