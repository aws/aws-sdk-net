using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon;
using Amazon.ECS;
using Amazon.ECS.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class ECS : TestBase<AmazonECSClient>
    {
        [Fact]
        public void ListClusters()
        {
            var clusters = Client.ListClustersAsync(new ListClustersRequest()).Result; 
            Assert.True(clusters.ClusterArns.Count >= 0);

            foreach (var cluster in clusters.ClusterArns)
            {
                Assert.False(string.IsNullOrEmpty(cluster));
            }
        }
    }
}
