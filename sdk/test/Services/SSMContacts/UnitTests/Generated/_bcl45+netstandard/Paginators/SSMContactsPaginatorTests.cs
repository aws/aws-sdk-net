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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */

using Amazon.SSMContacts;
using Amazon.SSMContacts.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SSMContactsPaginatorTests
    {
        private static Mock<AmazonSSMContactsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSSMContactsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMContacts")]
        public void ListContactChannelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListContactChannelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListContactChannelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListContactChannelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListContactChannels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListContactChannels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMContacts")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListContactChannelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListContactChannelsRequest>();

            var response = InstantiateClassGenerator.Execute<ListContactChannelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListContactChannels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListContactChannels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMContacts")]
        public void ListContactsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListContactsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListContactsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListContactsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListContacts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListContacts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMContacts")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListContactsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListContactsRequest>();

            var response = InstantiateClassGenerator.Execute<ListContactsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListContacts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListContacts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMContacts")]
        public void ListEngagementsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEngagementsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEngagementsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEngagementsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEngagements(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEngagements(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMContacts")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEngagementsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEngagementsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEngagementsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEngagements(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEngagements(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMContacts")]
        public void ListPageReceiptsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPageReceiptsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPageReceiptsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPageReceiptsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPageReceipts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPageReceipts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMContacts")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPageReceiptsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPageReceiptsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPageReceiptsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPageReceipts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPageReceipts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMContacts")]
        public void ListPagesByContactTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPagesByContactRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPagesByContactResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPagesByContactResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPagesByContact(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPagesByContact(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMContacts")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPagesByContactTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPagesByContactRequest>();

            var response = InstantiateClassGenerator.Execute<ListPagesByContactResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPagesByContact(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPagesByContact(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMContacts")]
        public void ListPagesByEngagementTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPagesByEngagementRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPagesByEngagementResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPagesByEngagementResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPagesByEngagement(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPagesByEngagement(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMContacts")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPagesByEngagementTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPagesByEngagementRequest>();

            var response = InstantiateClassGenerator.Execute<ListPagesByEngagementResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPagesByEngagement(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPagesByEngagement(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}