using System;
using Xunit;

namespace CSharpCalculator.Tests
{
    public class CalculatorAdditionTests
    {
        [Fact]
        public void TestAddition()
        {
            double num1 = 5;
            double num2 = 3;
            double expected = 8;

            double result = Program.Add(num1, num2); 
            Assert.Equal(expected, result);

        }
    }
}
