#if !NETSTANDARD13
/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */

using Amazon.AutoScaling;
using Amazon.AutoScaling.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class AutoScalingPaginatorTests
    {
        private static Mock<AmazonAutoScalingClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAutoScalingClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        public void DescribeAutoScalingGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAutoScalingGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAutoScalingGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAutoScalingGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAutoScalingGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAutoScalingGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAutoScalingGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAutoScalingGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAutoScalingGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAutoScalingGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAutoScalingGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        public void DescribeAutoScalingInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAutoScalingInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAutoScalingInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAutoScalingInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAutoScalingInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAutoScalingInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAutoScalingInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAutoScalingInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAutoScalingInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAutoScalingInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAutoScalingInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        public void DescribeLaunchConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLaunchConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeLaunchConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeLaunchConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeLaunchConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeLaunchConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeLaunchConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLaunchConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeLaunchConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeLaunchConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeLaunchConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        public void DescribeNotificationConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNotificationConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeNotificationConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeNotificationConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeNotificationConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeNotificationConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeNotificationConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNotificationConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeNotificationConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeNotificationConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeNotificationConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        public void DescribePoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribePoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribePoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribePoliciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribePolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribePolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribePoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribePoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribePoliciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribePolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribePolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        public void DescribeScalingActivitiesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScalingActivitiesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeScalingActivitiesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeScalingActivitiesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeScalingActivities(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeScalingActivities(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeScalingActivitiesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScalingActivitiesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeScalingActivitiesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeScalingActivities(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeScalingActivities(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        public void DescribeScheduledActionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScheduledActionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeScheduledActionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeScheduledActionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeScheduledActions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeScheduledActions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeScheduledActionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScheduledActionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeScheduledActionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeScheduledActions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeScheduledActions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        public void DescribeTagsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTagsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTagsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTags(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTags(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AutoScaling")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTagsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTagsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTags(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTags(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif