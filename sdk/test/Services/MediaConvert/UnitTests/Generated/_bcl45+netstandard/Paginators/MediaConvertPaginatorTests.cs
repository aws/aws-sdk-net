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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */

using Amazon.MediaConvert;
using Amazon.MediaConvert.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MediaConvertPaginatorTests
    {
        private static Mock<AmazonMediaConvertClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMediaConvertClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConvert")]
        public void DescribeEndpointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEndpointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEndpointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEndpointsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeEndpoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEndpoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConvert")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEndpointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEndpointsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEndpointsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeEndpoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEndpoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConvert")]
        public void ListJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConvert")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConvert")]
        public void ListJobTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJobTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJobTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJobTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListJobTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJobTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConvert")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJobTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJobTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListJobTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListJobTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJobTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConvert")]
        public void ListPresetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPresetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPresetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPresetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPresets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPresets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConvert")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPresetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPresetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPresetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPresets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPresets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConvert")]
        public void ListQueuesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListQueuesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListQueuesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListQueuesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListQueues(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListQueues(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConvert")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListQueuesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListQueuesRequest>();

            var response = InstantiateClassGenerator.Execute<ListQueuesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListQueues(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListQueues(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}