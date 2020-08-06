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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */

using Amazon.IoTAnalytics;
using Amazon.IoTAnalytics.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class IoTAnalyticsPaginatorTests
    {
        private static Mock<AmazonIoTAnalyticsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonIoTAnalyticsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTAnalytics")]
        public void ListChannelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListChannelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListChannelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListChannels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListChannels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTAnalytics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListChannelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelsRequest>();

            var response = InstantiateClassGenerator.Execute<ListChannelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListChannels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListChannels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTAnalytics")]
        public void ListDatasetContentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetContentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDatasetContentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDatasetContentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDatasetContents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDatasetContents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTAnalytics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDatasetContentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetContentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDatasetContentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDatasetContents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDatasetContents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTAnalytics")]
        public void ListDatasetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDatasetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDatasetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDatasets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDatasets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTAnalytics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDatasetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDatasetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDatasets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDatasets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTAnalytics")]
        public void ListDatastoresTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDatastoresRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDatastoresResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDatastoresResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDatastores(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDatastores(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTAnalytics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDatastoresTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDatastoresRequest>();

            var response = InstantiateClassGenerator.Execute<ListDatastoresResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDatastores(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDatastores(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTAnalytics")]
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
        [TestCategory("IoTAnalytics")]
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

    }
}
#endif