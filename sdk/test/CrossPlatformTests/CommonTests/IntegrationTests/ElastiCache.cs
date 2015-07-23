using System;
using System.Threading;

using Amazon;
using Amazon.ElastiCache;
using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using System.Collections.Generic;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class ElastiCache : TestBase<AmazonElastiCacheClient>
    {
        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [Test]
        [Category("ElastiCache")]
        public void TestCacheParameterGroups()
        {
            var groupName = "SDKDotNetTestGroup";

            try
            {
                var delRequest = new DeleteCacheParameterGroupRequest();
                delRequest.CacheParameterGroupName = groupName;
                Client.DeleteCacheParameterGroupAsync(delRequest).Wait();
            }
            catch (Exception) { }

            var request = new CreateCacheParameterGroupRequest(groupName, "memcached1.4", "testing");

            var res = Client.CreateCacheParameterGroupAsync(request).Result;
            try
            {
                var response = Client.DescribeCacheParameterGroupsAsync().Result;
                var found = false;
                foreach (var group in response.CacheParameterGroups)
                {
                    Assert.IsNotNull(group.CacheParameterGroupFamily);
                    Assert.IsNotNull(group.CacheParameterGroupName);

                    if (group.CacheParameterGroupName.Equals(groupName, StringComparison.OrdinalIgnoreCase))
                        found = true;
                }
                Assert.IsTrue(found);
            }
            finally
            {
                var delRequest = new DeleteCacheParameterGroupRequest();
                delRequest.CacheParameterGroupName = groupName;
                Client.DeleteCacheParameterGroupAsync(delRequest).Wait();
            }
        }

        [Test]
        [Category("ElastiCache")]
        public void TestDescribeCacheClusters()
        {
            var response = Client.DescribeCacheClustersAsync().Result;
            foreach (var cluster in response.CacheClusters)
            {
                Assert.IsNotNull(cluster.CacheClusterId);
            }
        }

        [Test]
        [Category("ElastiCache")]
        public void TestDescribeEngineVersions()
        {
            var response = Client.DescribeCacheEngineVersionsAsync().Result;
            foreach (var version in response.CacheEngineVersions)
            {
                Assert.IsNotNull(version.EngineVersion);
            }
        }
    }
}
