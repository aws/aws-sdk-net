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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */

using Amazon.S3Control;
using Amazon.S3Control.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class S3ControlPaginatorTests
    {
        private static Mock<AmazonS3ControlClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonS3ControlClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("S3Control")]
        public void ListAccessPointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccessPointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccessPointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccessPointsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccessPoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccessPoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("S3Control")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccessPointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccessPointsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccessPointsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccessPoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccessPoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("S3Control")]
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
        [TestCategory("S3Control")]
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
        [TestCategory("S3Control")]
        public void ListRegionalBucketsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRegionalBucketsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRegionalBucketsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRegionalBucketsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRegionalBuckets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRegionalBuckets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("S3Control")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRegionalBucketsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRegionalBucketsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRegionalBucketsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRegionalBuckets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRegionalBuckets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif