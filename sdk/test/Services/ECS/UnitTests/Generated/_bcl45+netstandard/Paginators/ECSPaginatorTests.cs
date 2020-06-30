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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */

using Amazon.ECS;
using Amazon.ECS.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ECSPaginatorTests
    {
        private static Mock<AmazonECSClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonECSClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
        public void ListAccountSettingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountSettingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccountSettingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccountSettingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccountSettings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccountSettings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccountSettingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountSettingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccountSettingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccountSettings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccountSettings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
        public void ListAttributesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAttributesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAttributesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAttributesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAttributes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAttributes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAttributesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAttributesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAttributesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAttributes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAttributes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
        public void ListClustersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListClustersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListClustersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListClustersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListClusters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListClusters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListClustersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListClustersRequest>();

            var response = InstantiateClassGenerator.Execute<ListClustersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListClusters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListClusters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
        public void ListContainerInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListContainerInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListContainerInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListContainerInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListContainerInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListContainerInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListContainerInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListContainerInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListContainerInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListContainerInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListContainerInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
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
        [TestCategory("ECS")]
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


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
        public void ListTaskDefinitionFamiliesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTaskDefinitionFamiliesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTaskDefinitionFamiliesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTaskDefinitionFamiliesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTaskDefinitionFamilies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTaskDefinitionFamilies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTaskDefinitionFamiliesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTaskDefinitionFamiliesRequest>();

            var response = InstantiateClassGenerator.Execute<ListTaskDefinitionFamiliesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTaskDefinitionFamilies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTaskDefinitionFamilies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
        public void ListTaskDefinitionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTaskDefinitionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTaskDefinitionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTaskDefinitionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTaskDefinitions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTaskDefinitions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTaskDefinitionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTaskDefinitionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTaskDefinitionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTaskDefinitions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTaskDefinitions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
        public void ListTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTasksRequest>();

            var response = InstantiateClassGenerator.Execute<ListTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif