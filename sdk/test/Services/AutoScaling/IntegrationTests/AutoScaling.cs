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

        // Test disabled, $ and time constraints
        //[TestMethod]
        //[TestCategory("AutoScaling")]
        public void AutoScalingGroupCRUDTest()
        {
            var groupName = string.Concat(UtilityMethods.SDK_TEST_PREFIX, "TestAutoScalingGroup", DateTime.UtcNow.Ticks);
            var launchConfigName = string.Concat(UtilityMethods.SDK_TEST_PREFIX, "TestLaunchConfiguration", DateTime.UtcNow.Ticks);

            try
            {
                string imageId;
                using (var ec2Client = new AmazonEC2Client())
                {
                    imageId = Amazon.EC2.Util.ImageUtilities.FindImage(ec2Client, Amazon.EC2.Util.ImageUtilities.WINDOWS_2012_BASE).ImageId;
                }
                // create the initial launch configuration and group
                var createLaunchConfigRequest = new CreateLaunchConfigurationRequest
                {
                    ImageId = imageId,
                    InstanceType = "m1.small",
                    LaunchConfigurationName = launchConfigName
                };
                var createLaunchConfigResponse = Client.CreateLaunchConfiguration(createLaunchConfigRequest);
                Assert.IsNotNull(createLaunchConfigResponse);

                var createGroupRequest = new CreateAutoScalingGroupRequest
                {
                    AutoScalingGroupName = groupName,
                    MinSize = 1,
                    MaxSize = 5,
                    AvailabilityZones = new List<string> { "us-east-1b" },
                    LaunchConfigurationName = launchConfigName
                };  
                var createGroupresponse = Client.CreateAutoScalingGroup(createGroupRequest);
                Assert.IsNotNull(createGroupresponse);

                // make a simple update to the group
                var updateGroupRequest = new UpdateAutoScalingGroupRequest
                {
                    AutoScalingGroupName = groupName,
                    MinSize = 1,
                    MaxSize = 2,
                    LaunchConfigurationName = launchConfigName
                };
                Client.UpdateAutoScalingGroup(updateGroupRequest);

                // poll the group to check activity
                var describeGroupsRequest = new DescribeAutoScalingGroupsRequest
                {
                    AutoScalingGroupNames = new List<string> {groupName}
                };
                var describeGroupsResponse = Client.DescribeAutoScalingGroups(describeGroupsRequest);
                while (describeGroupsResponse.AutoScalingGroups[0].Instances.Count == 0)
                {
                    Console.WriteLine("Sleeping 30s while some instance starts");
                    Thread.Sleep(TimeSpan.FromSeconds(30));
                    describeGroupsResponse = Client.DescribeAutoScalingGroups(describeGroupsRequest);
                }
                var instances = describeGroupsResponse.AutoScalingGroups[0].Instances;
                Assert.IsNotNull(instances);
                Assert.IsTrue(instances.Count > 0);

                var describeActivitiesRequest = new DescribeScalingActivitiesRequest
                {
                    AutoScalingGroupName = groupName
                };
                var describeActivitiesResponse = Client.DescribeScalingActivities(describeActivitiesRequest);
                while (ActivitiesPending(describeActivitiesResponse.Activities))
                {
                    Console.WriteLine("Sleeping 15s waiting for no activities to be pending/in-progres");
                    Thread.Sleep(TimeSpan.FromSeconds(15));
                    describeActivitiesResponse = Client.DescribeScalingActivities(describeActivitiesRequest);
                }

                // make another configuration change to the group, then manually terminate 
                // any remaining instances it contains
                updateGroupRequest = new UpdateAutoScalingGroupRequest
                {
                    AutoScalingGroupName = groupName,
                    MinSize = 0,
                    MaxSize = 2,
                    LaunchConfigurationName = launchConfigName
                };

                Client.UpdateAutoScalingGroup(updateGroupRequest);

                foreach (var instance in instances)
                {
                    var terminateRequest = new TerminateInstanceInAutoScalingGroupRequest
                    {
                        InstanceId = instance.InstanceId,
                        ShouldDecrementDesiredCapacity = true
                    };

                    var terminateResult = Client.TerminateInstanceInAutoScalingGroup(terminateRequest);
                    var activity = terminateResult.Activity;
                    Assert.IsNotNull(activity);
                    Assert.IsNotNull(activity.ActivityId);
                    Assert.IsNotNull(activity.Description);
                    Assert.IsNotNull(activity.Progress);
                }

                // wait for all instances to terminate, then cleanup
                describeGroupsResponse = Client.DescribeAutoScalingGroups(describeGroupsRequest);
                while (describeGroupsResponse.AutoScalingGroups[0].Instances.Count != 0)
                {
                    Console.WriteLine("Waiting 30s for instance(s) to terminate.");
                    Thread.Sleep(TimeSpan.FromSeconds(30));
                    describeGroupsResponse = Client.DescribeAutoScalingGroups(describeGroupsRequest);
                }

                Assert.IsTrue(describeGroupsResponse.AutoScalingGroups[0].Instances.Count == 0);
            }
            finally
            {
                Client.DeleteAutoScalingGroup(new DeleteAutoScalingGroupRequest
                {
                    AutoScalingGroupName = groupName,
                    ForceDelete = true
                });
                Client.DeleteLaunchConfiguration(new DeleteLaunchConfigurationRequest
                {
                    LaunchConfigurationName = launchConfigName
                });
            }
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
