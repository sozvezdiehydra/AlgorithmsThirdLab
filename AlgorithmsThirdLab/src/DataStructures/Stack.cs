namespace AlgorithmsThirdLab.DataStructures;

public class Stack<T>
{
    private LinkedListNode<T> top;

    public void Push(T elem)
    {
        var newNode = new LinkedListNode<T>(elem);
        newNode.Next = top;
        top = newNode;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T value = top.Value;
        top = top.Next;
        return value;
    }

    public T Top()
    {
        if (IsEmpty()) {
            throw new InvalidOperationException("Stack is empty");
        }
        return top.Value;
    }

    public bool IsEmpty()
    {
        return top == null;
    }

    public void Print()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty");
            return;
        }

        var current = top;
        while (current is not null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}