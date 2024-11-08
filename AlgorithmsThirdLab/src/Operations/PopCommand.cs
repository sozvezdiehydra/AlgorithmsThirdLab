namespace AlgorithmsThirdLab.Operations;

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