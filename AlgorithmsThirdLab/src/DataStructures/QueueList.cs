using AlgorithmsThirdLab.Operations;

namespace AlgorithmsThirdLab.DataStructures;

public class QueueList<T>
{
    private LinkedListNode<T> head;
    private LinkedListNode<T> tail;

    public QueueList()
    {
        head = null;
        tail = null;
    }

    public void Enqueue(T elem)
    {
        var newNode = new LinkedListNode<T>(elem);
        if (IsEmpty())
        {
            head = newNode;
        }
        else
        {
            tail.Next = newNode;
        }

        tail = newNode;
    }
    
    public T Dequeue() 
    {
        if (IsEmpty()) 
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        T value = head.Value;
        head = head.Next;
        if (head == null) 
        {
            tail = null;  // Если очередь стала пустой, сбросить tail
        }
        Console.WriteLine($"From queue deleted element: {value}");
        return value;
    }

    private bool IsEmpty()
    {
        return head == null;
    }
    
    public T Peek() 
    {
        if (IsEmpty()) 
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return head.Value;
    }
    
    public void Print() 
    {
        if (IsEmpty()) 
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        Console.WriteLine("Queue elements:");
        var current = head;
        while (current != null) 
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}