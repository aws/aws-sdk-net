using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Linq;

using Amazon.ElasticLoadBalancingV2;
using Amazon.ElasticLoadBalancingV2.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class ElasticLoadBalancingV2 : TestBase<AmazonElasticLoadBalancingV2Client>
    {
        private static string loadBalancerName = "dotnet-test-" + DateTime.Now.ToFileTime();
        private static string loadBalancerArn = null;

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (!string.IsNullOrEmpty(loadBalancerArn))
            {
                Client.DeleteLoadBalancer(new DeleteLoadBalancerRequest
                {
                    LoadBalancerArn = loadBalancerArn
                });
            }
        }

        [TestMethod]
        [TestCategory("ElasticLoadBalancingV2")]
        public void BasicTest()
        {
            Client.DescribeLoadBalancers(new DescribeLoadBalancersRequest
            {
            });
        }
    }
}
