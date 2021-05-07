using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Auth.AccessControlPolicy;
using Amazon.Auth.AccessControlPolicy.ActionIdentifiers;
using Amazon;

namespace AWSSDK_DotNet35.UnitTests
{
    [TestClass]
    public class RegionEndpointTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataRow("us-east-1", "s3", "s3.amazonaws.com")]
        [DataRow("us-west-2", "s3", "s3.us-west-2.amazonaws.com")]
        [DataRow("aws-global", "s3", "s3.amazonaws.com")]
        [DataRow("us-east-1", "route53", "route53.amazonaws.com")]
        [DataRow("us-west-2", "route53", "route53.amazonaws.com")]
        [DataRow("aws-global", "route53", "route53.amazonaws.com")]
        [DataRow("fips-aws-global", "route53", "route53-fips.amazonaws.com")]
        [DataRow("us-east-1", "organizations", "organizations.us-east-1.amazonaws.com")]
        [DataRow("us-west-2", "organizations", "organizations.us-east-1.amazonaws.com")]
        [DataRow("aws-global", "organizations", "organizations.us-east-1.amazonaws.com")]
        [DataRow("fips-aws-global", "organizations", "organizations-fips.us-east-1.amazonaws.com")]
        public void ResolveRegionHostname(string region, string service, string expectedHostname)
        {
            var regionEndpoints = RegionEndpoint.GetBySystemName(region);
            var computedHostname = regionEndpoints.GetEndpointForService(service)?.Hostname;
            Assert.AreEqual(expectedHostname, computedHostname);
        }

    }
}
