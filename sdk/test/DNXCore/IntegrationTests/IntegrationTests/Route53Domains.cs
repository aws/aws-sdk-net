using System.Collections.Generic;


using Amazon.Route53Domains;
using Amazon.Route53Domains.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;


namespace Amazon.DNXCore.IntegrationTests
{
    
    public class Route53Domains : TestBase<AmazonRoute53DomainsClient>
    {        
        [Fact]
        [Trait(CategoryAttribute,"Route53Domains")]
        public void CheckDomainAvailabilityTest()
        {
            var checkRequest = new CheckDomainAvailabilityRequest
            {
                DomainName = "mydomain1111111111111.com"
            };
            var response = Client.CheckDomainAvailabilityAsync(checkRequest).Result;
            Assert.Equal(DomainAvailability.AVAILABLE, response.Availability);

            checkRequest = new CheckDomainAvailabilityRequest
            {
                DomainName = "mydomain1111111111111.fake"
            };
            AssertExtensions.ExpectExceptionAsync<UnsupportedTLDException>(Client.CheckDomainAvailabilityAsync(checkRequest)).Wait();

            var domains = Client.ListDomainsAsync().Result.Domains;
            if (domains.Count > 0)
            {
                checkRequest.DomainName = domains[0].DomainName;
                response = Client.CheckDomainAvailabilityAsync(checkRequest).Result;
                Assert.Equal(DomainAvailability.UNAVAILABLE, response.Availability);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"Route53Domains")]
        public void TestTagging()
        {
            var domains = Client.ListDomainsAsync().Result.Domains;
            if (domains.Count > 0)
            {
                TestTagging(Client, domains[0].DomainName);
            }
        }

        private void TestTagging(AmazonRoute53DomainsClient client, string domain)
        {
            var existingTags = client.ListTagsForDomainAsync(domain).Result.TagList;

            client.UpdateTagsForDomainAsync(domain,
                new List<Tag>
                {
                    new Tag { Key = "tag1", Value = "42" },
                    new Tag { Key = "tag2", Value = "ALL" }
                }).Wait();

            var tags = client.ListTagsForDomainAsync(domain).Result.TagList;
            var count = tags.Count;
            Assert.Equal(2, count);

            client.DeleteTagsForDomainAsync(domain, new List<string> { "tag1" }).Wait();

            tags = client.ListTagsForDomainAsync(domain).Result.TagList;
            count = tags.Count;
            Assert.Equal(1, count);

            // Restore previous tags
            if (existingTags.Count > 0)
                client.UpdateTagsForDomainAsync(domain, existingTags).Wait();
            else
                client.DeleteTagsForDomainAsync(domain, new List<string> { "tag2" }).Wait();

            tags = client.ListTagsForDomainAsync(domain).Result.TagList;
            count = tags.Count;
            Assert.Equal(existingTags.Count, count);
        }
    }
}
