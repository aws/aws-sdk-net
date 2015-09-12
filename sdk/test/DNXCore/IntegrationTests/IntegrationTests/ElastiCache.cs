using System;
using System.Threading;

using Amazon;
using Amazon.ElastiCache;
using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using System.Collections.Generic;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class ElastiCache : TestBase<AmazonElastiCacheClient>
    {        
        [Fact]
        [Trait(CategoryAttribute,"ElastiCache")]
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
                    Assert.NotNull(group.CacheParameterGroupFamily);
                    Assert.NotNull(group.CacheParameterGroupName);

                    if (group.CacheParameterGroupName.Equals(groupName, StringComparison.OrdinalIgnoreCase))
                        found = true;
                }
                Assert.True(found);
            }
            finally
            {
                var delRequest = new DeleteCacheParameterGroupRequest();
                delRequest.CacheParameterGroupName = groupName;
                Client.DeleteCacheParameterGroupAsync(delRequest).Wait();
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"ElastiCache")]
        public void TestDescribeCacheClusters()
        {
            var response = Client.DescribeCacheClustersAsync().Result;
            foreach (var cluster in response.CacheClusters)
            {
                Assert.NotNull(cluster.CacheClusterId);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"ElastiCache")]
        public void TestDescribeEngineVersions()
        {
            var response = Client.DescribeCacheEngineVersionsAsync().Result;
            foreach (var version in response.CacheEngineVersions)
            {
                Assert.NotNull(version.EngineVersion);
            }
        }
    }
}
