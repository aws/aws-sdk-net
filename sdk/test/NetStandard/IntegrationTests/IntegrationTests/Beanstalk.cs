using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Amazon.ElasticBeanstalk;
using Amazon.ElasticBeanstalk.Model;

using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class Beanstalk : TestBase<AmazonElasticBeanstalkClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"Beanstalk")]
        public async Task ListAvailableSolutionStacksTest()
        {
            ListAvailableSolutionStacksResponse response = await Client.ListAvailableSolutionStacksAsync(new ListAvailableSolutionStacksRequest());
            Assert.NotNull(response);
            Assert.True(response.SolutionStacks.Count > 0);
            foreach (string stack in response.SolutionStacks)
            {
                Assert.NotNull(stack);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"Beanstalk")]
        public async Task CheckDNSAvailabilityTest()
        {
            CheckDNSAvailabilityRequest request = new CheckDNSAvailabilityRequest()
            {
                CNAMEPrefix = "mycnamecheck" + DateTime.UtcNow.Ticks
            };

            CheckDNSAvailabilityResponse response = await Client.CheckDNSAvailabilityAsync(request);
            Assert.True(response.Available);
            Assert.NotNull(response.FullyQualifiedCNAME);
        }
    }
}
