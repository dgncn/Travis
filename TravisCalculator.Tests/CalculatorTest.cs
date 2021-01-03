using System;
using Xunit;

namespace TravisCalculator.Tests
{
    public class CalculatorTest
    {
        public Calculator _calculator;
        public CalculatorTest()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Negative_Four_Is_Negative()
        {
            bool serviceResult = _calculator.IsNegativeNumber(-4);
            Assert.True(serviceResult);
        }
    }
}
