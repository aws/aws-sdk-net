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
        [InlineData("https://s3.amazonaws.com", "s3")]
        [InlineData("sqs.us-west-2.amazonaws.com", "sqs")]
        [InlineData("queue.amazonaws.com", "sqs")]
        [InlineData("https://sns.us-west-2.amazonaws.com", "sns")]
        [InlineData("https://s3-external-1.amazonaws.com", "s3")]
        public void DetermineService(string url, string expectedService)
        {
            var service = AWSSDKUtils.DetermineService(url);

            Assert.Equal(expectedService, service);
        }
    }
}
