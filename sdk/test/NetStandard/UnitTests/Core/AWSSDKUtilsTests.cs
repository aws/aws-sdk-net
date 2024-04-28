using System.Collections.Generic;
using Amazon.Util;
using System.Text;
using Amazon.Runtime.Internal;
using Xunit;

namespace UnitTests.NetStandard.Core
{
    [Trait("Category", "Core")]
    public class AWSSDKUtilsTests
    {
        [Fact]
        public void GetParametersAsString()
        {
            var parameters = new ParameterCollection
            {
                { "key1", "value1" },
                { "key2", "value2" },
                { "key3", new List<string> { "value3", "value4" } },
                { "key4", new List<double> { 1.1, 2.1 } }
            };

            var parametersString = AWSSDKUtils.GetParametersAsString(parameters);

            Assert.Equal("key1=value1&key2=value2&key3=value3&key3=value4&key4=1.1&key4=2.1", parametersString);
        }

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
