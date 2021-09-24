using System;
using Xunit;

namespace Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void IsSecure_GivenHttpsScheme_ReturnsTrue()
        {
            var input = new Uri("https://www.Google.com");

            Assert.True(input.IsSecure());
        }

        [Fact]
        public void WordCount_GivenHelloWorld_returnTwo()
        {
            var input = "Hello World";

            var expected = 2;
            Assert.Equal(expected, input.WordCount());

        }
    }
}