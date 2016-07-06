using System.Linq;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class AWSPublicIpAddressRangesTests
    {
        [TestMethod]
        [TestCategory("General")]
        public void TestLoadAndParse()
        {
            var ranges = AWSPublicIpAddressRanges.Load();

            Assert.IsNotNull(ranges);
            Assert.IsTrue(ranges.AllAddressRanges.Any());
        }

        [TestMethod]
        [TestCategory("General")]
        public void TestQueryByServiceKey()
        {
            var ranges = AWSPublicIpAddressRanges.Load();

            var ec2Ranges = ranges.AddressRangesByServiceKey(AWSPublicIpAddressRanges.EC2ServiceKey);
            Assert.IsTrue(ec2Ranges.Any());
        }

        [TestMethod]
        [TestCategory("General")]
        public void TestQueryByRegion()
        {
            var ranges = AWSPublicIpAddressRanges.Load();

            var uswest1Ranges = ranges.AddressRangesByRegion("us-west-1");
            Assert.IsTrue(uswest1Ranges.Any());

            var globalRanges = ranges.AddressRangesByRegion(AWSPublicIpAddressRanges.GlobalRegionIdentifier);
            Assert.IsTrue(globalRanges.Any());
        }
    }
}
