using Amazon.Runtime;
using Amazon.Util;
using Xunit;

namespace UnitTests.NetStandard.Core
{
    public class CryptoUtilTests
    {
        [Fact]
        [Trait("Category", "Core")]
        public void HMACSignFromString()
        {
            var actual = CryptoUtilFactory.CryptoInstance.HMACSign("HELLOWORLD", "HELLOKEY", SigningAlgorithm.HmacSHA256);

            Assert.Equal("LH+6qR+N6WU91evFKfjq/6NqiVES5BD6z6EHYsDwOUE=", actual);
        }
    }
}
