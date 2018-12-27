using System;
using Xunit;

namespace XToTheYPower.Tests
{
    public class XToTheYPowertTests
    {
        /// <summary>
        /// Can return power of a number
        /// </summary>
        /// <param name="baseNum">A number</param>
        /// <param name="power">A power</param>
        [Theory]
        [InlineData(2, 2)]
        [InlineData(2, 5)]
        [InlineData(2, 8)]
        [InlineData(2, 0)]
        [InlineData(0, 8)]
        public void IterativeFunction_GivenNumberAndPower_ReturnsPowerOfNumber(int baseNum, int power)
        {
            // arrange
            int expectedValue = (int) Math.Pow(baseNum, power);
            // act
            int result = App.Program.XToTheYPowerIter(baseNum, power);
            // assert
            Assert.Equal(expectedValue, result);
        }
        /// <summary>
        /// Can return power of a number
        /// </summary>
        /// <param name="baseNum">A number</param>
        /// <param name="power">A power</param>
        [Theory]
        [InlineData(2, 2)]
        [InlineData(2, 5)]
        [InlineData(2, 8)]
        [InlineData(2, 0)]
        [InlineData(0, 8)]
        public void RecursiveFunction_GivenNumberAndPower_ReturnsPowerOfNumber(int baseNum, int power)
        {
            // arrange
            int expectedValue = (int) Math.Pow(baseNum, power);
            // act
            int result = App.Program.XToTheYPowerRecur(baseNum, power);
            // assert
            Assert.Equal(expectedValue, result);
        }
    }
}
