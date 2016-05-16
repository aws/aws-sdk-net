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
            var result = response;
            Assert.NotNull(response);
            Assert.NotNull(response.ResponseMetadata);
            Assert.NotNull(response.ResponseMetadata.RequestId);
            Assert.NotNull(result);
            Assert.NotEqual(0, result.MaxNumberOfAutoScalingGroups);
            Assert.NotEqual(0, result.MaxNumberOfLaunchConfigurations);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public async Task NoParamDescribeAutoScalingGroupsTest()
        {
            var response = await Client.DescribeAutoScalingGroupsAsync();
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public async Task NoParamDescribePoliciesTest()
        {
            var response = await Client.DescribePoliciesAsync();
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public async Task NoParamDescribeScalingProcessTypesTest()
        {
            var response = await Client.DescribeScalingProcessTypesAsync();
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public async Task NoParamDescribeScalingActivitiesTest()
        {
            var response = await Client.DescribeScalingActivitiesAsync();
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public async Task NoParamDescribeNotificationConfigurationsTest()
        {
            var response = await Client.DescribeNotificationConfigurationsAsync();
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public async Task NoParamDescribeAutoScalingNotificationTypesTest()
        {
            var response = await Client.DescribeAutoScalingNotificationTypesAsync();
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public async Task NoParamDescribeAutoScalingInstancesTest()
        {
            var response = await Client.DescribeAutoScalingInstancesAsync();
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public async Task NoParamDescribeLaunchConfigurationsTest()
        {
            var response = await Client.DescribeLaunchConfigurationsAsync();
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public async Task NoParamDescribeAdjustmentTypesTest()
        {
            var response = await Client.DescribeAdjustmentTypesAsync();
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public async Task NoParamDescribeScheduledActionsTest()
        {
            var response = await Client.DescribeScheduledActionsAsync();
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public async Task NoParamDescribeMetricCollectionTypesTest()
        {
            var response = await Client.DescribeMetricCollectionTypesAsync();
            Assert.NotNull(response);
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
