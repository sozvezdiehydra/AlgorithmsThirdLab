namespace AlgorithmsThirdLab.Operations;
using DataStructures;

public class PopCommand : ICommand
{
    private Stack<string> stack;

    public PopCommand(Stack<string> stack)
    {
        this.stack = stack;
    }
    public void Execute()
    {
        stack.Pop();
    }
}