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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */

using Amazon.MigrationHub;
using Amazon.MigrationHub.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MigrationHubPaginatorTests
    {
        private static Mock<AmazonMigrationHubClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMigrationHubClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHub")]
        public void ListApplicationStatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationStatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListApplicationStatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListApplicationStatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApplicationStates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApplicationStates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListApplicationStatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationStatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListApplicationStatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApplicationStates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApplicationStates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHub")]
        public void ListCreatedArtifactsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCreatedArtifactsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCreatedArtifactsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCreatedArtifactsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCreatedArtifacts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCreatedArtifacts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCreatedArtifactsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCreatedArtifactsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCreatedArtifactsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCreatedArtifacts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCreatedArtifacts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHub")]
        public void ListDiscoveredResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDiscoveredResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDiscoveredResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDiscoveredResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDiscoveredResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDiscoveredResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDiscoveredResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDiscoveredResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDiscoveredResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDiscoveredResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDiscoveredResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHub")]
        public void ListMigrationTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMigrationTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMigrationTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMigrationTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMigrationTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMigrationTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMigrationTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMigrationTasksRequest>();

            var response = InstantiateClassGenerator.Execute<ListMigrationTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMigrationTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMigrationTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHub")]
        public void ListProgressUpdateStreamsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProgressUpdateStreamsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProgressUpdateStreamsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProgressUpdateStreamsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProgressUpdateStreams(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProgressUpdateStreams(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProgressUpdateStreamsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProgressUpdateStreamsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProgressUpdateStreamsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProgressUpdateStreams(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProgressUpdateStreams(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif