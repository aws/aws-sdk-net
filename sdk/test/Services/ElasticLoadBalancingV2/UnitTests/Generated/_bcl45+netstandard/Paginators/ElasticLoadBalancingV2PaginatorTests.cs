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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */

using Amazon.ElasticLoadBalancingV2;
using Amazon.ElasticLoadBalancingV2.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ElasticLoadBalancingV2PaginatorTests
    {
        private static Mock<AmazonElasticLoadBalancingV2Client> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonElasticLoadBalancingV2Client>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void DescribeListenersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeListenersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeListenersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeListenersResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.DescribeListeners(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeListeners(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticLoadBalancingV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeListenersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeListenersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeListenersResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.DescribeListeners(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeListeners(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void DescribeLoadBalancersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLoadBalancersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeLoadBalancersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeLoadBalancersResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.DescribeLoadBalancers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeLoadBalancers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticLoadBalancingV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeLoadBalancersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLoadBalancersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeLoadBalancersResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.DescribeLoadBalancers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeLoadBalancers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void DescribeTargetGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTargetGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTargetGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTargetGroupsResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.DescribeTargetGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTargetGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticLoadBalancingV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTargetGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTargetGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTargetGroupsResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.DescribeTargetGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTargetGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif