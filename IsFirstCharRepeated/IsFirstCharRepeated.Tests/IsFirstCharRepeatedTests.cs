using System;
using Xunit;

namespace IsFirstCharRepeated.Tests
{
    public class IsFirstCharRepeatedTests
    {
        [Theory]
        [InlineData("abcdefg")]
        [InlineData("a")]
        [InlineData("hello world")]
        [InlineData("Hello world")]
        public void GivenAStringWithUniqueChars_ReturnsFalse(string str)
        {
            Assert.False(App.Program.IsFirstCharRepeated(str));
        }
        [Theory]
        [InlineData("abcdefga")]
        [InlineData("aa")]
        [InlineData("Another occurance of a in the sentence")]
        public void GivenAStringWithRepeatedFirstChar_ReturnsTrue(string str)
        {
            Assert.True(App.Program.IsFirstCharRepeated(str));
        }
    }
}
