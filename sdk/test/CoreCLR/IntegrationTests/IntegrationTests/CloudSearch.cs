using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon;
using Amazon.CloudSearch;
using Amazon.CloudSearch.Model;
using Amazon.Runtime;
using Amazon.DNXCore.IntegrationTests;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class CloudSearch : TestBase<AmazonCloudSearchClient>
    {        
        public string generateDomainName()
        {
            var digits = DateTime.Now.Ticks.ToString();

            return string.Format("net-sdk-test-{0}", digits.Substring(digits.Length - 15));
        }

        [Fact]
        [Trait(CategoryAttribute,"CloudSearch")]
        public async Task TestCreateDomains()
        {
            var domainName = generateDomainName();

            await Client.CreateDomainAsync(new CreateDomainRequest { DomainName = domainName });
            try
            {
                var response = await Client.DescribeDomainsAsync(new DescribeDomainsRequest());
                var found = false;
                foreach (var domain in response.DomainStatusList)
                {
                    Assert.NotNull(domain.DomainId);
                    Assert.NotNull(domain.DomainName);
                    Assert.NotNull(domain.ARN);

                    if (domain.DomainName.Equals(domainName, StringComparison.Ordinal))
                        found = true;
                }

                Assert.True(found);
            }
            finally
            {
                await Client.DeleteDomainAsync(new DeleteDomainRequest { DomainName = domainName });
            }
        }
    }
}
