using System;

namespace task4
{
    delegate double CalculationOperationDelegate(double x);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводьте рядки послідовно один за одним." +
                "\nПоки вони матимуть вигляд 0 x чи 1 x чи 2 x " +
                "\n(тобто, цифра від 0 до 2, а після неї запис конкретного дійсного числа)," +
                "\nпрограма обчислюватиме одну з трьох функцій:" +
                "\n\t0 -- sqrt(abs(x))" +
                "\n\t1 -- x^3 (інакше кажучи, x*x*x)" +
                "\n\t2 -- x + 3.5" +
                "\n(згідно цифри на початку) і виводитиме результат.\n" +
                "\nЯкщо вхідний рядок не задовольнятиме цей формат, програма завершить роботу.\n");

            CalculationOperationDelegate[] operations = {
                x => Math.Sqrt(Math.Abs(x)),
                x => Math.Pow(x, 3),
                x => x + 3.5
            };

            while (true)
            {
                try
                {
                    string[] input = Console.ReadLine().Trim().Split();

                    int operationToDo = int.Parse(input[0]);
                    double x = double.Parse(input[1]);

                    double result = operations[operationToDo](x);
                    Console.WriteLine("Результат: " + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Програма завершила роботу. Сталася помилка: " + ex.Message);
                    break;
                }
            }
        }
    }
}
