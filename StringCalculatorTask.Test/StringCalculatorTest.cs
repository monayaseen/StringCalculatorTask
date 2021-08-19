using System;
using System.ComponentModel;
using Xunit;
namespace StringCalculatorTask.Test
{
    public class StringCalculatorTest
    {
        private StringCalculator calculator = new StringCalculator();
        
        [Theory]
        [InlineData(null, 0)]
        [InlineData("", 0)]
        public void EmptyOrNullString_ReturnsZero(string numbers,int expected)
        {
            var result = calculator.add(numbers);
            Assert.Equal(expected,result);
        }
        
        [Theory]
        [InlineData("0",0)]
        [InlineData("1",1)]
        [InlineData("2",2)]
        public void StringWithNumbers_ReturnsNumber(string numbers,int expectedSum)
        {
            var result = calculator.add(numbers);
            Assert.Equal(expectedSum,result);
        }
        [Theory]
        [InlineData("1,2",3)]
        [InlineData("1,5",6)]
        [InlineData("10,9",19)]
        public void StringWithTwoNumbers_ReturnsSumOFNumbers(string numbers,int expectedSum)
        {
            var result = calculator.add(numbers);
            Assert.Equal(expectedSum,result);
        }
        
        [Theory]
        [InlineData("1,3,5",9)]
        [InlineData("1,9,3,5",18)]
        [InlineData("17,20,3,9",49)]
        public void StringWithLargeAmountOfNumbers_ReturnsSumOFNumbers(string numbers,int expectedSum)
        {
            var result = calculator.add(numbers);
            Assert.Equal(expectedSum,result);
        }
        [Theory]
        [InlineData("1\n2",3)]
        [InlineData("1\n7",8)]
        public void StringNumbersWithCommasORNewLineSeparation_ReturnsSumOFNumbers(string numbers,int expectedSum)
        {
            var result = calculator.add(numbers);
            Assert.Equal(expectedSum,result);
        }
        
        [Theory]
        [InlineData("//;\n2;1",3)]
        [InlineData("//;\n2;1;3;4",10)]
        [InlineData("//;\n2;1;0",3)]
        public void StringNumbersWithDifferentDelimiters_ReturnsSumOFNumbers(string numbers,int expectedSum)
        {
            var result = calculator.add(numbers);
            Assert.Equal(expectedSum,result);
        }
        
        [Theory]
        [InlineData("1,4,-1","Negatives not allowed: -1")]
        [InlineData("1,-4,-1","Negatives not allowed: -4,-1")]
        [InlineData("-51,-4,-1","Negatives not allowed: -51,-4,-1")]
        public void StringNumbersWithNegativeNumbers_ThrowsException(string numbers,string expectedMsg)
        {
            Action action=() =>calculator.add(numbers);
            var exception = Assert.Throws<Exception>(action);
            Assert.Equal(expectedMsg,exception.Message);
        }
        
        [Theory] 
        [InlineData("2,1001",2)]
        [InlineData("10000,9",9)]
        [InlineData("10,10000,9",19)]
        [InlineData("15,7,1998",22)]
        public void StringNumbersWithBigNumbers_IgnoreBigNumbers(string numbers,int expectedSum)
        {
            var result = calculator.add(numbers);
            Assert.Equal(expectedSum,result);
        }
    }
}