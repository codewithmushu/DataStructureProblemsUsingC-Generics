using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure
{
     class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            Console.WriteLine("Peek: " + stack.Peek());

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }

            Console.ReadLine();
        }
    }
}
