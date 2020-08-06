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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */

using Amazon.Chime;
using Amazon.Chime.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ChimePaginatorTests
    {
        private static Mock<AmazonChimeClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonChimeClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        public void ListAccountsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccountsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccountsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccounts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccounts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccountsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccountsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccounts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccounts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        public void ListAttendeesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAttendeesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAttendeesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAttendeesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAttendees(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAttendees(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAttendeesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAttendeesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAttendeesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAttendees(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAttendees(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        public void ListBotsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBotsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBotsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBotsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBots(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBots(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBotsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBotsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBotsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBots(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBots(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        public void ListMeetingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMeetingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMeetingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMeetingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMeetings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMeetings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMeetingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMeetingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListMeetingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMeetings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMeetings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        public void ListPhoneNumberOrdersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPhoneNumberOrdersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPhoneNumberOrdersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPhoneNumberOrdersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPhoneNumberOrders(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPhoneNumberOrders(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPhoneNumberOrdersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPhoneNumberOrdersRequest>();

            var response = InstantiateClassGenerator.Execute<ListPhoneNumberOrdersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPhoneNumberOrders(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPhoneNumberOrders(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        public void ListPhoneNumbersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPhoneNumbersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPhoneNumbersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPhoneNumbersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPhoneNumbers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPhoneNumbers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPhoneNumbersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPhoneNumbersRequest>();

            var response = InstantiateClassGenerator.Execute<ListPhoneNumbersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPhoneNumbers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPhoneNumbers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        public void ListProxySessionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProxySessionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProxySessionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProxySessionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProxySessions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProxySessions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProxySessionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProxySessionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProxySessionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProxySessions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProxySessions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        public void ListRoomMembershipsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRoomMembershipsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRoomMembershipsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRoomMembershipsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRoomMemberships(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRoomMemberships(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRoomMembershipsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRoomMembershipsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRoomMembershipsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRoomMemberships(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRoomMemberships(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        public void ListRoomsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRoomsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRoomsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRoomsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRooms(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRooms(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRoomsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRoomsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRoomsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRooms(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRooms(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        public void ListUsersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUsersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUsersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUsers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUsers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUsersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();

            var response = InstantiateClassGenerator.Execute<ListUsersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUsers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUsers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        public void ListVoiceConnectorGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVoiceConnectorGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVoiceConnectorGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVoiceConnectorGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListVoiceConnectorGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVoiceConnectorGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVoiceConnectorGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVoiceConnectorGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListVoiceConnectorGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListVoiceConnectorGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVoiceConnectorGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        public void ListVoiceConnectorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVoiceConnectorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVoiceConnectorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVoiceConnectorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListVoiceConnectors(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVoiceConnectors(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Chime")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVoiceConnectorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVoiceConnectorsRequest>();

            var response = InstantiateClassGenerator.Execute<ListVoiceConnectorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListVoiceConnectors(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVoiceConnectors(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif