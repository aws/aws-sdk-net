using System;
using System.Threading;

using Amazon;
using Amazon.CloudSearch;
using Amazon.CloudSearch.Model;
using Amazon.Runtime;
using CommonTests.Framework;
using NUnit.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class CloudSearch : TestBase<AmazonCloudSearchClient>
    {
        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        public string generateDomainName()
        {
            var digits = DateTime.Now.Ticks.ToString();

            return string.Format("net-sdk-test-{0}", digits.Substring(digits.Length - 15));
        }

        [Test]
        [Category("CloudSearch")]
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
                    Assert.IsNotNull(domain.DomainId);
                    Assert.IsNotNull(domain.DomainName);
                    Assert.IsNotNull(domain.ARN);

                    if (domain.DomainName.Equals(domainName, StringComparison.Ordinal))
                        found = true;
                }

                Assert.IsTrue(found);
            }
            finally
            {
                Client.DeleteDomainAsync(new DeleteDomainRequest { DomainName = domainName }).Wait();
            }
        }

        //[Test]
        //[Category("CloudSearch")]
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
                Assert.IsTrue(status);

                Client.IndexDocumentsAsync(new IndexDocumentsRequest { DomainName = domainName }).Wait();

                var req = new DescribeDomainsRequest { DomainNames = { domainName } };

                Assert.IsTrue(Client.DescribeDomainsAsync(req).Result.DomainStatusList[0].Processing);

            }
            finally
            {

                Client.DeleteDomainAsync(new DeleteDomainRequest { DomainName = domainName }).Wait();
            }
        }
    }
}
