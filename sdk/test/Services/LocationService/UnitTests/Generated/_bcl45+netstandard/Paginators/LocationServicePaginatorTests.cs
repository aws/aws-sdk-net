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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */

using Amazon.LocationService;
using Amazon.LocationService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class LocationServicePaginatorTests
    {
        private static Mock<AmazonLocationServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonLocationServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LocationService")]
        public void GetDevicePositionHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetDevicePositionHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetDevicePositionHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetDevicePositionHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetDevicePositionHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetDevicePositionHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LocationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetDevicePositionHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetDevicePositionHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<GetDevicePositionHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetDevicePositionHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetDevicePositionHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LocationService")]
        public void ListGeofenceCollectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGeofenceCollectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGeofenceCollectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGeofenceCollectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGeofenceCollections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGeofenceCollections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LocationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGeofenceCollectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGeofenceCollectionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListGeofenceCollectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGeofenceCollections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGeofenceCollections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LocationService")]
        public void ListGeofencesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGeofencesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGeofencesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGeofencesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGeofences(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGeofences(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LocationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGeofencesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGeofencesRequest>();

            var response = InstantiateClassGenerator.Execute<ListGeofencesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGeofences(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGeofences(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LocationService")]
        public void ListMapsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMapsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMapsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMapsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMaps(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMaps(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LocationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMapsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMapsRequest>();

            var response = InstantiateClassGenerator.Execute<ListMapsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMaps(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMaps(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LocationService")]
        public void ListPlaceIndexesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPlaceIndexesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPlaceIndexesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPlaceIndexesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPlaceIndexes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPlaceIndexes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LocationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPlaceIndexesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPlaceIndexesRequest>();

            var response = InstantiateClassGenerator.Execute<ListPlaceIndexesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPlaceIndexes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPlaceIndexes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LocationService")]
        public void ListTrackerConsumersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTrackerConsumersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTrackerConsumersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTrackerConsumersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTrackerConsumers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTrackerConsumers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LocationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTrackerConsumersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTrackerConsumersRequest>();

            var response = InstantiateClassGenerator.Execute<ListTrackerConsumersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTrackerConsumers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTrackerConsumers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LocationService")]
        public void ListTrackersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTrackersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTrackersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTrackersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTrackers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTrackers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LocationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTrackersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTrackersRequest>();

            var response = InstantiateClassGenerator.Execute<ListTrackersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTrackers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTrackers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif