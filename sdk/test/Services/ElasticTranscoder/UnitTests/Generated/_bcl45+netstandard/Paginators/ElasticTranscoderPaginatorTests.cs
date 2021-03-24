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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */

using Amazon.ElasticTranscoder;
using Amazon.ElasticTranscoder.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ElasticTranscoderPaginatorTests
    {
        private static Mock<AmazonElasticTranscoderClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonElasticTranscoderClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticTranscoder")]
        public void ListJobsByPipelineTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsByPipelineRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJobsByPipelineResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJobsByPipelineResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListJobsByPipeline(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJobsByPipeline(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticTranscoder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJobsByPipelineTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsByPipelineRequest>();

            var response = InstantiateClassGenerator.Execute<ListJobsByPipelineResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListJobsByPipeline(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJobsByPipeline(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticTranscoder")]
        public void ListJobsByStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsByStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJobsByStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJobsByStatusResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListJobsByStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJobsByStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticTranscoder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJobsByStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsByStatusRequest>();

            var response = InstantiateClassGenerator.Execute<ListJobsByStatusResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListJobsByStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJobsByStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticTranscoder")]
        public void ListPipelinesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPipelinesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPipelinesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPipelinesResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListPipelines(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPipelines(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticTranscoder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPipelinesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPipelinesRequest>();

            var response = InstantiateClassGenerator.Execute<ListPipelinesResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListPipelines(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPipelines(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticTranscoder")]
        public void ListPresetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPresetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPresetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPresetsResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListPresets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPresets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticTranscoder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPresetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPresetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPresetsResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListPresets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPresets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}