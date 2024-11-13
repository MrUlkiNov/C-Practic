using CalculatorApp;
using Xunit;

namespace CalculatorApp.Tests
{
    public class CalculatorLogicTests
    {
        [Fact]
        public void TestAddition()
        {
            var calculator = new CalculatorLogic
            {
                FirstNumber = 5,
                SecondNumber = 3,
                Operation = "+"
            };

            double result = calculator.Calculate();
            Assert.Equal(8, result);
        }

        [Fact]
        public void TestSubtraction()
        {
            var calculator = new CalculatorLogic
            {
                FirstNumber = 10,
                SecondNumber = 4,
                Operation = "-"
            };

            double result = calculator.Calculate();
            Assert.Equal(6, result);
        }

        [Fact]
        public void TestMultiplication()
        {
            var calculator = new CalculatorLogic
            {
                FirstNumber = 6,
                SecondNumber = 7,
                Operation = "*"
            };

            double result = calculator.Calculate();
            Assert.Equal(42, result);
        }

        [Fact]
        public void TestDivision()
        {
            var calculator = new CalculatorLogic
            {
                FirstNumber = 20,
                SecondNumber = 4,
                Operation = "/"
            };

            double result = calculator.Calculate();
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestDivisionByZero()
        {
            var calculator = new CalculatorLogic
            {
                FirstNumber = 20,
                SecondNumber = 0,
                Operation = "/"
            };

            Assert.Throws<DivideByZeroException>(() => calculator.Calculate());
        }
    }
}
