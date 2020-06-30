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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */

using Amazon.ServiceDiscovery;
using Amazon.ServiceDiscovery.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ServiceDiscoveryPaginatorTests
    {
        private static Mock<AmazonServiceDiscoveryClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonServiceDiscoveryClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceDiscovery")]
        public void GetInstancesHealthStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetInstancesHealthStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetInstancesHealthStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetInstancesHealthStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetInstancesHealthStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetInstancesHealthStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceDiscovery")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetInstancesHealthStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetInstancesHealthStatusRequest>();

            var response = InstantiateClassGenerator.Execute<GetInstancesHealthStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetInstancesHealthStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetInstancesHealthStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceDiscovery")]
        public void ListInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceDiscovery")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceDiscovery")]
        public void ListNamespacesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNamespacesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNamespacesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNamespacesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListNamespaces(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNamespaces(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceDiscovery")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNamespacesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNamespacesRequest>();

            var response = InstantiateClassGenerator.Execute<ListNamespacesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListNamespaces(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNamespaces(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceDiscovery")]
        public void ListOperationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOperationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOperationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOperationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOperations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOperations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceDiscovery")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOperationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOperationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListOperationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOperations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOperations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceDiscovery")]
        public void ListServicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceDiscovery")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListServicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif