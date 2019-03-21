using System.Linq;
using Amazon.Util;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class AWSPublicIpAddressRangesTests
    {
        [Fact]
        public void TestLoadAndParse()
        {
            var ranges = AWSPublicIpAddressRanges.Load();

            Assert.NotNull(ranges);
            Assert.True(ranges.AllAddressRanges.Any());
        }

        [Fact]
        public void TestQueryByServiceKey()
        {
            var ranges = AWSPublicIpAddressRanges.Load();

            var ec2Ranges = ranges.AddressRangesByServiceKey(AWSPublicIpAddressRanges.EC2ServiceKey);
            Assert.True(ec2Ranges.Any());
        }

        [Fact]
        public void TestQueryByRegion()
        {
            var ranges = AWSPublicIpAddressRanges.Load();

            var uswest1Ranges = ranges.AddressRangesByRegion("us-west-1");
            Assert.True(uswest1Ranges.Any());

            var globalRanges = ranges.AddressRangesByRegion(AWSPublicIpAddressRanges.GlobalRegionIdentifier);
            Assert.True(globalRanges.Any());
        }
    }
}
