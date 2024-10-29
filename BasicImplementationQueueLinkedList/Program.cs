using BasicImplementationQueueLinkedList;

QueueUsingLinkedList<int> queue = new QueueUsingLinkedList<int>();

// Enqueue elements into the queue
queue.Enqueue(10); // Queue: 10
queue.Enqueue(20); // Queue: 10, 20
queue.Enqueue(30); // Queue: 10, 20, 30

// Peek the front element
Console.WriteLine($"Front element is {queue.Peek()}"); // Output: Front element is 10

// Dequeue elements from the queue
queue.Dequeue(); // Removes 10, Queue: 20, 30
queue.Dequeue(); // Removes 20, Queue: 30

// Check if the queue is empty
Console.WriteLine($"Is queue empty? {queue.IsEmpty()}");

queue.Dequeue();

Console.WriteLine($"Front element is {queue.Peek()}");

Console.WriteLine($"Is queue empty? {queue.IsEmpty()}");
