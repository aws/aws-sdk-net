using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon;
using Amazon.ECS;
using Amazon.ECS.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class ECS : TestBase<AmazonECSClient>
    {
        [TestMethod]
        [TestCategory("ECS")]
        public void ListClusters()
        {            
            var clusters = Client.ListClusters(new ListClustersRequest());            
            Assert.IsTrue(clusters.ClusterArns.Count >= 0);

            foreach (var cluster in clusters.ClusterArns)
            {
                Assert.IsFalse(string.IsNullOrEmpty(cluster));
            }
        }
    }
}
