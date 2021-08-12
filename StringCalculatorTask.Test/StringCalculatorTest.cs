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
        
        public void StringNumbers_ReturnsIntSum(string numbers,int expectedSum)
        {
            var calculator = new StringCalculator();
            var result = calculator.add(numbers);
            Assert.Equal(expectedSum,result);
        }
        
        [Theory]
        [InlineData("10,9",19)]
        [InlineData("1,3,5",9)]
        [InlineData("1,9,3,5",18)]
        [InlineData("17,20,3,9",49)]
        public void MoreThanTwoStringNumbers_ReturnsIntSum(string numbers,int expectedSum)
        {
            var calculator = new StringCalculator();
            var result = calculator.add(numbers);
            Assert.Equal(expectedSum,result);
        }
        
        
    }
}