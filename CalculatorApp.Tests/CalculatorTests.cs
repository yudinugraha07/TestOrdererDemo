using System;
using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    [TestCaseOrderer("CalculatorApp.Tests.AlphabeticalOrderer", "CalculatorApp.Tests")]
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(-10, 1, -9)]
        public void D_Add_test_should_return_expected_result(int num1, int num2, int expected)
        {
            var calculator = new Calculator();
            int actual = calculator.Add(num1, num2);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(-10, 1, -11)]
        public void B_Minus_test_should_return_expected_result(int num1, int num2, int expected)
        {
            var calculator = new Calculator();
            int actual = calculator.Minus(num1, num2);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-10, 1, -10)]
        public void C_Multiply_test_should_return_expected_result(int num1, int num2, int expected)
        {
            var calculator = new Calculator();
            int actual = calculator.Multiply(num1, num2);
            Assert.Equal(expected, actual);
        }
    }
}
