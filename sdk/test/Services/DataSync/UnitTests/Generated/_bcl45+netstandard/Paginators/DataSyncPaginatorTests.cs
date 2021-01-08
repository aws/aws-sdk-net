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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */

using Amazon.DataSync;
using Amazon.DataSync.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class DataSyncPaginatorTests
    {
        private static Mock<AmazonDataSyncClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonDataSyncClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataSync")]
        public void ListAgentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAgentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAgentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAgentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAgents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAgents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataSync")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAgentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAgentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAgentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAgents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAgents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataSync")]
        public void ListLocationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLocationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLocationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLocationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLocations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLocations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataSync")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLocationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLocationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListLocationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLocations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLocations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataSync")]
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
        [TestCategory("DataSync")]
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
        [TestCategory("DataSync")]
        public void ListTaskExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTaskExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTaskExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTaskExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTaskExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTaskExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataSync")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTaskExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTaskExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTaskExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTaskExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTaskExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataSync")]
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
        [TestCategory("DataSync")]
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