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
 * Do not modify this file. This file is generated from the ebs-2019-11-02.normal.json service model.
 */

using Amazon.EBS;
using Amazon.EBS.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class EBSPaginatorTests
    {
        private static Mock<AmazonEBSClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonEBSClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EBS")]
        public void ListChangedBlocksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListChangedBlocksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListChangedBlocksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListChangedBlocksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListChangedBlocks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListChangedBlocks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EBS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListChangedBlocksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListChangedBlocksRequest>();

            var response = InstantiateClassGenerator.Execute<ListChangedBlocksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListChangedBlocks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListChangedBlocks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EBS")]
        public void ListSnapshotBlocksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSnapshotBlocksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSnapshotBlocksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSnapshotBlocksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSnapshotBlocks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSnapshotBlocks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EBS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSnapshotBlocksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSnapshotBlocksRequest>();

            var response = InstantiateClassGenerator.Execute<ListSnapshotBlocksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSnapshotBlocks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSnapshotBlocks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}