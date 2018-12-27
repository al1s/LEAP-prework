using System;
using Xunit;

namespace GetSumBetweenNumbers.Tests
{
    public class GetSumBetweenNumbersTests
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(1, 10)]
        [InlineData(10, 100)]
        [InlineData(10, 10)]
        public void IterativeFinction_GivenARange_ReturnsRangeSum(int min, int max)
        {
            // arrange
            int expectedResult = (min + max) * (max - min + 1) / 2;
            // act
            int result = App.Program.GetSumBetweenNumbersIter(min, max);
            // assert
            Assert.Equal(expectedResult, result);
        }
        [Theory]
        [InlineData(10, 1)]
        [InlineData(2, 1)]
        public void IterativeFinction_GivenARangeMinValGreaterMaxVal_ReturnsZero(int min, int max)
        {
            // arrange
            int expectedResult = 0;
            // act
            int result = App.Program.GetSumBetweenNumbersIter(min, max);
            // assert
            Assert.Equal(expectedResult, result);
        }
        [Theory]
        [InlineData(1, 2)]
        [InlineData(1, 10)]
        [InlineData(10, 10)]
        [InlineData(10, 100)]
        public void RecursiveFinction_GivenARange_ReturnsRangeSum(int min, int max)
        {
            // arrange
            int expectedResult = (min + max) * (max - min + 1) / 2;
            // act
            int result = App.Program.GetSumBetweenNumbersRecur(min, max);
            // assert
            Assert.Equal(expectedResult, result);
        }
        [Theory]
        [InlineData(10, 1)]
        [InlineData(2, 1)]
        public void RecursiveFinction_GivenARangeMinValGreaterMaxVal_ReturnsZero(int min, int max)
        {
            // arrange
            int expectedResult = 0;
            // act
            int result = App.Program.GetSumBetweenNumbersRecur(min, max);
            // assert
            Assert.Equal(expectedResult, result);
        }
    }
}
