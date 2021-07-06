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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */

using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SimpleNotificationServicePaginatorTests
    {
        private static Mock<AmazonSimpleNotificationServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSimpleNotificationServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        public void ListEndpointsByPlatformApplicationTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEndpointsByPlatformApplicationRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEndpointsByPlatformApplicationResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEndpointsByPlatformApplicationResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEndpointsByPlatformApplication(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEndpointsByPlatformApplication(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEndpointsByPlatformApplicationTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEndpointsByPlatformApplicationRequest>();

            var response = InstantiateClassGenerator.Execute<ListEndpointsByPlatformApplicationResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEndpointsByPlatformApplication(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEndpointsByPlatformApplication(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        public void ListOriginationNumbersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOriginationNumbersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOriginationNumbersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOriginationNumbersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOriginationNumbers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOriginationNumbers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOriginationNumbersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOriginationNumbersRequest>();

            var response = InstantiateClassGenerator.Execute<ListOriginationNumbersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOriginationNumbers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOriginationNumbers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        public void ListPhoneNumbersOptedOutTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPhoneNumbersOptedOutRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPhoneNumbersOptedOutResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPhoneNumbersOptedOutResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPhoneNumbersOptedOut(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPhoneNumbersOptedOut(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPhoneNumbersOptedOutTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPhoneNumbersOptedOutRequest>();

            var response = InstantiateClassGenerator.Execute<ListPhoneNumbersOptedOutResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPhoneNumbersOptedOut(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPhoneNumbersOptedOut(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        public void ListPlatformApplicationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPlatformApplicationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPlatformApplicationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPlatformApplicationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPlatformApplications(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPlatformApplications(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPlatformApplicationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPlatformApplicationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPlatformApplicationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPlatformApplications(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPlatformApplications(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        public void ListSMSSandboxPhoneNumbersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSMSSandboxPhoneNumbersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSMSSandboxPhoneNumbersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSMSSandboxPhoneNumbersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSMSSandboxPhoneNumbers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSMSSandboxPhoneNumbers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSMSSandboxPhoneNumbersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSMSSandboxPhoneNumbersRequest>();

            var response = InstantiateClassGenerator.Execute<ListSMSSandboxPhoneNumbersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSMSSandboxPhoneNumbers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSMSSandboxPhoneNumbers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        public void ListSubscriptionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSubscriptionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSubscriptionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSubscriptionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSubscriptions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSubscriptions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSubscriptionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSubscriptionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSubscriptionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSubscriptions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSubscriptions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        public void ListSubscriptionsByTopicTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSubscriptionsByTopicRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSubscriptionsByTopicResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSubscriptionsByTopicResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSubscriptionsByTopic(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSubscriptionsByTopic(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSubscriptionsByTopicTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSubscriptionsByTopicRequest>();

            var response = InstantiateClassGenerator.Execute<ListSubscriptionsByTopicResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSubscriptionsByTopic(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSubscriptionsByTopic(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        public void ListTopicsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTopicsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTopicsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTopicsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTopics(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTopics(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleNotificationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTopicsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTopicsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTopicsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTopics(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTopics(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}