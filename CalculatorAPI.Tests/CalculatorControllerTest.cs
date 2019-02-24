using CalculatorWebAPI.Controllers;
using CalculatorWebAPI.Models;
using CalculatorWebAPI.Services;
using Xunit;

namespace CalculatorAPI.Tests
{
    public class CalculatorControllerTest
    {
        CalculatorService _service;
        CalculatorController _controller;

        public CalculatorControllerTest()
        {
            _service = new CalculatorService();
            _controller = new CalculatorController(_service);
        }

        [Fact]
        public void TestSum()
        {
            // Arrange
            CalculatorItem testItem = new CalculatorItem()
            {
                A = 22,
                B = 10,
            };

            // Act
            var response = _controller.SumElements(testItem);

            // Assert
            Assert.Equal(32, response);
        }

        [Fact]
        public void TestSubstract()
        {
            // Arrange
            CalculatorItem testItem = new CalculatorItem()
            {
                A = 22,
                B = 10,
            };

            // Act
            var response = _controller.SubstractElements(testItem);

            // Assert
            Assert.Equal(12, response);
        }

        [Fact]
        public void TestMultiply()
        {
            // Arrange
            CalculatorItem testItem = new CalculatorItem()
            {
                A = 22,
                B = 10,
            };

            // Act
            var response = _controller.MultiplyElements(testItem);

            // Assert
            Assert.Equal(220, response);
        }

        [Fact]
        public void TestDivide()
        {
            // Arrange
            CalculatorItem testItem = new CalculatorItem()
            {
                A = 22,
                B = 10,
            };

            // Act
            var response = _controller.DivideElements(testItem);

            // Assert
            Assert.Equal(2.2f, response);
        }
    }
}
