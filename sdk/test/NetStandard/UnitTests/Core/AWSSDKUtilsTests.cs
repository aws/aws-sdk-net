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
        [InlineData("紙_一般_児童手当等の受給資格及び児童手当の額についての認定請求公金非対応", "%E7%B4%99_%E4%B8%80%E8%88%AC_%E5%85%90%E7%AB%A5%E6%89%8B%E5%BD%93%E7%AD%89%E3%81%AE%E5%8F%97%E7%B5%A6%E8%B3%87%E6%A0%BC%E5%8F%8A%E3%81%B3%E5%85%90%E7%AB%A5%E6%89%8B%E5%BD%93%E3%81%AE%E9%A1%8D%E3%81%AB%E3%81%A4%E3%81%84%E3%81%A6%E3%81%AE%E8%AA%8D%E5%AE%9A%E8%AB%8B%E6%B1%82%E5%85%AC%E9%87%91%E9%9D%9E%E5%AF%BE%E5%BF%9C")]

        public void UrlEncodeWithoutPath(string input, string expected)
        {
            var encoded = AWSSDKUtils.UrlEncode(input, path: false);

            Assert.Equal(expected, encoded);
        }

        [Theory]
        [InlineData("\ud83d\ude02 value, with special chars!", "%F0%9F%98%82%20value,%20with%20special%20chars!")]
        [InlineData("value, with special chars!", "value,%20with%20special%20chars!")]
        [InlineData("value, with special chars and path {/+:}", "value,%20with%20special%20chars%20and%20path%20%7B/+%3A%7D")]
        [InlineData("紙_一般_児童手当等の受給資格及び児童手当の額についての認定請求公金非対応", "%E7%B4%99_%E4%B8%80%E8%88%AC_%E5%85%90%E7%AB%A5%E6%89%8B%E5%BD%93%E7%AD%89%E3%81%AE%E5%8F%97%E7%B5%A6%E8%B3%87%E6%A0%BC%E5%8F%8A%E3%81%B3%E5%85%90%E7%AB%A5%E6%89%8B%E5%BD%93%E3%81%AE%E9%A1%8D%E3%81%AB%E3%81%A4%E3%81%84%E3%81%A6%E3%81%AE%E8%AA%8D%E5%AE%9A%E8%AB%8B%E6%B1%82%E5%85%AC%E9%87%91%E9%9D%9E%E5%AF%BE%E5%BF%9C")]
        public void UrlEncodeWithPath(string input, string expected)
        {
            var encoded = AWSSDKUtils.UrlEncode(input, path: true);

            Assert.Equal(expected, encoded);
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("no-delimiters-at-all", "")]
        [InlineData("delimiter-end-of-string.", "")]
        [InlineData("relative-path/no-file-extension", "")]
        [InlineData("relative-path\\no-file-extension", "")]
        [InlineData("relative-path:no-file-extension", "")]
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
