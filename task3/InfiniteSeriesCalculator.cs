using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    public delegate double CurrentSeriesTermDelegate(int n);
    class InfiniteSeriesCalculator
    {
        public static double CalculateSum(CurrentSeriesTermDelegate termDelegate, double precision)
        {
            double sum = 0.0;
            double termValue;
            int n = 0;

            do
            {
                termValue = termDelegate(n);
                sum += termValue;
                n++;
            } 
            while (Math.Abs(termValue) >= precision);

            return sum;
        }
    }
}
