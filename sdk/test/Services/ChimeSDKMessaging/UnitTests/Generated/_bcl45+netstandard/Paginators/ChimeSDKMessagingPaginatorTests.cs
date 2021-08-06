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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */

using Amazon.ChimeSDKMessaging;
using Amazon.ChimeSDKMessaging.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ChimeSDKMessagingPaginatorTests
    {
        private static Mock<AmazonChimeSDKMessagingClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonChimeSDKMessagingClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKMessaging")]
        public void ListChannelBansTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelBansRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListChannelBansResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListChannelBansResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListChannelBans(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListChannelBans(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKMessaging")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListChannelBansTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelBansRequest>();

            var response = InstantiateClassGenerator.Execute<ListChannelBansResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListChannelBans(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListChannelBans(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKMessaging")]
        public void ListChannelMembershipsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelMembershipsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListChannelMembershipsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListChannelMembershipsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListChannelMemberships(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListChannelMemberships(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKMessaging")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListChannelMembershipsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelMembershipsRequest>();

            var response = InstantiateClassGenerator.Execute<ListChannelMembershipsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListChannelMemberships(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListChannelMemberships(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKMessaging")]
        public void ListChannelMembershipsForAppInstanceUserTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelMembershipsForAppInstanceUserRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListChannelMembershipsForAppInstanceUserResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListChannelMembershipsForAppInstanceUserResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListChannelMembershipsForAppInstanceUser(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListChannelMembershipsForAppInstanceUser(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKMessaging")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListChannelMembershipsForAppInstanceUserTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelMembershipsForAppInstanceUserRequest>();

            var response = InstantiateClassGenerator.Execute<ListChannelMembershipsForAppInstanceUserResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListChannelMembershipsForAppInstanceUser(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListChannelMembershipsForAppInstanceUser(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKMessaging")]
        public void ListChannelMessagesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelMessagesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListChannelMessagesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListChannelMessagesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListChannelMessages(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListChannelMessages(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKMessaging")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListChannelMessagesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelMessagesRequest>();

            var response = InstantiateClassGenerator.Execute<ListChannelMessagesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListChannelMessages(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListChannelMessages(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKMessaging")]
        public void ListChannelModeratorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelModeratorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListChannelModeratorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListChannelModeratorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListChannelModerators(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListChannelModerators(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKMessaging")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListChannelModeratorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelModeratorsRequest>();

            var response = InstantiateClassGenerator.Execute<ListChannelModeratorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListChannelModerators(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListChannelModerators(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKMessaging")]
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
        [TestCategory("ChimeSDKMessaging")]
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
        [TestCategory("ChimeSDKMessaging")]
        public void ListChannelsModeratedByAppInstanceUserTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelsModeratedByAppInstanceUserRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListChannelsModeratedByAppInstanceUserResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListChannelsModeratedByAppInstanceUserResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListChannelsModeratedByAppInstanceUser(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListChannelsModeratedByAppInstanceUser(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKMessaging")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListChannelsModeratedByAppInstanceUserTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelsModeratedByAppInstanceUserRequest>();

            var response = InstantiateClassGenerator.Execute<ListChannelsModeratedByAppInstanceUserResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListChannelsModeratedByAppInstanceUser(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListChannelsModeratedByAppInstanceUser(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}