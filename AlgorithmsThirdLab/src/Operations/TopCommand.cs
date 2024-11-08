namespace AlgorithmsThirdLab.Operations;
using DataStructures;

public class TopCommand
{
    private Stack<string> stack;

    public TopCommand(Stack<string> stack) 
    {
        this.stack = stack;
    }

    public void Execute()
    {
        stack.Top();
    }
}