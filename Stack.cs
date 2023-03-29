using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure
{
    class Stack<T>
    {
        private LinkedList<T> list;

        public Stack()
        {
            list = new LinkedList<T>();
        }

        public void Push(T item)
        {
            list.AddFirst(item);
        }

        public T Pop()
        {
            if (list.First == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T item = list.First.Value;
            list.RemoveFirst();
            return item;
        }

        public T Peek()
        {
            if (list.First == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return list.First.Value;
        }

        public bool IsEmpty()
        {
            return list.First == null;
        }


    }
}
