using System;
using Xunit;

namespace Assignment03.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void PrintOutReverseHelloWorld()
        {
            string input = "Hello World";

            var expected = "dlroW olleH";
            
            Assert.Equal(expected, ReverseWord(input));
        }

        [Fact]
        public void PrintOutProductof4And6()
        {
            int input1 = 4;
            int input2 = 6;

            var expected = 24;
            
            Assert.Equal(expected, printProduct(input1, input2));
        }
    }

    
}
