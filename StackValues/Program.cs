using System;
using System.Collections.Generic;

namespace StackQueue_uc4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            queue.Dequeue();

            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");
            Console.WriteLine(queue.Peek());
            Console.ReadLine();
        }
        
    }
}