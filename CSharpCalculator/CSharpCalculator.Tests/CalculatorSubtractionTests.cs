using System;
using Xunit;

namespace CSharpCalculator.Tests
{
    public class CalculatorSubtractionTests
    {
        [Fact]
        public void TestSubtraction(double num1, double num2, double expected)
        {
            double result = Program.Subtract(num1, num2); 
             Assert.Equal(expected, result);

        }
    }
}
