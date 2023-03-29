using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            var queue = new LinkedListQueue<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            Console.WriteLine("Initial queue:");
            PrintQueue(queue);


            var dequeuedItem = queue.Dequeue();
            Console.WriteLine($"Dequeued item: {dequeuedItem}");
            Console.WriteLine("Queue after dequeue:");
            PrintQueue(queue);

            var peekedItem = queue.Peek();
            Console.WriteLine($"Peeked item: {peekedItem}");
            Console.WriteLine("Queue after peek:");
            PrintQueue(queue);

            Console.ReadLine();



        }

        static void PrintQueue(LinkedListQueue<int> queue)
        {
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
