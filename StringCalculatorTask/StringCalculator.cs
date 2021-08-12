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
            var separator = new[] {',', '\n'};
            var SumResult = numbers.Split(separator)
                .Select(m => Int32.Parse(m)).Sum();
            return SumResult;
        }
    }
}