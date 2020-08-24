#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */

using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CognitoIdentityProviderPaginatorTests
    {
        private static Mock<AmazonCognitoIdentityProviderClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCognitoIdentityProviderClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        public void AdminListGroupsForUserTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<AdminListGroupsForUserRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<AdminListGroupsForUserResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<AdminListGroupsForUserResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.AdminListGroupsForUser(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.AdminListGroupsForUser(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void AdminListGroupsForUserTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<AdminListGroupsForUserRequest>();

            var response = InstantiateClassGenerator.Execute<AdminListGroupsForUserResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.AdminListGroupsForUser(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.AdminListGroupsForUser(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        public void AdminListUserAuthEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<AdminListUserAuthEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<AdminListUserAuthEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<AdminListUserAuthEventsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.AdminListUserAuthEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.AdminListUserAuthEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void AdminListUserAuthEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<AdminListUserAuthEventsRequest>();

            var response = InstantiateClassGenerator.Execute<AdminListUserAuthEventsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.AdminListUserAuthEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.AdminListUserAuthEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        public void ListGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        public void ListIdentityProvidersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListIdentityProvidersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListIdentityProvidersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListIdentityProvidersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListIdentityProviders(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListIdentityProviders(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListIdentityProvidersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListIdentityProvidersRequest>();

            var response = InstantiateClassGenerator.Execute<ListIdentityProvidersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListIdentityProviders(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListIdentityProviders(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        public void ListResourceServersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourceServersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourceServersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourceServersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResourceServers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResourceServers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourceServersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourceServersRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourceServersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResourceServers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResourceServers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        public void ListUserPoolClientsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUserPoolClientsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUserPoolClientsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUserPoolClientsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUserPoolClients(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUserPoolClients(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUserPoolClientsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUserPoolClientsRequest>();

            var response = InstantiateClassGenerator.Execute<ListUserPoolClientsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUserPoolClients(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUserPoolClients(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        public void ListUserPoolsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUserPoolsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUserPoolsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUserPoolsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUserPools(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUserPools(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUserPoolsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUserPoolsRequest>();

            var response = InstantiateClassGenerator.Execute<ListUserPoolsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUserPools(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUserPools(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        public void ListUsersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUsersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUsersResponse>();
            secondResponse.PaginationToken = null;

            _mockClient.SetupSequence(x => x.ListUsers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUsers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUsersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();

            var response = InstantiateClassGenerator.Execute<ListUsersResponse>();
            response.PaginationToken = null;

            _mockClient.Setup(x => x.ListUsers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUsers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        public void ListUsersInGroupTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersInGroupRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUsersInGroupResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUsersInGroupResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUsersInGroup(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUsersInGroup(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUsersInGroupTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersInGroupRequest>();

            var response = InstantiateClassGenerator.Execute<ListUsersInGroupResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUsersInGroup(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUsersInGroup(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif