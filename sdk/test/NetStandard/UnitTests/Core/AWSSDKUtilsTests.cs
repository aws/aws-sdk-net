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
    }
}
