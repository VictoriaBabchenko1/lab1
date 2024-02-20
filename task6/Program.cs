using System;
using System.IO;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("random_10000.txt");
            int[] testArray = Array.ConvertAll(lines, int.Parse);

            long etalonTime, studentTime;

            bool selectionSortResult = SortingTester.CheckSortingAndTime(EtalonSorting.SelectionSort, StudentSorting.SelectionSort,
                testArray, out etalonTime, out studentTime);

            String selectionSortResultStr = selectionSortResult ? "OK" : "FAILD";
            Console.WriteLine($"Selection Sort Result: {selectionSortResultStr}" +
                $"\nEtalon Time: {etalonTime} ms" +
                $"\nStudent Time: {studentTime} ms");


            bool shakerSortResult = SortingTester.CheckSortingAndTime(EtalonSorting.ShakerSort, StudentSorting.ShakerSort,
                testArray, out etalonTime, out studentTime);

            String shakerSortResultStr = shakerSortResult ? "OK" : "FAILD";
            Console.WriteLine($"\nShaker Sort Result: {shakerSortResultStr}" +
                $"\nEtalon Time: {etalonTime} ms" +
                $"\nStudent Time: {studentTime} ms");
        }
    }
}
