using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Amazon.Runtime;
using Amazon.EC2;
using Amazon.AutoScaling;
using Amazon.AutoScaling.Model;

using Amazon.DNXCore.IntegrationTests;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class AutoScaling : TestBase<AmazonAutoScalingClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public async Task DescribeAccountLimitsTest()
        {
            var response = await Client.DescribeAccountLimitsAsync();
            Assert.NotNull(response);
            Assert.NotNull(response.ResponseMetadata);
            Assert.NotNull(response.ResponseMetadata.RequestId);
            Assert.NotEqual(0, response.MaxNumberOfAutoScalingGroups);
            Assert.NotEqual(0, response.MaxNumberOfLaunchConfigurations);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public async Task NoParamOperationsTest()
        {
            Assert.NotNull(await Client.DescribeAutoScalingGroupsAsync());
            Assert.NotNull(await Client.DescribePoliciesAsync());
            Assert.NotNull(await Client.DescribeScalingProcessTypesAsync());
            Assert.NotNull(await Client.DescribeScalingActivitiesAsync());
            Assert.NotNull(await Client.DescribeNotificationConfigurationsAsync());
            Assert.NotNull(await Client.DescribeAutoScalingNotificationTypesAsync());
            Assert.NotNull(await Client.DescribeAutoScalingInstancesAsync());
            Assert.NotNull(await Client.DescribeLaunchConfigurationsAsync());
            Assert.NotNull(await Client.DescribeAdjustmentTypesAsync());
            Assert.NotNull(await Client.DescribeScheduledActionsAsync());
            Assert.NotNull(await Client.DescribeMetricCollectionTypesAsync());
        }
        
        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public async Task NoParamDescribeTerminationTests()
        {
            var response = await Client.DescribeTerminationPolicyTypesAsync();
            Assert.True(response.TerminationPolicyTypes.Count > 0);
        }

        private static bool ActivitiesPending(IEnumerable<Activity> activities)
        {
            return activities.All(activity => !activity.StatusCode.Equals(ScalingActivityStatusCode.Cancelled) 
                                        && !activity.StatusCode.Equals(ScalingActivityStatusCode.Failed) 
                                        && !activity.StatusCode.Equals(ScalingActivityStatusCode.Successful));
        }
    }
}
