using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyFourTimesSixIsTwentyFour()
        {
            // Given
            double a = 6;
            double b = 4;
            double expected = 24;
            Calculator calculator = new Calculator();

            // When
            double actual = calculator.Multiply(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideTwntyThroughFourIsFive()
        {
            // Given
            double a = 20;
            double b = 4;
            double expected = 5;
            Calculator calculator = new Calculator();

            // When
            double actual = calculator.Divide(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideThroughZero()
        {
            // Given
            double a = 20;
            double b = 0;
            Calculator calculator = new Calculator();

            // Then
            Assert.Throws<ArgumentException>(() => calculator.Divide(a, b));
        }
    }
}
