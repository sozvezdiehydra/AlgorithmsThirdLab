namespace AlgorithmsThirdLab.Operations;
using DataStructures;

public class PushCommand : ICommand
{
    private Stack<string> stack;
    private string value;

    public PushCommand(Stack<string> stack, string value) 
    {
        this.stack = stack;
        this.value = value;
    }
    
    public void Execute() 
    {
        stack.Push(value); 
        //Console.WriteLine($"Элемент '{value}' добавлен в стек.");
    }
}