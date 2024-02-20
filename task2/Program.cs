using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            FilterDelegate filter = IsMultipleOfK;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] result1 = ArrayFilter.FilterArrayInFirstWay(array, filter, k);
            int[] result2 = ArrayFilter.FilterArrayInSecondWay(array, filter, k);

            Console.Write("Array before filtering: ");
            ArrayFilter.PrintArray(array);
            Console.Write("Result of filtering array in the first way: ");
            ArrayFilter.PrintArray(result1);
            Console.Write("Result of filtering array in the second way: ");
            ArrayFilter.PrintArray(result2);

        }

        static bool IsMultipleOfK(int value, int k)
        {
            return value % k == 0;
        }
    }
}
