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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */

using Amazon.EMRContainers;
using Amazon.EMRContainers.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class EMRContainersPaginatorTests
    {
        private static Mock<AmazonEMRContainersClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonEMRContainersClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EMRContainers")]
        public void ListJobRunsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJobRunsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJobRunsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJobRunsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListJobRuns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJobRuns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EMRContainers")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJobRunsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJobRunsRequest>();

            var response = InstantiateClassGenerator.Execute<ListJobRunsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListJobRuns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJobRuns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EMRContainers")]
        public void ListManagedEndpointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListManagedEndpointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListManagedEndpointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListManagedEndpointsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListManagedEndpoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListManagedEndpoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EMRContainers")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListManagedEndpointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListManagedEndpointsRequest>();

            var response = InstantiateClassGenerator.Execute<ListManagedEndpointsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListManagedEndpoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListManagedEndpoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EMRContainers")]
        public void ListVirtualClustersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVirtualClustersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVirtualClustersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVirtualClustersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListVirtualClusters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVirtualClusters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EMRContainers")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVirtualClustersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVirtualClustersRequest>();

            var response = InstantiateClassGenerator.Execute<ListVirtualClustersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListVirtualClusters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVirtualClusters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif