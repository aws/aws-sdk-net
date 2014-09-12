using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.ElastiCache;
using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using AWSSDK_DotNet.IntegrationTests.Utils;
using AWSSDK_DotNet.IntegrationTests.Tests;
using System.Collections.Generic;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class ElastiCache : TestBase<AmazonElastiCacheClient>
    {
        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("ElastiCache")]
        public void TestCacheParameterGroups()
        {
            var groupName = "SDKDotNetTestGroup";

            try
            {
                var delRequest = new DeleteCacheParameterGroupRequest();
                delRequest.CacheParameterGroupName = groupName;
                Client.DeleteCacheParameterGroup(delRequest);
            }
            catch (Exception) { }

            var request = new CreateCacheParameterGroupRequest(groupName, "memcached1.4", "testing");

            var res = Client.CreateCacheParameterGroup(request);
            try
            {
                var response = Client.DescribeCacheParameterGroups();
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
                Client.DeleteCacheParameterGroup(delRequest);
            }
        }

        [TestMethod]
        [TestCategory("ElastiCache")]
        public void TestDescribeCacheClusters()
        {
            var response = Client.DescribeCacheClusters();
            foreach (var cluster in response.CacheClusters)
            {
                Assert.IsNotNull(cluster.CacheClusterId);
            }
        }

        [TestMethod]
        [TestCategory("ElastiCache")]
        public void TestDescribeEngineVersions()
        {
            var response = Client.DescribeCacheEngineVersions();
            foreach (var version in response.CacheEngineVersions)
            {
                Assert.IsNotNull(version.EngineVersion);
            }
        }
    }
}
