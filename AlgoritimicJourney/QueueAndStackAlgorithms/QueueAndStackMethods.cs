﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimicJourney.QueueAndStackAlgorithms
{
    public class QueueAndStackCommonMethods
    {
        public void DisplayContent()
        {
            PrintBinary(100);
        }

        public void SimpleQueue()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int removedItem = queue.Dequeue();
            Console.WriteLine(queue.Peek());
            Console.WriteLine(removedItem);

            int current;
            while (queue.TryDequeue(out current))
            {
                Console.WriteLine(current);
            }
        }

        public void PrintBinary(int n)
        {
            if (n < 0) return;
            var queue = new Queue<int>();
            queue.Enqueue(1);
            for(int i = 0; i < n; i++)
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);
                queue.Enqueue(current * 10);
                queue.Enqueue(current * 10 + 1);
            }

            Console.WriteLine();    
        }
    }
}
