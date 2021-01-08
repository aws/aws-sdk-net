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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */

using Amazon.IoTThingsGraph;
using Amazon.IoTThingsGraph.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class IoTThingsGraphPaginatorTests
    {
        private static Mock<AmazonIoTThingsGraphClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonIoTThingsGraphClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        public void GetFlowTemplateRevisionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetFlowTemplateRevisionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetFlowTemplateRevisionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetFlowTemplateRevisionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetFlowTemplateRevisions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetFlowTemplateRevisions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetFlowTemplateRevisionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetFlowTemplateRevisionsRequest>();

            var response = InstantiateClassGenerator.Execute<GetFlowTemplateRevisionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetFlowTemplateRevisions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetFlowTemplateRevisions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        public void GetSystemTemplateRevisionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetSystemTemplateRevisionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetSystemTemplateRevisionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetSystemTemplateRevisionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetSystemTemplateRevisions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetSystemTemplateRevisions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetSystemTemplateRevisionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetSystemTemplateRevisionsRequest>();

            var response = InstantiateClassGenerator.Execute<GetSystemTemplateRevisionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetSystemTemplateRevisions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetSystemTemplateRevisions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        public void ListFlowExecutionMessagesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFlowExecutionMessagesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFlowExecutionMessagesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFlowExecutionMessagesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFlowExecutionMessages(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFlowExecutionMessages(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFlowExecutionMessagesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFlowExecutionMessagesRequest>();

            var response = InstantiateClassGenerator.Execute<ListFlowExecutionMessagesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFlowExecutionMessages(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFlowExecutionMessages(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
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
        [TestCategory("IoTThingsGraph")]
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
        [TestCategory("IoTThingsGraph")]
        public void SearchEntitiesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchEntitiesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchEntitiesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchEntitiesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchEntities(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchEntities(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchEntitiesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchEntitiesRequest>();

            var response = InstantiateClassGenerator.Execute<SearchEntitiesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchEntities(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchEntities(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        public void SearchFlowExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchFlowExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchFlowExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchFlowExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchFlowExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchFlowExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchFlowExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchFlowExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<SearchFlowExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchFlowExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchFlowExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        public void SearchFlowTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchFlowTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchFlowTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchFlowTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchFlowTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchFlowTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchFlowTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchFlowTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<SearchFlowTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchFlowTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchFlowTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        public void SearchSystemInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchSystemInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchSystemInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchSystemInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchSystemInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchSystemInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchSystemInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchSystemInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<SearchSystemInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchSystemInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchSystemInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        public void SearchSystemTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchSystemTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchSystemTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchSystemTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchSystemTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchSystemTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchSystemTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchSystemTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<SearchSystemTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchSystemTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchSystemTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        public void SearchThingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchThingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchThingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchThingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchThings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchThings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTThingsGraph")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchThingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchThingsRequest>();

            var response = InstantiateClassGenerator.Execute<SearchThingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchThings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchThings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif