using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    //User defined return type
    public class Stats
    {
        double average, max, min;
    }
    
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
            
            Stats stats = new Stats();
            stats.average = average;
            stats.max = max;
            stats.min = min;
            return stats;
        }
    }
}
