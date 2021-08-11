using System;
using System.ComponentModel;
using Xunit;
namespace StringCalculatorTask.Test
{
    public class StringCalculatorTest
    {
        [Fact]
        public void EmptyString_ReturnsZero()
        {
            var calculator = new StringCalculator();
            var result = calculator.add("");
            Assert.Equal(0,result);
        }
        [Theory]
        [InlineData("1",1)]
        [InlineData("2",2)]
        public void AString_Returns_IntValue(string numbers,int expectdSum)
        {
            var calculator = new StringCalculator();
            var result = calculator.add(numbers);
            Assert.Equal(expectdSum,result);
        }
    }
}