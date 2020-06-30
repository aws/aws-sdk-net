#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */

using Amazon.MediaPackage;
using Amazon.MediaPackage.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MediaPackagePaginatorTests
    {
        private static Mock<AmazonMediaPackageClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMediaPackageClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaPackage")]
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
        [TestCategory("MediaPackage")]
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
        [TestCategory("MediaPackage")]
        public void ListHarvestJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListHarvestJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListHarvestJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListHarvestJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListHarvestJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListHarvestJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaPackage")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListHarvestJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListHarvestJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListHarvestJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListHarvestJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListHarvestJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaPackage")]
        public void ListOriginEndpointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOriginEndpointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOriginEndpointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOriginEndpointsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOriginEndpoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOriginEndpoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaPackage")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOriginEndpointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOriginEndpointsRequest>();

            var response = InstantiateClassGenerator.Execute<ListOriginEndpointsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOriginEndpoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOriginEndpoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif