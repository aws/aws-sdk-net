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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */

using Amazon.AppMesh;
using Amazon.AppMesh.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class AppMeshPaginatorTests
    {
        private static Mock<AmazonAppMeshClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAppMeshClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        public void ListGatewayRoutesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGatewayRoutesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGatewayRoutesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGatewayRoutesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGatewayRoutes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGatewayRoutes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGatewayRoutesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGatewayRoutesRequest>();

            var response = InstantiateClassGenerator.Execute<ListGatewayRoutesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGatewayRoutes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGatewayRoutes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        public void ListMeshesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMeshesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMeshesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMeshesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMeshes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMeshes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMeshesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMeshesRequest>();

            var response = InstantiateClassGenerator.Execute<ListMeshesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMeshes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMeshes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        public void ListRoutesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRoutesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRoutesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRoutesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRoutes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRoutes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRoutesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRoutesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRoutesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRoutes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRoutes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        public void ListTagsForResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTagsForResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsForResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTagsForResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        public void ListVirtualGatewaysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVirtualGatewaysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVirtualGatewaysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVirtualGatewaysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListVirtualGateways(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVirtualGateways(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVirtualGatewaysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVirtualGatewaysRequest>();

            var response = InstantiateClassGenerator.Execute<ListVirtualGatewaysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListVirtualGateways(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVirtualGateways(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        public void ListVirtualNodesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVirtualNodesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVirtualNodesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVirtualNodesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListVirtualNodes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVirtualNodes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVirtualNodesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVirtualNodesRequest>();

            var response = InstantiateClassGenerator.Execute<ListVirtualNodesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListVirtualNodes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVirtualNodes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        public void ListVirtualRoutersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVirtualRoutersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVirtualRoutersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVirtualRoutersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListVirtualRouters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVirtualRouters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVirtualRoutersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVirtualRoutersRequest>();

            var response = InstantiateClassGenerator.Execute<ListVirtualRoutersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListVirtualRouters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVirtualRouters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        public void ListVirtualServicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVirtualServicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVirtualServicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVirtualServicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListVirtualServices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVirtualServices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppMesh")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVirtualServicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVirtualServicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListVirtualServicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListVirtualServices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVirtualServices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif