using System;
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
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int removedItem = queue.Dequeue();
            Console.WriteLine(removedItem);

        }
    }
}
