namespace AlgorithmsThirdLab.Operations;
using DataStructures;

public class IsEmptyCommand
{
    private Stack<string> stack;

    public IsEmptyCommand(Stack<string> stack) {
        this.stack = stack;
    }

    public void Execute()
    {
        stack.IsEmpty();
    }
}