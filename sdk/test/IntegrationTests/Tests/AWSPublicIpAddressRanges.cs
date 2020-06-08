using System.Linq;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class AWSPublicIpAddressRangesTests
    {
        private AWSPublicIpAddressRanges _addressRanges;

        [TestInitialize]
        public void Init()
        {
            _addressRanges = AWSPublicIpAddressRanges.Load();
        }

        [TestMethod]
        [TestCategory("General")]
        public void TestLoadAndParse()
        {
            Assert.IsNotNull(_addressRanges);
            Assert.IsTrue(_addressRanges.AllAddressRanges.Any());
        }

        [TestMethod]
        [TestCategory("General")]
        public void TestQueryByServiceKey()
        {
            var ec2Ranges = _addressRanges.AddressRangesByServiceKey(AWSPublicIpAddressRanges.EC2ServiceKey);
            Assert.IsTrue(ec2Ranges.Any());
        }

        [TestMethod]
        [TestCategory("General")]
        public void TestQueryByRegion()
        {
            var uswest1Ranges = _addressRanges.AddressRangesByRegion("us-west-1");
            Assert.IsTrue(uswest1Ranges.Any());

            var globalRanges = _addressRanges.AddressRangesByRegion(AWSPublicIpAddressRanges.GlobalRegionIdentifier);
            Assert.IsTrue(globalRanges.Any());
        }

        [TestMethod]
        [TestCategory("General")]
        public void TestQueryByNetworkBorderGroup()
        {
            var useast1Ranges = _addressRanges.AddressRangesByNetworkBorderGroup("us-east-1");
            Assert.IsTrue(useast1Ranges.Any());
        }
    }
}