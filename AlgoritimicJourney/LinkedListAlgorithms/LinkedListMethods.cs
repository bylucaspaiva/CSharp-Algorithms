using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgoritimicJourney.LinkedListAlgorithms.CustomLinkedList;

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
            Node fourthNode = new Node(4);
            linkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            DeleteBackHalf(firstNode, linkedList.head);
            DisplayContents(linkedList.head);
;
        }

        public void DeleteBackHalf(Node node, Node head)
        {

            if (head == null || head.next == null)
            {
                head = null;
            }
            Node slow = head;
            Node fast = head;
            Node prev = null;

            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            prev.next = null;

        }

        public void DisplayContents(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + "->");
                head = head.next;
            }
            Console.Write("null");
        }
    }

}