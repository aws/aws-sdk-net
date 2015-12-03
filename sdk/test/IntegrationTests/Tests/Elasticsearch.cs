using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.Elasticsearch;
using Amazon.Elasticsearch.Model;
using AWSSDK_DotNet.IntegrationTests.Tests;



namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class Elasticsearch : TestBase<AmazonElasticsearchClient>
    {
        [TestMethod]
        [TestCategory("ElasticLoadBalancing")]
        public void TestElasticsearchOperations()
        {
            var domainName = UtilityMethods.GenerateName("domain");

            Client.CreateElasticsearchDomain(new CreateElasticsearchDomainRequest
            {
                DomainName = domainName
            });
            Thread.Sleep(2000);

            try
            {
                var domainNames = Client.ListDomainNames(new ListDomainNamesRequest()).DomainNames;
                Assert.IsTrue(domainNames.Exists(d => d.DomainName.Equals(domainName)));

                var domains = Client.DescribeElasticsearchDomains(new DescribeElasticsearchDomainsRequest
                {
                    DomainNames = new List<string> { domainName }
                }).DomainStatusList;
                Assert.IsTrue(domains.Exists(d => d.DomainName.Equals(domainName)));
            }
            finally
            {
                Client.DeleteElasticsearchDomain(new DeleteElasticsearchDomainRequest
                {
                    DomainName = domainName
                });
            }
        }

    }
}
