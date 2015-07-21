using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon;
using Amazon.ECS;
using Amazon.ECS.Model;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class ECS : TestBase<AmazonECSClient>
    {
        [Test]
        public void ListClusters()
        {
            var clusters = Client.ListClustersAsync(new ListClustersRequest()).Result; 
            Assert.IsTrue(clusters.ClusterArns.Count >= 0);

            foreach (var cluster in clusters.ClusterArns)
            {
                Assert.IsFalse(string.IsNullOrEmpty(cluster));
            }
        }
    }
}
