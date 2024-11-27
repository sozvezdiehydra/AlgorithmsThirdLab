using AlgorithmsThirdLab.Algorithms;
using AlgorithmsThirdLab.src.Algorithms;
using AlgorithmsThirdLab.Utilities;
using AlgorithmsThirdLab.DataStructures;
using AlgorithmsThirdLab.src.Utilities;

namespace AlgorithmsThirdLab
{
    class Program
    {
        // Временный Main dля тестов TimeMeasurement, PostfixEvaluator и InfixToPostfixConverter
        static void Main(string[] args)
        {
            // Для запуска необоходимо создать файл "input.txt" в папке
            // AlgorithmsThirdLab\AlgorithmsThirdLab\bin\Debug\net8.0\
            TimeMeasurement timeMeasurement = new TimeMeasurement();
            timeMeasurement.Run();
            Console.WriteLine("------------------------------------------------------------------");

            TestInfixToPostfixConverter();
            Console.WriteLine("------------------------------------------------------------------");

            QueueProcessor<string> queueProcessor = new QueueProcessor<string>();
            queueProcessor.Run();
            Console.WriteLine("------------------------------------------------------------------");

            QueueListProcessor<string> queueListProcessor = new QueueListProcessor<string>();
            queueListProcessor.Run();
            Console.WriteLine("------------------------------------------------------------------");

            Node root = new Node('A',
            new Node('B',
                new Node('C'),
                new Node('D')
            ),
            new Node('I',
                null,
                new Node('F',
                    new Node('G'),
                    null
                )
            )
        );

            TreeTraverser tree = new TreeTraverser(root);
            string traversal = tree.Traverse(tree.Root);
            Console.WriteLine("Binary Tree");
            Console.WriteLine(traversal);
            Console.WriteLine("------------------------------------------------------------------");
            LinkedListMenu();
        }

        static void LinkedListMenu()
        {
            CustomLinkedList<int> list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            while (true)
            {
                Console.Clear();
                Console.Write("Работа со Связным списком -> ");
                list.Print();

                Console.WriteLine("\nВыберите алгоритм:\n");
                Console.WriteLine("1. Перевернуть список.");
                Console.WriteLine("2. Перенос первого элемента в конец списка.");
                Console.WriteLine("3. Перенос последнего элемента в начало списка.");
                Console.WriteLine("4. Подсчет уникальных элементов.");
                Console.WriteLine("5. Удаление неуникальных элементов.");
                Console.WriteLine("6. Вставка списка самого в себя после x.");
                Console.WriteLine("7. Вставка элемента E, сохраняя упорядоченность.");
                Console.WriteLine("8. Удаление всех элементов E.");
                Console.WriteLine("9. Вставка F перед первым E.");
                Console.WriteLine("10. Дописать список E к текущему списку.");
                Console.WriteLine("11. Разделить список по X.");
                Console.WriteLine("12. Удвоить список.");
                Console.WriteLine("13. Поменять местами два элемента.");
                Console.WriteLine("0. Вернуться в главное меню.");
                Console.WriteLine();
                Console.Write("Введите номер: ");

                if (!int.TryParse(Console.ReadLine(), out int listChoice))
                {
                    Console.WriteLine();
                    Console.WriteLine("\nОшибка: введено некорректное значение. Пожалуйста, введите число.\n");
                    Console.WriteLine("Нажмите любую клавишу, чтобы попробовать снова...");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine();

                switch (listChoice) // Лютый хардкод, убейте меня. Это пиздец... Боги такого не простят
                {
                    case 1:
                        if (list.IsEmpty)
                        {
                            Console.WriteLine("Список пуст!");
                            break;
                        }

                        Console.WriteLine("Переворачиваем список...");
                        list.Flip();

                        Console.Write("Результат = ");
                        list.Print();

                        break;
                    case 2:
                        if (list.IsEmpty)
                        {
                            Console.WriteLine("Список пуст!");
                            break;
                        }

                        Console.WriteLine("Переносим первый элемент в конец...");
                        list.MoveFirstToLast();

                        Console.Write("Результат = ");
                        list.Print();

                        break;
                    case 3:
                        if (list.IsEmpty)
                        {
                            Console.WriteLine("Список пуст!");
                            break;
                        }

                        Console.WriteLine("Переносим последний элемент в начало...");
                        list.MoveLastToFirst();

                        Console.Write("Результат = ");
                        list.Print();

                        break;
                    case 4:
                        if (list.IsEmpty)
                        {
                            Console.WriteLine("Список пуст!");
                            break;
                        }

                        Console.WriteLine("Подсчитываем уникальные элементы...");
                        Console.WriteLine($"Результат = {list.CountUnique()}");

                        break;
                    case 5:
                        if (list.IsEmpty)
                        {
                            Console.WriteLine("Список пустой!");
                            break;
                        }

                        Console.WriteLine("Удаляем неуникальные элементы...");
                        list.RemoveNonUnique();

                        Console.Write("Результат = ");
                        list.Print();

                        break;
                    case 6:
                        {
                            if (list.IsEmpty)
                            {
                                Console.WriteLine("Список пуст!");
                                break;
                            }

                            Console.Write("Введите X: ");
                            string? input = Console.ReadLine();

                            Console.WriteLine();

                            if (int.TryParse(input, out int x))
                            {
                                if (list.DuplicateAfter(x))
                                {
                                    Console.WriteLine($"{x} найден, вставляем список...");
                                    Console.Write("Результат = ");
                                    list.Print();

                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"{x} не был найден в списке.");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: необходимо ввести числовое значение.");
                                break;
                            }
                        }
                    case 7:
                        {
                            Console.Write("Введите Е: ");
                            string? input = Console.ReadLine();

                            Console.WriteLine();

                            if (int.TryParse(input, out int e))
                            {
                                Console.WriteLine($"Вставляем {e} в нужное место...");
                                list.AddInOrder(e);
                                Console.Write("Результат = ");
                                list.Print();

                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: необходимо ввести числовое значение.");

                                break;
                            }
                        }
                    case 8:
                        {
                            if (list.IsEmpty)
                            {
                                Console.WriteLine("Список пуст!");
                                break;
                            }

                            Console.Write("Введите E: ");
                            string? input = Console.ReadLine();

                            Console.WriteLine();

                            if (int.TryParse(input, out int e))
                            {
                                if (list.RemoveAll(e))
                                {
                                    Console.WriteLine($"Удаляем все вхождения {e}...");
                                    Console.Write("Результат = ");
                                    list.Print();

                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Нечего удалять.");

                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: необходимо ввести числовое значение.");

                                break;
                            }
                        }
                    case 9:
                        {
                            if (list.IsEmpty)
                            {
                                Console.WriteLine("Список пуст!");
                                break;
                            }

                            Console.Write("Введите значения F и E через пробел (например, '5 10'): ");
                            string? input = Console.ReadLine();

                            string[] parts = input!.Split(' ');

                            Console.WriteLine();

                            if (parts.Length == 2 && int.TryParse(parts[1], out int e) && int.TryParse(parts[0], out int f))
                            {
                                if (list.AddBefore(e, f))
                                {
                                    Console.WriteLine($"Вставляяем {f} перед первым вхождением {e}...");
                                    Console.Write("Результат = ");
                                    list.Print();

                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"Значение {e} не найдено в списке.");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: необходимо ввести два числовых значения, разделённых пробелом.");
                                break;
                            }
                        }
                    case 10:
                        {
                            Console.Write("Введите значения для E через пробел (например, '1 2 3 ...'): ");
                            string? input = Console.ReadLine();

                            string[] parts = input!.Split(' ');
                            CustomLinkedList<int> newList = [];
                            bool inputCorrect = true;

                            Console.WriteLine();

                            foreach (string part in parts)
                            {
                                if (int.TryParse(part, out int number))
                                {
                                    newList.Add(number);
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка: необходимо ввести числовые значения через пробел");
                                    inputCorrect = false;
                                    break;
                                }
                            }

                            if (!inputCorrect)
                            {
                                break;
                            }

                            Console.WriteLine($"Дописываем новый список к исходному...");
                            list.AddLinkedList(newList);

                            Console.Write("Результат = ");
                            list.Print();

                            break;
                        }
                    case 11:
                        {
                            if (list.IsEmpty)
                            {
                                Console.WriteLine("Список пуст!");
                                break;
                            }

                            Console.Write("Введите X: ");
                            string? input = Console.ReadLine();

                            Console.WriteLine();

                            if (int.TryParse(input, out int x))
                            {
                                CustomLinkedList<int> newList = [];

                                Console.WriteLine($"Разделяем список по {x}...");
                                Console.Write("Старый список = ");
                                list.Print();

                                newList = list.Split(x);
                                Console.Write("Новый список = ");
                                newList.Print();

                                list = newList;

                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: необходимо ввести числовое значение.");
                                break;
                            }
                        }
                    case 12:
                        if (list.IsEmpty)
                        {
                            Console.WriteLine("Список пуст!");
                            break;
                        }

                        Console.WriteLine("Удваиваем список...");
                        list.Duplicate();

                        Console.Write("Результат = ");
                        list.Print();

                        break;
                    case 13:
                        {
                            if (list.IsEmpty)
                            {
                                Console.WriteLine("Список пуст!");
                                break;
                            }

                            Console.Write("Введите значения два числа через пробел (например, '5 10'): ");
                            string? input = Console.ReadLine();

                            string[] parts = input!.Split(' ');

                            Console.WriteLine();

                            if (parts.Length == 2 && int.TryParse(parts[1], out int x) && int.TryParse(parts[0], out int y))
                            {
                                if (list.Swap(x, y))
                                {
                                    Console.WriteLine($"Меням местами {x} и {y}...");
                                    Console.Write("Результат = ");
                                    list.Print();

                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"Пара значений не найдена в списке.");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: необходимо ввести два числовых значения, разделённых пробелом.");
                                break;
                            }
                        }
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
                Console.ReadKey();
            }
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