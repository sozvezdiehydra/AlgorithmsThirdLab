using System.Diagnostics;
using AlgorithmsThirdLab.DataStructures;
using AlgorithmsThirdLab.Utilities;

namespace AlgorithmsThirdLab.Utilities;

public class QueueProcessor<T>
{
    private readonly FileReader? fileReader;

    public QueueProcessor()
    {
        fileReader = new FileReader();
    }

    public void Run()
    {
        string[] lines = fileReader.FileRead();
        DataStructures.StandardQueue<string> standardQueue = new DataStructures.StandardQueue<string>();

        var stopwatch = new Stopwatch();
        stopwatch.Start();
        foreach (var line in lines)
        {
            string[] commands = line.Split(' ');

            foreach (var command in commands)
            {
                ExecuteCommand(standardQueue, command);
            }
        }

        stopwatch.Stop();
        Console.WriteLine($"Время выполнения операций: {stopwatch.ElapsedMilliseconds} мс");
    }

    private void ExecuteCommand(StandardQueue<string> standardQueue, string command)
    {
        if (command.StartsWith("1,"))
        {
            var value = command.Substring(2);
            standardQueue.Enqueue(value);
            Console.WriteLine($"Enqueue: {value}");
        }
        else if (command == "2")
        {
            try
            {
                var poppedValue = standardQueue.Dequeue();
                Console.WriteLine($"Dequeue: {poppedValue}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else if (command == "3")
        {
            try
            {
                var topValue = standardQueue.Peek();
                Console.WriteLine($"Top: {topValue}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else if (command == "4")
        {
            Console.WriteLine($"IsEmpty: {standardQueue.IsEmpty()}");
        }
        else if (command == "5")
        {
            Console.Write("Queue:\n");
            standardQueue.Print();
        }
        else
        {
            Console.WriteLine($"Unknown command: {command}");
        }
    }
}
