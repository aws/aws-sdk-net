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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */

using Amazon.NetworkManager;
using Amazon.NetworkManager.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class NetworkManagerPaginatorTests
    {
        private static Mock<AmazonNetworkManagerClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonNetworkManagerClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        public void DescribeGlobalNetworksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeGlobalNetworksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeGlobalNetworksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeGlobalNetworksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeGlobalNetworks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeGlobalNetworks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeGlobalNetworksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeGlobalNetworksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeGlobalNetworksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeGlobalNetworks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeGlobalNetworks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        public void GetConnectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetConnectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetConnectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetConnectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetConnections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetConnections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetConnectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetConnectionsRequest>();

            var response = InstantiateClassGenerator.Execute<GetConnectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetConnections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetConnections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        public void GetCustomerGatewayAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetCustomerGatewayAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetCustomerGatewayAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetCustomerGatewayAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetCustomerGatewayAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetCustomerGatewayAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetCustomerGatewayAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetCustomerGatewayAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<GetCustomerGatewayAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetCustomerGatewayAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetCustomerGatewayAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        public void GetDevicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetDevicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetDevicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetDevicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetDevices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetDevices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetDevicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetDevicesRequest>();

            var response = InstantiateClassGenerator.Execute<GetDevicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetDevices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetDevices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        public void GetLinkAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetLinkAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetLinkAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetLinkAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetLinkAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetLinkAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetLinkAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetLinkAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<GetLinkAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetLinkAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetLinkAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        public void GetLinksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetLinksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetLinksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetLinksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetLinks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetLinks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetLinksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetLinksRequest>();

            var response = InstantiateClassGenerator.Execute<GetLinksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetLinks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetLinks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        public void GetSitesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetSitesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetSitesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetSitesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetSites(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetSites(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetSitesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetSitesRequest>();

            var response = InstantiateClassGenerator.Execute<GetSitesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetSites(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetSites(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        public void GetTransitGatewayConnectPeerAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTransitGatewayConnectPeerAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTransitGatewayConnectPeerAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTransitGatewayConnectPeerAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTransitGatewayConnectPeerAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTransitGatewayConnectPeerAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTransitGatewayConnectPeerAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTransitGatewayConnectPeerAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<GetTransitGatewayConnectPeerAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTransitGatewayConnectPeerAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTransitGatewayConnectPeerAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        public void GetTransitGatewayRegistrationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTransitGatewayRegistrationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTransitGatewayRegistrationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTransitGatewayRegistrationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTransitGatewayRegistrations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTransitGatewayRegistrations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTransitGatewayRegistrationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTransitGatewayRegistrationsRequest>();

            var response = InstantiateClassGenerator.Execute<GetTransitGatewayRegistrationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTransitGatewayRegistrations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTransitGatewayRegistrations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif