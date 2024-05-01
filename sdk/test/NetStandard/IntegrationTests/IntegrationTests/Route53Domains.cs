using System.Collections.Generic;

using System.Threading.Tasks;
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
        public async Task CheckDomainAvailabilityTest()
        {
            var checkRequest = new CheckDomainAvailabilityRequest
            {
                DomainName = "mydomain1111111111111.com"
            };
            var response = await Client.CheckDomainAvailabilityAsync(checkRequest);
            Assert.Equal(DomainAvailability.AVAILABLE, response.Availability);

            checkRequest = new CheckDomainAvailabilityRequest
            {
                DomainName = "mydomain1111111111111.fake"
            };
            await AssertExtensions.ExpectExceptionAsync<UnsupportedTLDException>(Client.CheckDomainAvailabilityAsync(checkRequest));

            var domains = (await Client.ListDomainsAsync()).Domains;
            if (domains.Count > 0)
            {
                checkRequest.DomainName = domains[0].DomainName;
                response = await Client.CheckDomainAvailabilityAsync(checkRequest);
                Assert.Equal(DomainAvailability.UNAVAILABLE, response.Availability);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"Route53Domains")]
        public async Task TestTagging()
        {
            var domains = (await Client.ListDomainsAsync()).Domains;
            if (domains.Count > 0)
            {
                await TestTaggingAsync(Client, domains[0].DomainName);
            }
        }

        private async Task TestTaggingAsync(AmazonRoute53DomainsClient client, string domain)
        {
            var existingTags = (await client.ListTagsForDomainAsync(domain)).TagList;

            await client.UpdateTagsForDomainAsync(domain,
                new List<Tag>
                {
                    new Tag { Key = "tag1", Value = "42" },
                    new Tag { Key = "tag2", Value = "ALL" }
                });

            var tags = client.ListTagsForDomainAsync(domain).Result.TagList;
            var count = tags.Count;
            Assert.Equal(2, count);

            await client.DeleteTagsForDomainAsync(domain, new List<string> { "tag1" });

            tags = (await client.ListTagsForDomainAsync(domain)).TagList;
            Assert.Single(tags);

            // Restore previous tags
            if (existingTags.Count > 0)
                await client.UpdateTagsForDomainAsync(domain, existingTags);
            else
                await client.DeleteTagsForDomainAsync(domain, new List<string> { "tag2" });

            tags = (await client.ListTagsForDomainAsync(domain)).TagList;
            count = tags.Count;
            Assert.Equal(existingTags.Count, count);
        }
    }
}
