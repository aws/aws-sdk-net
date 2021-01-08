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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */

using Amazon.MediaLive;
using Amazon.MediaLive.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MediaLivePaginatorTests
    {
        private static Mock<AmazonMediaLiveClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMediaLiveClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        public void DescribeScheduleTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScheduleRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeScheduleResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeScheduleResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeSchedule(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSchedule(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeScheduleTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScheduleRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeScheduleResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeSchedule(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSchedule(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
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
        [TestCategory("MediaLive")]
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
        [TestCategory("MediaLive")]
        public void ListInputDevicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInputDevicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInputDevicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInputDevicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInputDevices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInputDevices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInputDevicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInputDevicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListInputDevicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInputDevices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInputDevices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        public void ListInputDeviceTransfersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInputDeviceTransfersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInputDeviceTransfersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInputDeviceTransfersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInputDeviceTransfers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInputDeviceTransfers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInputDeviceTransfersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInputDeviceTransfersRequest>();

            var response = InstantiateClassGenerator.Execute<ListInputDeviceTransfersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInputDeviceTransfers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInputDeviceTransfers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        public void ListInputsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInputsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInputsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInputsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInputs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInputs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInputsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInputsRequest>();

            var response = InstantiateClassGenerator.Execute<ListInputsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInputs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInputs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        public void ListInputSecurityGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInputSecurityGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInputSecurityGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInputSecurityGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInputSecurityGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInputSecurityGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInputSecurityGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInputSecurityGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListInputSecurityGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInputSecurityGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInputSecurityGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        public void ListMultiplexesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMultiplexesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMultiplexesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMultiplexesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMultiplexes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMultiplexes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMultiplexesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMultiplexesRequest>();

            var response = InstantiateClassGenerator.Execute<ListMultiplexesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMultiplexes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMultiplexes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        public void ListMultiplexProgramsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMultiplexProgramsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMultiplexProgramsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMultiplexProgramsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMultiplexPrograms(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMultiplexPrograms(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMultiplexProgramsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMultiplexProgramsRequest>();

            var response = InstantiateClassGenerator.Execute<ListMultiplexProgramsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMultiplexPrograms(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMultiplexPrograms(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        public void ListOfferingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOfferingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOfferingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOfferingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOfferings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOfferings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOfferingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOfferingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListOfferingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOfferings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOfferings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        public void ListReservationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListReservationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListReservationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListReservationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListReservations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListReservations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaLive")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListReservationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListReservationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListReservationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListReservations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListReservations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif