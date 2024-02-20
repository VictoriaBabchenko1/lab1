using System;
using System.Collections.Generic;
using System.Linq;

namespace task2
{
    public delegate bool FilterDelegate(int value, int k);

    class ArrayFilter
    {
        public static int[] FilterArrayInFirstWay(int[] numbers, FilterDelegate filter, int k)
        {
            IEnumerable<int> query = numbers.Where((num) => filter(num, k));
            return query.ToArray();
        }

        public static int[] FilterArrayInSecondWay(int[] numbers, FilterDelegate filter, int k)
        {
            int count = 0;
            foreach (int num in numbers)
            {
                if (filter(num, k))
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;
            foreach (int num in numbers)
            {
                if (filter(num, k))
                {
                    result[index++] = num;
                }
            }

            return result;
        }

        public static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
