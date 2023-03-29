using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProblem
{
    public class LinkedListQueue<T> : IEnumerable<T>
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;

        public int Count { get; private set; }

        public void Enqueue(T value)
        {
            var newNode = new LinkedListNode<T>(value);
            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
            Count++;
        }

        public T Dequeue()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            var value = head.Value;
            head = head.Next;
            if (head == null)
            {
                tail = null;
            }
            Count--;
            return value;
        }

        public T Peek()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return head.Value;
        }


        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }



}
