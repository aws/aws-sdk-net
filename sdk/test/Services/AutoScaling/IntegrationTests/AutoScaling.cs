using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.EC2;
using Amazon.AutoScaling;
using Amazon.AutoScaling.Model;

using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class AutoScaling : TestBase<AmazonAutoScalingClient>
    {
        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("AutoScaling")]
        public void DescribeAccountLimitsTest()
        {
            var response = Client.DescribeAccountLimits();
            var result = response;
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.ResponseMetadata);
            Assert.IsNotNull(response.ResponseMetadata.RequestId);
            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.MaxNumberOfAutoScalingGroups);
            Assert.AreNotEqual(0, result.MaxNumberOfLaunchConfigurations);
        }

        [TestMethod]
        [TestCategory("AutoScaling")]
        public void NoParamDescribeAutoScalingGroupsTest()
        {
            var response = Client.DescribeAutoScalingGroups();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        [TestCategory("AutoScaling")]
        public void NoParamDescribePoliciesTest()
        {
            var response = Client.DescribePolicies();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        [TestCategory("AutoScaling")]
        public void NoParamDescribeScalingProcessTypesTest()
        {
            var response = Client.DescribeScalingProcessTypes();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        [TestCategory("AutoScaling")]
        public void NoParamDescribeScalingActivitiesTest()
        {
            var response = Client.DescribeScalingActivities();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        [TestCategory("AutoScaling")]
        public void NoParamDescribeNotificationConfigurationsTest()
        {
            var response = Client.DescribeNotificationConfigurations();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        [TestCategory("AutoScaling")]
        public void NoParamDescribeAutoScalingNotificationTypesTest()
        {
            var response = Client.DescribeAutoScalingNotificationTypes();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        [TestCategory("AutoScaling")]
        public void NoParamDescribeAutoScalingInstancesTest()
        {
            var response = Client.DescribeAutoScalingInstances();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        [TestCategory("AutoScaling")]
        public void NoParamDescribeLaunchConfigurationsTest()
        {
            var response = Client.DescribeLaunchConfigurations();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        [TestCategory("AutoScaling")]
        public void NoParamDescribeAdjustmentTypesTest()
        {
            var response = Client.DescribeAdjustmentTypes();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        [TestCategory("AutoScaling")]
        public void NoParamDescribeScheduledActionsTest()
        {
            var response = Client.DescribeScheduledActions();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        [TestCategory("AutoScaling")]
        public void NoParamDescribeMetricCollectionTypesTest()
        {
            var response = Client.DescribeMetricCollectionTypes();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        [TestCategory("AutoScaling")]
        public void NoParamDescribeTerminationTests()
        {
            var response = Client.DescribeTerminationPolicyTypes();
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
