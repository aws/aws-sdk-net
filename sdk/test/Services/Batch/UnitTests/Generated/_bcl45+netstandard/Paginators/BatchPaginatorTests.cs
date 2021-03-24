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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */

using Amazon.Batch;
using Amazon.Batch.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class BatchPaginatorTests
    {
        private static Mock<AmazonBatchClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonBatchClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Batch")]
        public void DescribeComputeEnvironmentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeComputeEnvironmentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeComputeEnvironmentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeComputeEnvironmentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeComputeEnvironments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeComputeEnvironments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Batch")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeComputeEnvironmentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeComputeEnvironmentsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeComputeEnvironmentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeComputeEnvironments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeComputeEnvironments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Batch")]
        public void DescribeJobDefinitionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeJobDefinitionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeJobDefinitionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeJobDefinitionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeJobDefinitions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeJobDefinitions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Batch")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeJobDefinitionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeJobDefinitionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeJobDefinitionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeJobDefinitions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeJobDefinitions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Batch")]
        public void DescribeJobQueuesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeJobQueuesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeJobQueuesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeJobQueuesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeJobQueues(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeJobQueues(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Batch")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeJobQueuesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeJobQueuesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeJobQueuesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeJobQueues(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeJobQueues(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Batch")]
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
        [TestCategory("Batch")]
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

    }
}