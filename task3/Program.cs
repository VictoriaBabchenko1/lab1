using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum1 = InfiniteSeriesCalculator.CalculateSum(n => 1.0 / Math.Pow(2, n), 0.0001);
            Console.WriteLine("Sum of series 1 + 1/2 + 1/4 + 1/8 + 1/16 + ... is equal to " + sum1);

            double sum2 = InfiniteSeriesCalculator.CalculateSum(n => 1.0 / Factorial(n + 1), 0.0001);
            Console.WriteLine("Sum of series 1 + 1/2! + 1/3! + 1/4! + 1/5! + ... is equal to " + sum2);

            double sum3 = InfiniteSeriesCalculator.CalculateSum(n => Math.Pow(-1, n) / Math.Pow(2, n), 0.0001);
            Console.WriteLine("Sum of series –1 + 1/2 – 1/4 + 1/8 – 1/16 + ... is equal to " + sum3);
        }

        static double Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
