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
    }
}