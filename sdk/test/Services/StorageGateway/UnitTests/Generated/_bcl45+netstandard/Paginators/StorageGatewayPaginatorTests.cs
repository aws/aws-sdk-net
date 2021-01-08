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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */

using Amazon.StorageGateway;
using Amazon.StorageGateway.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class StorageGatewayPaginatorTests
    {
        private static Mock<AmazonStorageGatewayClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonStorageGatewayClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        public void DescribeTapeArchivesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTapeArchivesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTapeArchivesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTapeArchivesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeTapeArchives(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTapeArchives(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTapeArchivesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTapeArchivesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTapeArchivesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeTapeArchives(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTapeArchives(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        public void DescribeTapeRecoveryPointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTapeRecoveryPointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTapeRecoveryPointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTapeRecoveryPointsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeTapeRecoveryPoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTapeRecoveryPoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTapeRecoveryPointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTapeRecoveryPointsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTapeRecoveryPointsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeTapeRecoveryPoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTapeRecoveryPoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        public void DescribeTapesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTapesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTapesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTapesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeTapes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTapes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTapesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTapesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTapesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeTapes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTapes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        public void DescribeVTLDevicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVTLDevicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeVTLDevicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeVTLDevicesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeVTLDevices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeVTLDevices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeVTLDevicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVTLDevicesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeVTLDevicesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeVTLDevices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeVTLDevices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        public void ListFileSharesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFileSharesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFileSharesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFileSharesResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListFileShares(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFileShares(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFileSharesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFileSharesRequest>();

            var response = InstantiateClassGenerator.Execute<ListFileSharesResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListFileShares(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFileShares(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        public void ListGatewaysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGatewaysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGatewaysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGatewaysResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListGateways(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGateways(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGatewaysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGatewaysRequest>();

            var response = InstantiateClassGenerator.Execute<ListGatewaysResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListGateways(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGateways(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        public void ListTagsForResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListTagsForResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsForResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListTagsForResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        public void ListTapePoolsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTapePoolsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTapePoolsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTapePoolsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListTapePools(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTapePools(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTapePoolsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTapePoolsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTapePoolsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListTapePools(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTapePools(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        public void ListTapesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTapesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTapesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTapesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListTapes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTapes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTapesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTapesRequest>();

            var response = InstantiateClassGenerator.Execute<ListTapesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListTapes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTapes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        public void ListVolumesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVolumesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVolumesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVolumesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListVolumes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVolumes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StorageGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVolumesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVolumesRequest>();

            var response = InstantiateClassGenerator.Execute<ListVolumesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListVolumes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVolumes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif