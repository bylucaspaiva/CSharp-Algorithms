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
            int[] arr = new int[] { 15, 8, 4, 10 };
            Console.WriteLine(HasMatchingParentheses("((Hello))"));
            Console.WriteLine(HasMatchingParentheses("((Hello)()"));
            Console.WriteLine(HasMatchingParentheses("((Hello))()"));


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
            //Prints every binary until n;
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

        public void SimpleStack()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            stack.Push(3);

            int current;
            while(stack.TryPop(out current))
            {
                Console.WriteLine(current); 
            }
        }

        public void PrintNextGreaterElement(int[] arr)
        {
            var stack = new Stack<int>();
            stack.Push(arr[0]);

            for(int i = 1; i < arr.Length; i++)
            {
                int next = arr[i];
                if(stack.Count > 0)
                {
                    int popped = stack.Pop();

                    while(popped < next)
                    {
                        Console.WriteLine(popped + "-->" + next);
                        if(stack.Count == 0) break;
                        popped = stack.Pop();
                    }
                    if(popped > next)
                    {
                        stack.Push(popped);
                    }
                }
                stack.Push(next);
            }
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop() + "-->" + -1);
            }
        }
        public bool HasMatchingParentheses(string s)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                if (current == '(')
                {
                    stack.Push(current);
                    continue;
                }

                if (current == ')')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
