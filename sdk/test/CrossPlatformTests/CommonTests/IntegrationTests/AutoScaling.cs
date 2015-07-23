using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Amazon.Runtime;
using Amazon.EC2;
using Amazon.AutoScaling;
using Amazon.AutoScaling.Model;

using CommonTests.Framework;
using NUnit.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class AutoScaling : TestBase<AmazonAutoScalingClient>
    {
        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [Test]
        [Category("AutoScaling")]
        public void DescribeAccountLimitsTest()
        {
            var response = Client.DescribeAccountLimitsAsync().Result;
            var result = response;
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.ResponseMetadata);
            Assert.IsNotNull(response.ResponseMetadata.RequestId);
            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.MaxNumberOfAutoScalingGroups);
            Assert.AreNotEqual(0, result.MaxNumberOfLaunchConfigurations);
        }

        [Test]
        [Category("AutoScaling")]
        public void NoParamDescribeAutoScalingGroupsTest()
        {
            var response = Client.DescribeAutoScalingGroupsAsync().Result;
            Assert.IsNotNull(response);
        }

        [Test]
        [Category("AutoScaling")]
        public void NoParamDescribePoliciesTest()
        {
            var response = Client.DescribePoliciesAsync().Result;
            Assert.IsNotNull(response);
        }

        [Test]
        [Category("AutoScaling")]
        public void NoParamDescribeScalingProcessTypesTest()
        {
            var response = Client.DescribeScalingProcessTypesAsync().Result;
            Assert.IsNotNull(response);
        }

        [Test]
        [Category("AutoScaling")]
        public void NoParamDescribeScalingActivitiesTest()
        {
            var response = Client.DescribeScalingActivitiesAsync().Result;
            Assert.IsNotNull(response);
        }

        [Test]
        [Category("AutoScaling")]
        public void NoParamDescribeNotificationConfigurationsTest()
        {
            var response = Client.DescribeNotificationConfigurationsAsync().Result;
            Assert.IsNotNull(response);
        }

        [Test]
        [Category("AutoScaling")]
        public void NoParamDescribeAutoScalingNotificationTypesTest()
        {
            var response = Client.DescribeAutoScalingNotificationTypesAsync().Result;
            Assert.IsNotNull(response);
        }

        [Test]
        [Category("AutoScaling")]
        public void NoParamDescribeAutoScalingInstancesTest()
        {
            var response = Client.DescribeAutoScalingInstancesAsync().Result;
            Assert.IsNotNull(response);
        }

        [Test]
        [Category("AutoScaling")]
        public void NoParamDescribeLaunchConfigurationsTest()
        {
            var response = Client.DescribeLaunchConfigurationsAsync().Result;
            Assert.IsNotNull(response);
        }

        [Test]
        [Category("AutoScaling")]
        public void NoParamDescribeAdjustmentTypesTest()
        {
            var response = Client.DescribeAdjustmentTypesAsync().Result;
            Assert.IsNotNull(response);
        }

        [Test]
        [Category("AutoScaling")]
        public void NoParamDescribeScheduledActionsTest()
        {
            var response = Client.DescribeScheduledActionsAsync().Result;
            Assert.IsNotNull(response);
        }

        [Test]
        [Category("AutoScaling")]
        public void NoParamDescribeMetricCollectionTypesTest()
        {
            var response = Client.DescribeMetricCollectionTypesAsync().Result;
            Assert.IsNotNull(response);
        }

        [Test]
        [Category("AutoScaling")]
        public void NoParamDescribeTerminationTests()
        {
            var response = Client.DescribeTerminationPolicyTypesAsync().Result;
            Assert.IsTrue(response.TerminationPolicyTypes.Count > 0);
        }

        private static bool ActivitiesPending(IEnumerable<Activity> activities)
        {
            return activities.All(activity => !activity.StatusCode.Equals(ScalingActivityStatusCode.Cancelled) 
                                        && !activity.StatusCode.Equals(ScalingActivityStatusCode.Failed) 
                                        && !activity.StatusCode.Equals(ScalingActivityStatusCode.Successful));
        }
    }
}
