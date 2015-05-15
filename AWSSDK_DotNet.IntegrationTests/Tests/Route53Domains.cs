using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Route53Domains;
using Amazon.Route53Domains.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;

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

            checkRequest = new CheckDomainAvailabilityRequest
            {
                DomainName = "mydomain1111111111111.fake"
            };
            AssertExtensions.ExpectException<UnsupportedTLDException>(() => Client.CheckDomainAvailability(checkRequest));

            var domains = Client.ListDomains().Domains;
            if (domains.Count > 0)
            {
                checkRequest.DomainName = domains[0].DomainName;
                response = Client.CheckDomainAvailability(checkRequest);
                Assert.AreEqual(DomainAvailability.UNAVAILABLE, response.Availability);
            }
        }

        [TestMethod]
        [TestCategory("Route53Domains")]
        public void TestTagging()
        {
            var domains = Client.ListDomains().Domains;
            if (domains.Count > 0)
            {
                TestTagging(Client, domains[0].DomainName);
            }
        }

        private void TestTagging(AmazonRoute53DomainsClient client, string domain)
        {
            var existingTags = client.ListTagsForDomain(domain).TagList;

            client.UpdateTagsForDomain(domain,
            new List<Tag>
            {
                new Tag { Key = "tag1", Value = "42" },
                new Tag { Key = "tag2", Value = "ALL" }
            });

            var tags = client.ListTagsForDomain(domain).TagList;
            var count = tags.Count;
            Assert.AreEqual(2, count);

            client.DeleteTagsForDomain(domain, new List<string> { "tag1" });

            tags = client.ListTagsForDomain(domain).TagList;
            count = tags.Count;
            Assert.AreEqual(1, count);

            // Restore previous tags
            if (existingTags.Count > 0)
                client.UpdateTagsForDomain(domain, existingTags);
            else
                client.DeleteTagsForDomain(domain, new List<string> { "tag2" });

            tags = client.ListTagsForDomain(domain).TagList;
            count = tags.Count;
            Assert.AreEqual(existingTags.Count, count);
        }
    }
}
