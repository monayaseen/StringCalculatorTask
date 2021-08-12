using System;
using System.ComponentModel;
using Xunit;
namespace StringCalculatorTask.Test
{
    public class StringCalculatorTest
    {
        [Theory]
        [InlineData(null,0)]
        [InlineData("",0)]
        [InlineData("0",0)]
        [InlineData("1",1)]
        [InlineData("2",2)]
        [InlineData("1,2",3)]
        [InlineData("1,5",6)]
        [InlineData("10,9",19)]
        [InlineData("1,3,5",9)]
        [InlineData("1,9,3,5",18)]
        [InlineData("17,20,3,9",49)]
        [InlineData("1\n2",3)]
        [InlineData("1\n7",8)]
        public void StringNumbers_ReturnsIntSum(string numbers,int expectedSum)
        {
            var calculator = new StringCalculator();
            var result = calculator.add(numbers);
            Assert.Equal(expectedSum,result);
        }
        
        [Theory]
        [InlineData("//;\n2;1",3)]
        [InlineData("//;\n2;1;3;4",10)]
        [InlineData("//;\n2;1;0",3)]
        public void StringNumbersWithDifferentDelimiters_ReturnsIntSum(string numbers,int expectedSum)
        {
            var calculator = new StringCalculator();
            var result = calculator.add(numbers);
            Assert.Equal(expectedSum,result);
        }

    }
}