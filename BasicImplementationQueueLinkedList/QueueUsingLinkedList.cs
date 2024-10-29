using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicImplementationQueueLinkedList
{
    public class QueueUsingLinkedList<T>
    {
        private LinkedList<T> _list = new LinkedList<T>();

        // Enqueue an item to the queue (add to the rear of the list)
        public void Enqueue(T item)
        {
            _list.AddLast(item); // Add to the rear (tail) of the list
            Console.WriteLine($"Enqueued {item} to the queue.");
        }

        // Dequeue an item from the queue (remove from the front of the list)
        public T Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return default;
            }
            T value = _list.First.Value;
            _list.RemoveFirst(); // Remove the front node
            Console.WriteLine($"Dequeued {value} from the queue.");
            return value;
        }

        // Peek at the front item of the queue (front of the list)
        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return default;
            }
            return _list.First.Value; // Return the value at the front
        }

        // Check if the queue is empty
        public bool IsEmpty() => _list.Count == 0;
    }
}
