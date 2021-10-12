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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */

using Amazon.MediaTailor;
using Amazon.MediaTailor.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MediaTailorPaginatorTests
    {
        private static Mock<AmazonMediaTailorClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMediaTailorClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaTailor")]
        public void GetChannelScheduleTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetChannelScheduleRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetChannelScheduleResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetChannelScheduleResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetChannelSchedule(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetChannelSchedule(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaTailor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetChannelScheduleTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetChannelScheduleRequest>();

            var response = InstantiateClassGenerator.Execute<GetChannelScheduleResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetChannelSchedule(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetChannelSchedule(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaTailor")]
        public void ListAlertsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAlertsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAlertsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAlertsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAlerts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAlerts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaTailor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAlertsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAlertsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAlertsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAlerts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAlerts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaTailor")]
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
        [TestCategory("MediaTailor")]
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
        [TestCategory("MediaTailor")]
        public void ListPlaybackConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPlaybackConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPlaybackConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPlaybackConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPlaybackConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPlaybackConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaTailor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPlaybackConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPlaybackConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPlaybackConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPlaybackConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPlaybackConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaTailor")]
        public void ListPrefetchSchedulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPrefetchSchedulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPrefetchSchedulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPrefetchSchedulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPrefetchSchedules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPrefetchSchedules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaTailor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPrefetchSchedulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPrefetchSchedulesRequest>();

            var response = InstantiateClassGenerator.Execute<ListPrefetchSchedulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPrefetchSchedules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPrefetchSchedules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaTailor")]
        public void ListSourceLocationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSourceLocationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSourceLocationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSourceLocationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSourceLocations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSourceLocations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaTailor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSourceLocationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSourceLocationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSourceLocationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSourceLocations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSourceLocations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaTailor")]
        public void ListVodSourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVodSourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVodSourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVodSourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListVodSources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVodSources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaTailor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVodSourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVodSourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListVodSourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListVodSources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVodSources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}