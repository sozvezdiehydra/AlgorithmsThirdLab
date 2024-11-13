using System;
using System.Collections.Generic;

namespace AlgorithmsThirdLab.src.Algorithms;

internal class PostfixEvaluator
{
    public double result;

    public void Calculator(List<Token> tokens)
    {
        result = EvaluatePostfix(tokens);
    }
    private static double EvaluatePostfix(List<Token> tokens)
    {
        Stack<double> stack = new Stack<double>();

        foreach (Token token in tokens)
        {
            if (token is Number number) // Если токен - число
            {
                stack.Push(number.Symbol);
            }
            else if (token is Operation operation) // Если токен - операция
            {
                if (stack.Count < operation.RequiredOperands)
                    throw new InvalidOperationException("Недостаточно операндов для выполнения операции.");

                // Извлекаем необходимое количество операндов
                var operands = new double[operation.RequiredOperands];
                for (int i = operation.RequiredOperands - 1; i >= 0; i--)
                {
                    operands[i] = stack.Pop();
                }

                // Выполняем операцию и кладем результат в стек
                double result = operation.Perform(operands);
                stack.Push(result);
            }
            else
            {
                throw new InvalidOperationException("Неизвестный тип токена.");
            }
        }

        // Если после всех операций в стеке остался один элемент - это результат
        if (stack.Count != 1)
            throw new InvalidOperationException("Некорректное постфиксное выражение.");

        return stack.Pop();
    }
}
