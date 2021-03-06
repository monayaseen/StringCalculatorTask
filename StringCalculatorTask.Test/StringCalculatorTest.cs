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
        public void StringNumbers_ReturnsIntSum(string numbers,int expectedSum)
        {
            var calculator = new StringCalculator();
            var result = calculator.add(numbers);
            Assert.Equal(expectedSum,result);
        }
    }
}