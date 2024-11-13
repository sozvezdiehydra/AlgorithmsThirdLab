using System;
using AlgorithmsThirdLab.Algorithms;
using AlgorithmsThirdLab.src.Algorithms;

namespace AlgorithmsThirdLab
{
    class Program
    {
        // Временный main ля тестов PostfixEvaluator и InfixToPostfixConverter
        static void Main(string[] args)
        {
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