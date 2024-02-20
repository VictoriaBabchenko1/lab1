using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace task6
{
    class SortingTester
    {
        public static bool CheckSortingAndTime(Action<int[]> etalonSort, Action<int[]> studentSort, int[] arr, out long etalonTime, out long studentTime)
        {
            int[] arrCopy = new int[arr.Length];
            Array.Copy(arr, arrCopy, arr.Length);

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            etalonSort(arr);
            stopwatch.Stop();
            etalonTime = stopwatch.ElapsedMilliseconds;

            stopwatch.Restart();
            try
            {
                studentSort(arrCopy);
            }
            catch (Exception)
            {
                studentTime = -1;
                return false;
            }
            stopwatch.Stop();
            studentTime = stopwatch.ElapsedMilliseconds;

            return CompareArrays(arr, arrCopy) && IsTimeAcceptable(etalonTime, studentTime);
        }

        private static bool IsTimeAcceptable(long etalonTime, long studentTime)
        {
            const int margin = 200;
            return Math.Max(0, etalonTime / 5 - margin) <= studentTime && studentTime <= 5 * etalonTime + margin;
        }

        private static bool CompareArrays(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
