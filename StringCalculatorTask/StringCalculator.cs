using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorTask
{
    public class StringCalculator
    {
        public int add(string numbers)
        {
            if(string.IsNullOrEmpty(numbers))
                return 0;
            var separator = new List<char>{',', '\n'};
            string stringNumber = numbers;
            if (stringNumber.StartsWith("//"))
            {
                var splitInput = stringNumber.Split('\n');
                var newSeparator = splitInput.First().Trim('/');
                stringNumber = String.Join('\n',splitInput.Skip(1));
                separator.Add(Convert.ToChar(newSeparator));
                
            }

            var ListOfNumbers = stringNumber.Split(separator.ToArray())
                .Select(m => Int32.Parse(m));
            
            var negativeNumber= ListOfNumbers.Where(number => number < 0);
            if (negativeNumber.Any())
            {
                
                string negativeString = string.Join(',', negativeNumber
                    .Select(number => number.ToString()));
                
                throw new Exception($"Negatives not allowed: {negativeString}");
            }
            
            var SumResult = ListOfNumbers.Sum();
            return SumResult;
        }
    }
}