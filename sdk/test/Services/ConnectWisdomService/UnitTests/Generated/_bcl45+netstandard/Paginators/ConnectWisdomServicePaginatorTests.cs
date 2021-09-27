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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
 */

using Amazon.ConnectWisdomService;
using Amazon.ConnectWisdomService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ConnectWisdomServicePaginatorTests
    {
        private static Mock<AmazonConnectWisdomServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonConnectWisdomServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectWisdomService")]
        public void ListAssistantAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssistantAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssistantAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssistantAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssistantAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssistantAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectWisdomService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssistantAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssistantAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssistantAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssistantAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssistantAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectWisdomService")]
        public void ListAssistantsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssistantsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssistantsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssistantsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssistants(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssistants(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectWisdomService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssistantsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssistantsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssistantsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssistants(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssistants(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectWisdomService")]
        public void ListContentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListContentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListContentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListContentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListContents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListContents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectWisdomService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListContentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListContentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListContentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListContents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListContents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectWisdomService")]
        public void ListKnowledgeBasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListKnowledgeBasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListKnowledgeBasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListKnowledgeBasesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListKnowledgeBases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListKnowledgeBases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectWisdomService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListKnowledgeBasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListKnowledgeBasesRequest>();

            var response = InstantiateClassGenerator.Execute<ListKnowledgeBasesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListKnowledgeBases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListKnowledgeBases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectWisdomService")]
        public void QueryAssistantTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<QueryAssistantRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<QueryAssistantResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<QueryAssistantResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.QueryAssistant(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.QueryAssistant(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectWisdomService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void QueryAssistantTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<QueryAssistantRequest>();

            var response = InstantiateClassGenerator.Execute<QueryAssistantResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.QueryAssistant(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.QueryAssistant(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectWisdomService")]
        public void SearchContentTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchContentRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchContentResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchContentResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchContent(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchContent(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectWisdomService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchContentTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchContentRequest>();

            var response = InstantiateClassGenerator.Execute<SearchContentResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchContent(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchContent(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectWisdomService")]
        public void SearchSessionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchSessionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchSessionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchSessionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchSessions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchSessions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectWisdomService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchSessionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchSessionsRequest>();

            var response = InstantiateClassGenerator.Execute<SearchSessionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchSessions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchSessions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}