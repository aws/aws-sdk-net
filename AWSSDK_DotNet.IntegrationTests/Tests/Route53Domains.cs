using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.Route53Domains;
using Amazon.Route53Domains.Model;
using System.Threading;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class Route53Domains : TestBase<AmazonRoute53DomainsClient>
    {
        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("Route53Domains")]
        public void CheckDomainAvailabilityTest()
        {
            var checkRequest = new CheckDomainAvailabilityRequest
            {
                DomainName = "mydomain1111111111111.com"
            };
            var response = Client.CheckDomainAvailability(checkRequest);
            Assert.AreEqual(DomainAvailability.AVAILABLE, response.Availability);

            var domains = Client.ListDomains().Domains;
            if (domains.Count > 0)
            {
                checkRequest.DomainName = domains[0].DomainName;
                response = Client.CheckDomainAvailability(checkRequest);
                Assert.AreEqual(DomainAvailability.UNAVAILABLE, response.Availability);
            }
        }
    }
}
