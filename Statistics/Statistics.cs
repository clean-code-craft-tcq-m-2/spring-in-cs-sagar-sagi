using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    //User defined return type
    public class Stats
    {
        public double average, max, min;
    }
    
    public class StatsComputer
    {
        public double average, max, min;
        public Stats CalculateStatistics(List<double> numbers) 
        {
            Stats stats = new Stats();
            if(numbers.Count == 0)
            {
                average = double.NaN;
                max = double.NaN;
                min = double.NaN;
                
                stats.average = average;
                stats.max = max;
                stats.min = min;
                return stats;
            }
            
            //average of numbers
            average = numbers.Average();
            
            //min of numbers
            min = numbers.Min();
            
            //max of numbers
            max = numbers.Max();
            
            
            stats.average = average;
            stats.max = max;
            stats.min = min;
            return stats;
        }
    }
}
