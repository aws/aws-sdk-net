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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */

using Amazon.CodePipeline;
using Amazon.CodePipeline.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CodePipelinePaginatorTests
    {
        private static Mock<AmazonCodePipelineClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCodePipelineClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodePipeline")]
        public void ListActionExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListActionExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListActionExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListActionExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListActionExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListActionExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodePipeline")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListActionExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListActionExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListActionExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListActionExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListActionExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodePipeline")]
        public void ListActionTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListActionTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListActionTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListActionTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListActionTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListActionTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodePipeline")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListActionTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListActionTypesRequest>();

            var response = InstantiateClassGenerator.Execute<ListActionTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListActionTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListActionTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodePipeline")]
        public void ListPipelineExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPipelineExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPipelineExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPipelineExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPipelineExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPipelineExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodePipeline")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPipelineExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPipelineExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPipelineExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPipelineExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPipelineExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodePipeline")]
        public void ListPipelinesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPipelinesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPipelinesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPipelinesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPipelines(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPipelines(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodePipeline")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPipelinesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPipelinesRequest>();

            var response = InstantiateClassGenerator.Execute<ListPipelinesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPipelines(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPipelines(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodePipeline")]
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
        [TestCategory("CodePipeline")]
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
        [TestCategory("CodePipeline")]
        public void ListWebhooksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWebhooksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWebhooksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWebhooksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWebhooks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWebhooks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodePipeline")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWebhooksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWebhooksRequest>();

            var response = InstantiateClassGenerator.Execute<ListWebhooksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWebhooks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWebhooks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif