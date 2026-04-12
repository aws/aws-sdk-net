using System.Linq;
using System.Threading.Tasks;
using Amazon.Util;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    public class AWSPublicIpAddressRangesFixture : IAsyncLifetime
    {
        public AWSPublicIpAddressRanges AddressRanges { get; private set; }

        public ValueTask InitializeAsync()
        {
            AddressRanges = AWSPublicIpAddressRanges.Load();
            return default;
        }

        public ValueTask DisposeAsync() => default;
    }

    [Trait("Category", "General")]
    public class AWSPublicIpAddressRangesTests : IClassFixture<AWSPublicIpAddressRangesFixture>
    {
        private readonly AWSPublicIpAddressRanges _addressRanges;

        public AWSPublicIpAddressRangesTests(AWSPublicIpAddressRangesFixture fixture)
        {
            _addressRanges = fixture.AddressRanges;
        }

        [Fact]
        public void TestLoadAndParse()
        {
            Assert.NotNull(_addressRanges);
            Assert.True(_addressRanges.AllAddressRanges.Any());
        }

        [Fact]
        public void TestQueryByServiceKey()
        {
            var ec2Ranges = _addressRanges.AddressRangesByServiceKey(AWSPublicIpAddressRanges.EC2ServiceKey);
            Assert.True(ec2Ranges.Any());
        }

        [Fact]
        public void TestQueryByRegion()
        {
            var uswest1Ranges = _addressRanges.AddressRangesByRegion("us-west-1");
            Assert.True(uswest1Ranges.Any());

            var globalRanges = _addressRanges.AddressRangesByRegion(AWSPublicIpAddressRanges.GlobalRegionIdentifier);
            Assert.True(globalRanges.Any());
        }

        [Fact]
        public void TestQueryByNetworkBorderGroup()
        {
            var useast1Ranges = _addressRanges.AddressRangesByNetworkBorderGroup("us-east-1");
            Assert.True(useast1Ranges.Any());
        }
    }
}