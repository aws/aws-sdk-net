using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

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
        public void DescribeAccountLimitsTest()
        {
            var response = Client.DescribeAccountLimitsAsync().Result;
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
        public void NoParamDescribeAutoScalingGroupsTest()
        {
            var response = Client.DescribeAutoScalingGroupsAsync().Result;
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public void NoParamDescribePoliciesTest()
        {
            var response = Client.DescribePoliciesAsync().Result;
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public void NoParamDescribeScalingProcessTypesTest()
        {
            var response = Client.DescribeScalingProcessTypesAsync().Result;
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public void NoParamDescribeScalingActivitiesTest()
        {
            var response = Client.DescribeScalingActivitiesAsync().Result;
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public void NoParamDescribeNotificationConfigurationsTest()
        {
            var response = Client.DescribeNotificationConfigurationsAsync().Result;
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public void NoParamDescribeAutoScalingNotificationTypesTest()
        {
            var response = Client.DescribeAutoScalingNotificationTypesAsync().Result;
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public void NoParamDescribeAutoScalingInstancesTest()
        {
            var response = Client.DescribeAutoScalingInstancesAsync().Result;
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public void NoParamDescribeLaunchConfigurationsTest()
        {
            var response = Client.DescribeLaunchConfigurationsAsync().Result;
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public void NoParamDescribeAdjustmentTypesTest()
        {
            var response = Client.DescribeAdjustmentTypesAsync().Result;
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public void NoParamDescribeScheduledActionsTest()
        {
            var response = Client.DescribeScheduledActionsAsync().Result;
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public void NoParamDescribeMetricCollectionTypesTest()
        {
            var response = Client.DescribeMetricCollectionTypesAsync().Result;
            Assert.NotNull(response);
        }

        [Fact]
        [Trait(CategoryAttribute,"AutoScaling")]
        public void NoParamDescribeTerminationTests()
        {
            var response = Client.DescribeTerminationPolicyTypesAsync().Result;
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
