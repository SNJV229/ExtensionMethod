using System;
using Xunit;
using ConsoleApp2_ExtensionMethod;

namespace ExtensionMethodTest
{
    public class UnitTest1
    {
        [Fact]
        public void String_with_number()
        {
            string str = "456";

            string result = str.toCurrency();

            Assert.Equal("$456", result);

        }

        [Fact]
        public void String_with_no_number()
        {
            string str = "abcd";

            var exception = Assert.Throws<IOException>(() => Extension.toCurrency(str));

            Assert.Equal("String is not number.", exception.Message);

        }

        [Fact]
        public void String_with_some_number()
        {
            string str = "ab45cd";

            var exception = Assert.Throws<IOException> (() => Extension.toCurrency(str));

            Assert.Equal("String is not number.", exception.Message);

        }
    }
}