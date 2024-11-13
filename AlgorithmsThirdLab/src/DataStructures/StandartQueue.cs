namespace AlgorithmsThirdLab.DataStructures;

public class StandardQueue<T>
{
    private Queue<T> queue;

    public StandardQueue()
    {
        queue = new Queue<T>();
    }
    
    public void Enqueue(T elem) 
    {
        queue.Enqueue(elem);
        Console.WriteLine($"Element '{elem}' adds into queue.");
    }
    
    public T Dequeue() 
    {
        if (IsEmpty()) 
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        T value = queue.Dequeue();
        Console.WriteLine($"From queue deleted element: {value}");
        return value;
    }
    
    public T Peek() 
    {
        if (IsEmpty()) 
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return queue.Peek();
    }
    
    public bool IsEmpty() 
    {
        return queue.Count == 0;
    }
    
    public void Print() 
    {
        if (IsEmpty()) 
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        Console.WriteLine("Queue elements:");
        foreach (var item in queue) 
        {
            Console.WriteLine(item);
        }
    }
}