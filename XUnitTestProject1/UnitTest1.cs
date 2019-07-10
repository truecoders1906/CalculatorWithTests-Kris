using System;
using Xunit;
using CalculatorWithTests;
using System.Linq;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(12, 2, 14)]
        [InlineData(0, 2, 2)]
        [InlineData(10000, 2, 10002)]
        [InlineData(5, 7, 12)]
        [InlineData(-1, 0, -1)]
        [InlineData(20, 20, 40)]
        [InlineData(50, 50, 100)]
        [InlineData(1, 1, 2)]
        public void Add(int addend1, int addend2, int sum)
        {
            // Arrange
            Calculator calculator1 = new Calculator();

            // Act
            int actual = calculator1.Add(addend1, addend2);

            // Assert
            Assert.Equal(sum, actual);




        }
    }
}
