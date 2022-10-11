using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        double average, max, min;
        public Stats CalculateStatistics(List<double> numbers) {
            if(numbers.Count == 0)
            {
                average = NaN;
                max = NaN;
                min = NaN;
                return;
            }
            
            //average of numbers
            average = numbers.Average();
            
            //min of numbers
            min = numbers.Min();
            
            //max of numbers
            max = numbers.Max();
        }
    }
}
