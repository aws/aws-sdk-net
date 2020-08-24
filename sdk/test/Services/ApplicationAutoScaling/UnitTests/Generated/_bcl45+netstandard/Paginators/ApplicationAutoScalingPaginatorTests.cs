#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */

using Amazon.ApplicationAutoScaling;
using Amazon.ApplicationAutoScaling.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ApplicationAutoScalingPaginatorTests
    {
        private static Mock<AmazonApplicationAutoScalingClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonApplicationAutoScalingClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationAutoScaling")]
        public void DescribeScalableTargetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScalableTargetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeScalableTargetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeScalableTargetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeScalableTargets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeScalableTargets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationAutoScaling")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeScalableTargetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScalableTargetsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeScalableTargetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeScalableTargets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeScalableTargets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationAutoScaling")]
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
        [TestCategory("ApplicationAutoScaling")]
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
        [TestCategory("ApplicationAutoScaling")]
        public void DescribeScalingPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScalingPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeScalingPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeScalingPoliciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeScalingPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeScalingPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationAutoScaling")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeScalingPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScalingPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeScalingPoliciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeScalingPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeScalingPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationAutoScaling")]
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
        [TestCategory("ApplicationAutoScaling")]
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

    }
}
#endif