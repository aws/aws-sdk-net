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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */

using Amazon.Neptune;
using Amazon.Neptune.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class NeptunePaginatorTests
    {
        private static Mock<AmazonNeptuneClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonNeptuneClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        public void DescribeDBClusterEndpointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBClusterEndpointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDBClusterEndpointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDBClusterEndpointsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeDBClusterEndpoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDBClusterEndpoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDBClusterEndpointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBClusterEndpointsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDBClusterEndpointsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeDBClusterEndpoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDBClusterEndpoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        public void DescribeDBEngineVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBEngineVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDBEngineVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDBEngineVersionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeDBEngineVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDBEngineVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDBEngineVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBEngineVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDBEngineVersionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeDBEngineVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDBEngineVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        public void DescribeDBInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDBInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDBInstancesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeDBInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDBInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDBInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDBInstancesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeDBInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDBInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        public void DescribeDBParameterGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBParameterGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDBParameterGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDBParameterGroupsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeDBParameterGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDBParameterGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDBParameterGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBParameterGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDBParameterGroupsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeDBParameterGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDBParameterGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        public void DescribeDBParametersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBParametersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDBParametersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDBParametersResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeDBParameters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDBParameters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDBParametersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBParametersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDBParametersResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeDBParameters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDBParameters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        public void DescribeDBSubnetGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBSubnetGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDBSubnetGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDBSubnetGroupsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeDBSubnetGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDBSubnetGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDBSubnetGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBSubnetGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDBSubnetGroupsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeDBSubnetGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDBSubnetGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        public void DescribeEngineDefaultParametersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEngineDefaultParametersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEngineDefaultParametersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEngineDefaultParametersResponse>();
            secondResponse.EngineDefaults.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeEngineDefaultParameters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEngineDefaultParameters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEngineDefaultParametersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEngineDefaultParametersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEngineDefaultParametersResponse>();
            response.EngineDefaults.Marker = null;

            _mockClient.Setup(x => x.DescribeEngineDefaultParameters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEngineDefaultParameters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        public void DescribeEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        public void DescribeEventSubscriptionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeEventSubscriptions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEventSubscriptions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEventSubscriptionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeEventSubscriptions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEventSubscriptions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        public void DescribeOrderableDBInstanceOptionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrderableDBInstanceOptionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeOrderableDBInstanceOptionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeOrderableDBInstanceOptionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeOrderableDBInstanceOptions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeOrderableDBInstanceOptions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Neptune")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeOrderableDBInstanceOptionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrderableDBInstanceOptionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeOrderableDBInstanceOptionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeOrderableDBInstanceOptions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeOrderableDBInstanceOptions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif