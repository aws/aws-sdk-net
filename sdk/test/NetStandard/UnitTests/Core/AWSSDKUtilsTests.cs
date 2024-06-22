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
        [InlineData(null, null)]
        [InlineData("no-delimiters-at-all", "")]
        [InlineData("delimiter-end-of-string.", "")]
        [InlineData("relative-path/no-file-extension", "")]
        [InlineData("simple-file.pdf", ".pdf")]
        [InlineData("relative-path/with-file-extension.pdf", ".pdf")]
        [InlineData("relative-path.with-dot/with-file-extension.pdf", ".pdf")]
        public void GetExtension(string input, string expected)
        {
            var actual = AWSSDKUtils.GetExtension(input);

            Assert.Equal(expected, actual);
        }
    }
}
