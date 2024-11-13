using System.Diagnostics;
using AlgorithmsThirdLab.DataStructures;

namespace AlgorithmsThirdLab.Utilities
{
    public class TimeMeasurement
    {
        private readonly FileReader fileReader;

        public TimeMeasurement()
        {
            fileReader = new FileReader();
        }

        public void Run()
        {
            string[] lines = fileReader.FileRead();
            DataStructures.Stack<string> stack = new DataStructures.Stack<string>();

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (var line in lines)
            {
                string[] commands = line.Split(' ');

                foreach (var command in commands)
                {
                    ExecuteCommand(stack, command);
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"Время выполнения операций: {stopwatch.ElapsedMilliseconds} мс");
        }

        private void ExecuteCommand(DataStructures.Stack<string> stack, string command)
        {
            if (command.StartsWith("1,"))
            {
                var value = command.Substring(2);
                stack.Push(value);
                Console.WriteLine($"Push: {value}");
            }
            else if (command == "2")
            {
                try
                {
                    var poppedValue = stack.Pop();
                    Console.WriteLine($"Pop: {poppedValue}");
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
                    var topValue = stack.Top();
                    Console.WriteLine($"Top: {topValue}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (command == "4")
            {
                Console.WriteLine($"IsEmpty: {stack.IsEmpty()}");
            }
            else if (command == "5")
            {
                Console.Write("Стек:\n");
                stack.Print();
            }
            else
            {
                Console.WriteLine($"Неизвестная команда: {command}");
            }
        }
    }
}