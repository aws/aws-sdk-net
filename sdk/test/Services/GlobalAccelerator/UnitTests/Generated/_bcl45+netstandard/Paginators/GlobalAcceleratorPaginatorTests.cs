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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */

using Amazon.GlobalAccelerator;
using Amazon.GlobalAccelerator.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class GlobalAcceleratorPaginatorTests
    {
        private static Mock<AmazonGlobalAcceleratorClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonGlobalAcceleratorClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        public void ListAcceleratorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAcceleratorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAcceleratorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAcceleratorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccelerators(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccelerators(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAcceleratorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAcceleratorsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAcceleratorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccelerators(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccelerators(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        public void ListByoipCidrsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListByoipCidrsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListByoipCidrsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListByoipCidrsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListByoipCidrs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListByoipCidrs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListByoipCidrsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListByoipCidrsRequest>();

            var response = InstantiateClassGenerator.Execute<ListByoipCidrsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListByoipCidrs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListByoipCidrs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        public void ListCustomRoutingAcceleratorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomRoutingAcceleratorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCustomRoutingAcceleratorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCustomRoutingAcceleratorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCustomRoutingAccelerators(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCustomRoutingAccelerators(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCustomRoutingAcceleratorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomRoutingAcceleratorsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCustomRoutingAcceleratorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCustomRoutingAccelerators(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCustomRoutingAccelerators(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        public void ListCustomRoutingEndpointGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomRoutingEndpointGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCustomRoutingEndpointGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCustomRoutingEndpointGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCustomRoutingEndpointGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCustomRoutingEndpointGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCustomRoutingEndpointGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomRoutingEndpointGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCustomRoutingEndpointGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCustomRoutingEndpointGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCustomRoutingEndpointGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        public void ListCustomRoutingListenersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomRoutingListenersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCustomRoutingListenersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCustomRoutingListenersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCustomRoutingListeners(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCustomRoutingListeners(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCustomRoutingListenersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomRoutingListenersRequest>();

            var response = InstantiateClassGenerator.Execute<ListCustomRoutingListenersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCustomRoutingListeners(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCustomRoutingListeners(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        public void ListCustomRoutingPortMappingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomRoutingPortMappingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCustomRoutingPortMappingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCustomRoutingPortMappingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCustomRoutingPortMappings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCustomRoutingPortMappings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCustomRoutingPortMappingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomRoutingPortMappingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCustomRoutingPortMappingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCustomRoutingPortMappings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCustomRoutingPortMappings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        public void ListCustomRoutingPortMappingsByDestinationTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomRoutingPortMappingsByDestinationRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCustomRoutingPortMappingsByDestinationResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCustomRoutingPortMappingsByDestinationResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCustomRoutingPortMappingsByDestination(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCustomRoutingPortMappingsByDestination(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCustomRoutingPortMappingsByDestinationTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomRoutingPortMappingsByDestinationRequest>();

            var response = InstantiateClassGenerator.Execute<ListCustomRoutingPortMappingsByDestinationResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCustomRoutingPortMappingsByDestination(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCustomRoutingPortMappingsByDestination(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        public void ListEndpointGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEndpointGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEndpointGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEndpointGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEndpointGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEndpointGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEndpointGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEndpointGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEndpointGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEndpointGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEndpointGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        public void ListListenersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListListenersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListListenersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListListenersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListListeners(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListListeners(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlobalAccelerator")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListListenersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListListenersRequest>();

            var response = InstantiateClassGenerator.Execute<ListListenersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListListeners(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListListeners(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif