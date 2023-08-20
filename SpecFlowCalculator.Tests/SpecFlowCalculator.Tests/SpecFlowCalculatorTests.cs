using SpecFlowCalculator.Core;
using Xunit;

namespace SpecFlowCalculator.Tests
{
    public class AdderTests
    {
        [Fact]
        public void Add_GivenTwoIntegers_ReturnsTheirSum()
        {
            // Arrange
            var calculator = new Calculator();
            calculator.FirstNumber = 5;
            calculator.FirstNumber = 7;
            int expectedSum = 12;

            // Act
            int result = calculator.Add();

            // Assert
            Assert.Equal(expectedSum, result);
        }
    }
}
