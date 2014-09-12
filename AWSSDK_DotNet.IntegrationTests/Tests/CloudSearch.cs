using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.CloudSearch;
using Amazon.CloudSearch.Model;
using Amazon.Runtime;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CloudSearch : TestBase<AmazonCloudSearchClient>
    {
        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        public string generateDomainName()
        {
            var digits = DateTime.Now.Ticks.ToString();

            return string.Format("net-sdk-test-{0}", digits.Substring(digits.Length - 15));
        }

        [TestMethod]
        [TestCategory("CloudSearch")]
        public void TestCreateDomains()
        {
            var domainName = generateDomainName();

            Client.CreateDomain(new CreateDomainRequest { DomainName = domainName });
            try
            {
                var response = Client.DescribeDomains(new DescribeDomainsRequest());
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
                Client.DeleteDomain(new DeleteDomainRequest { DomainName = domainName });
            }
        }

        //[TestMethod]
        //[TestCategory("CloudSearch")]
        public void TestIndexDocuments()
        {
            var domainName = generateDomainName();
            var indexName = "netsdkindex" + DateTime.Now.Ticks.ToString();

            Client.CreateDomain(new CreateDomainRequest { DomainName = domainName });

            var indexField = new IndexField
            {
                IndexFieldName = indexName,
                IndexFieldType = IndexFieldType.Literal
            };

            try
            {
                Client.DefineIndexField(new DefineIndexFieldRequest { DomainName = domainName, IndexField = indexField });

                var status = Client.DescribeDomains(new DescribeDomainsRequest { DomainNames = { domainName } }).DomainStatusList[0].RequiresIndexDocuments;
                Assert.IsTrue(status);

                Client.IndexDocuments(new IndexDocumentsRequest { DomainName = domainName });

                var req = new DescribeDomainsRequest { DomainNames = { domainName } };

                Assert.IsTrue(Client.DescribeDomains(req).DomainStatusList[0].Processing);

            }
            finally
            {

                Client.DeleteDomain(new DeleteDomainRequest { DomainName = domainName });
            }
        }
    }
}
