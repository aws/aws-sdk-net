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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */

using Amazon.IoTTwinMaker;
using Amazon.IoTTwinMaker.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class IoTTwinMakerPaginatorTests
    {
        private static Mock<AmazonIoTTwinMakerClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonIoTTwinMakerClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTTwinMaker")]
        public void GetPropertyValueHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetPropertyValueHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetPropertyValueHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetPropertyValueHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetPropertyValueHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetPropertyValueHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTTwinMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetPropertyValueHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetPropertyValueHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<GetPropertyValueHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetPropertyValueHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetPropertyValueHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTTwinMaker")]
        public void ListComponentTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListComponentTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListComponentTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListComponentTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListComponentTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListComponentTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTTwinMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListComponentTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListComponentTypesRequest>();

            var response = InstantiateClassGenerator.Execute<ListComponentTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListComponentTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListComponentTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTTwinMaker")]
        public void ListEntitiesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEntitiesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEntitiesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEntitiesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEntities(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEntities(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTTwinMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEntitiesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEntitiesRequest>();

            var response = InstantiateClassGenerator.Execute<ListEntitiesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEntities(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEntities(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTTwinMaker")]
        public void ListScenesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListScenesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListScenesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListScenesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListScenes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListScenes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTTwinMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListScenesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListScenesRequest>();

            var response = InstantiateClassGenerator.Execute<ListScenesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListScenes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListScenes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTTwinMaker")]
        public void ListWorkspacesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkspacesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorkspacesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorkspacesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorkspaces(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorkspaces(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTTwinMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorkspacesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkspacesRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorkspacesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorkspaces(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorkspaces(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}