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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */

using Amazon.ChimeSDKIdentity;
using Amazon.ChimeSDKIdentity.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ChimeSDKIdentityPaginatorTests
    {
        private static Mock<AmazonChimeSDKIdentityClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonChimeSDKIdentityClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKIdentity")]
        public void ListAppInstanceAdminsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAppInstanceAdminsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAppInstanceAdminsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAppInstanceAdminsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAppInstanceAdmins(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAppInstanceAdmins(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKIdentity")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAppInstanceAdminsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAppInstanceAdminsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAppInstanceAdminsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAppInstanceAdmins(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAppInstanceAdmins(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKIdentity")]
        public void ListAppInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAppInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAppInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAppInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAppInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAppInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKIdentity")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAppInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAppInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAppInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAppInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAppInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKIdentity")]
        public void ListAppInstanceUserEndpointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAppInstanceUserEndpointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAppInstanceUserEndpointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAppInstanceUserEndpointsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAppInstanceUserEndpoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAppInstanceUserEndpoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKIdentity")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAppInstanceUserEndpointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAppInstanceUserEndpointsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAppInstanceUserEndpointsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAppInstanceUserEndpoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAppInstanceUserEndpoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKIdentity")]
        public void ListAppInstanceUsersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAppInstanceUsersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAppInstanceUsersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAppInstanceUsersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAppInstanceUsers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAppInstanceUsers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKIdentity")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAppInstanceUsersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAppInstanceUsersRequest>();

            var response = InstantiateClassGenerator.Execute<ListAppInstanceUsersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAppInstanceUsers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAppInstanceUsers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}