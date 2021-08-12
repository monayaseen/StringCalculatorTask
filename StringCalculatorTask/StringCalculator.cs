using System;
using System.Linq;

namespace StringCalculatorTask
{
    public class StringCalculator
    { 
        public int add(string numbers)
        {
            if(string.IsNullOrEmpty(numbers))
            return 0;
            var SumResult = numbers.Split(",")
                .Select(m => Int32.Parse(m)).Sum();
            return SumResult;
        }
    }
}