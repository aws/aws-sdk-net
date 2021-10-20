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
        [DataRow("us-east-1", "s3", "s3.amazonaws.com", null)]
        [DataRow("us-west-2", "s3", "s3.us-west-2.amazonaws.com", null)]
        [DataRow("aws-global", "s3", "s3.amazonaws.com", "us-east-1")]
        [DataRow("us-east-1", "route53", "route53.amazonaws.com", "us-east-1")]
        [DataRow("us-west-2", "route53", "route53.amazonaws.com", "us-east-1")]
        [DataRow("aws-global", "route53", "route53.amazonaws.com", "us-east-1")]
        [DataRow("fips-aws-global", "route53", "route53-fips.amazonaws.com", "us-east-1")]
        [DataRow("us-east-1", "organizations", "organizations.us-east-1.amazonaws.com", "us-east-1")]
        [DataRow("us-west-2", "organizations", "organizations.us-east-1.amazonaws.com", "us-east-1")]
        [DataRow("aws-global", "organizations", "organizations.us-east-1.amazonaws.com", "us-east-1")]
        [DataRow("fips-aws-global", "organizations", "organizations-fips.us-east-1.amazonaws.com", "us-east-1")]
        [DataRow("aws-us-gov-global", "organizations", "organizations.us-gov-west-1.amazonaws.com", "us-gov-west-1")]
        [DataRow("fips-us-east-1", "api.ecr", "ecr-fips.us-east-1.amazonaws.com", "us-east-1")]
        [DataRow("fips-us-gov-east-1", "api.ecr", "ecr-fips.us-gov-east-1.amazonaws.com", "us-gov-east-1")]
        [DataRow("fips-dkr-us-east-1", "api.ecr", "ecr-fips.us-east-1.amazonaws.com", "us-east-1")]
        [DataRow("us-east-1-fips", "s3-control", "s3-control-fips.us-east-1.amazonaws.com", "us-east-1")]
        public void ResolveRegion(string region, string service, string expectedHostname, string expectedAuthRegion)
        {
            var regionEndpoint = RegionEndpoint.GetBySystemName(region);
            var endpoint = regionEndpoint.GetEndpointForService(service);

            Assert.IsNotNull(endpoint);
            Assert.AreEqual(expectedHostname, endpoint.Hostname);
            Assert.AreEqual(expectedAuthRegion, endpoint.AuthRegion);
        }
    }
}
