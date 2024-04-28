using Amazon.Util;
using System.Text;
using Xunit;

namespace UnitTests.NetStandard.Core
{
    [Trait("Category", "Core")]
    public class AWSSDKUtilsTests
    {
        [Fact]
        public void ToHexUppercase()
        {
            var bytes = Encoding.UTF8.GetBytes("Hello World");
            var hexString = AWSSDKUtils.ToHex(bytes, false);

            Assert.Equal("48656C6C6F20576F726C64", hexString);
        }

        [Fact]
        public void ToHexLowercase()
        {
            var bytes = Encoding.UTF8.GetBytes("Hello World");
            var hexString = AWSSDKUtils.ToHex(bytes, true);

            Assert.Equal("48656c6c6f20576f726c64", hexString);
        }

        [Fact]
        public void CompressSpaces()
        {
            var data = "Hello,   World!";
            var compressed = AWSSDKUtils.CompressSpaces(data);
            Assert.Equal("Hello, World!", compressed);
        }

        [Theory]
        [InlineData("value, with special chars!", "value%2C%20with%20special%20chars%21")]
        [InlineData("value, with special chars and path {/+:}", "value%2C%20with%20special%20chars%20and%20path%20%7B%2F%2B%3A%7D")]
        public void UrlEncodeWithoutPath(string input, string expected)
        {
            var encoded = AWSSDKUtils.UrlEncode(input, path: false);

            Assert.Equal(expected, encoded);
        }

        [Theory]
        [InlineData("value, with special chars!", "value%2C%20with%20special%20chars!")]
        [InlineData("value, with special chars and path {/+:}", "value%2C%20with%20special%20chars%20and%20path%20%7B/%2B:%7D")]
        public void UrlEncodeWithPath(string input, string expected)
        {
            var encoded = AWSSDKUtils.UrlEncode(input, path: true);

            Assert.Equal(expected, encoded);
        }
    }
}
