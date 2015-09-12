using System;
using System.Threading;

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
        public void TestCreateDomains()
        {
            var domainName = generateDomainName();

            Client.CreateDomainAsync(new CreateDomainRequest { DomainName = domainName }).Wait();
            try
            {
                var response = Client.DescribeDomainsAsync(new DescribeDomainsRequest()).Result;
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
                Client.DeleteDomainAsync(new DeleteDomainRequest { DomainName = domainName }).Wait();
            }
        }

        //[Fact]
        //[Trait(CategoryAttribute,"CloudSearch")]
        public void TestIndexDocuments()
        {
            var domainName = generateDomainName();
            var indexName = "netsdkindex" + DateTime.Now.Ticks.ToString();

            Client.CreateDomainAsync(new CreateDomainRequest { DomainName = domainName }).Wait();

            var indexField = new IndexField
            {
                IndexFieldName = indexName,
                IndexFieldType = IndexFieldType.Literal
            };

            try
            {
                Client.DefineIndexFieldAsync(new DefineIndexFieldRequest { DomainName = domainName, IndexField = indexField }).Wait();

                var status = Client.DescribeDomainsAsync(new DescribeDomainsRequest { DomainNames = { domainName } }).Result.DomainStatusList[0].RequiresIndexDocuments;
                Assert.True(status);

                Client.IndexDocumentsAsync(new IndexDocumentsRequest { DomainName = domainName }).Wait();

                var req = new DescribeDomainsRequest { DomainNames = { domainName } };

                Assert.True(Client.DescribeDomainsAsync(req).Result.DomainStatusList[0].Processing);

            }
            finally
            {

                Client.DeleteDomainAsync(new DeleteDomainRequest { DomainName = domainName }).Wait();
            }
        }
    }
}
