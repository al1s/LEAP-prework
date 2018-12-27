using System;
using Xunit;

namespace ReverseString.Tests
{
    public class ReverseStringTests
    {
        /// <summary>
        /// Can returned reversed string using iterative approach
        /// </summary>
        /// <param name="str">String to reverse</param>
        [Theory]
        [InlineData("Hello world!")]
        [InlineData("A")]
        [InlineData("abcdefg")]
        public void GivenAString_IterativeFunction_ReturnsReversedString(string str)
        {
            // arrange
            char[] revStr = str.ToCharArray();
            Array.Reverse(revStr);
            string expectedReveresedString = new string(revStr);
            // act
            string result = App.Program.ReverseStringIterative(str);
            // assert
            Assert.Equal(expectedReveresedString, result);
        }
        /// <summary>
        /// Can returned reversed string using recursive approach
        /// </summary>
        /// <param name="str">String to reverse</param>
        [Theory]
        [InlineData("Hello world!")]
        [InlineData("A")]
        [InlineData("abcdefg")]
        public void GivenAString_RecursiveFunction_ReturnsReversedString(string str)
        {
            // arrange
            char[] revStr = str.ToCharArray();
            Array.Reverse(revStr);
            string expectedReveresedString = new string(revStr);
            // act
            string result = App.Program.ReverseStringRecursion(str);
            // assert
            Assert.Equal(expectedReveresedString, result);
        }
    }
}
