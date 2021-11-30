using FluentAssertions;
using System;
using Xunit;

namespace Demo.Tests
{
    public class DemoTest
    {
        [Fact]
        public void TestFullnessArray()
        {
            // Arrange
            var demo = new Lib.Demo();

            // Act
            Func<int> result = () => demo.GetTwoMin(null);

            // Assert
            result.Should().Throw<ArgumentNullException>();

        }

        [Fact]
        public void TestArrayLenght()
        {
            // Arrange
            var demo = new Lib.Demo();

            // Act
            Func<int> result = () => demo.GetTwoMin(new[] { 1 });

            // Assert
            result.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void TestGetTwoWinResult()
        {
            // Arrange
            var demo = new Lib.Demo();

            // Act
            var result = demo.GetTwoMin(new[] { 4, 0, 3, 19, 492, -10, 1 });

            // Assert
            result.Should().Be(-10);
        }
    }
}
