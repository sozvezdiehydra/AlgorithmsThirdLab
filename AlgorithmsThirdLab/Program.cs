using System;
using System.Xml;
using AlgorithmsThirdLab.Algorithms;
using AlgorithmsThirdLab.src.Algorithms;
using AlgorithmsThirdLab.Utilities;

namespace AlgorithmsThirdLab
{
    class Program
    {
        // Временный Main ля тестов TimeMeasurement, PostfixEvaluator и InfixToPostfixConverter
        static void Main(string[] args)
        {
            // Для запуска необоходимо создать файл "input.txt" в папке
            // AlgorithmsThirdLab\AlgorithmsThirdLab\bin\Debug\net8.0\
            TimeMeasurement timeMeasurement = new TimeMeasurement();
            timeMeasurement.Run();
            Console.WriteLine("-----------");
            TestInfixToPostfixConverter();
        }

        static void TestInfixToPostfixConverter()
        {
            var converter = new InfixToPostfixConverter();
            var calculator = new PostfixEvaluator();

            string[] expressions = {
                "3 + 4 * 2 / ( 1 - 5 ) ^ 2 ^ 3",
                "5 * ( 6 + 2 ) - 12 / 4",
                "10 + sin(0.5) * 2",
                "sqrt(16) + log(2, 8)",
                "2 + 3 * (3 + 2)"
            };

            foreach (var expression in expressions)
            {
                try
                {
                    Console.WriteLine($"Инфиксное выражение: {expression}");
                    calculator.Calculator(converter.Converter(expression));
                    Console.WriteLine($"Постфиксная запись: {converter.result}");

                    double finalResult = calculator.result;
                    Console.WriteLine($"Результат: {finalResult}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при обработке выражения \"{expression}\": {ex.Message}\n");
                }
            }
        }
    }
}