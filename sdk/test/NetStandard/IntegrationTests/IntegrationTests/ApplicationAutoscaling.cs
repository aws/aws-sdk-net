using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.ApplicationAutoScaling;

using Xunit;

namespace Amazon.DNXCore.IntegrationTests.IntegrationTests
{
    public class ApplicationAutoscaling : TestBase<AmazonApplicationAutoScalingClient>
    {
        [Fact]
        [Trait(CategoryAttribute, "ApplicationAutoscaling")]
        public async Task EndpointReachableTest()
        {
            var response = await Client.DescribeScalableTargetsAsync(new ApplicationAutoScaling.Model.DescribeScalableTargetsRequest
            {
                MaxResults = 5,
                ServiceNamespace = "ecs"
            });

            Assert.NotNull(response);
            Assert.NotNull(response.ResponseMetadata);
        }
    }
}
