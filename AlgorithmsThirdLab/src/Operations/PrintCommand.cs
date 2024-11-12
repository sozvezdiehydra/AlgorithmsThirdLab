namespace AlgorithmsThirdLab.Operations;
using DataStructures;

public class PrintCommand : ICommand
{
    private Stack<string> stack;

    public PrintCommand(Stack<string> stack)
    {
        this.stack = stack;
    }

    public void Execute()
    {
        stack.Print();
    }
}