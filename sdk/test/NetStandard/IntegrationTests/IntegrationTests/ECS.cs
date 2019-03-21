using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public async System.Threading.Tasks.Task ListClusters()
        {
            var clusters = await Client.ListClustersAsync(new ListClustersRequest()); 
            Assert.True(clusters.ClusterArns.Count >= 0);

            foreach (var cluster in clusters.ClusterArns)
            {
                Assert.False(string.IsNullOrEmpty(cluster));
            }

            return;
        }
    }
}
