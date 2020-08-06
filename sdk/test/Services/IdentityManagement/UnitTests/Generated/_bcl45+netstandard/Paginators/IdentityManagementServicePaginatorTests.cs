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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class IdentityManagementServicePaginatorTests
    {
        private static Mock<AmazonIdentityManagementServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonIdentityManagementServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void GetAccountAuthorizationDetailsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetAccountAuthorizationDetailsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetAccountAuthorizationDetailsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetAccountAuthorizationDetailsResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.GetAccountAuthorizationDetails(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetAccountAuthorizationDetails(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetAccountAuthorizationDetailsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetAccountAuthorizationDetailsRequest>();

            var response = InstantiateClassGenerator.Execute<GetAccountAuthorizationDetailsResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.GetAccountAuthorizationDetails(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetAccountAuthorizationDetails(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void GetGroupTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetGroupRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetGroupResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetGroupResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.GetGroup(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetGroup(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetGroupTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetGroupRequest>();

            var response = InstantiateClassGenerator.Execute<GetGroupResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.GetGroup(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetGroup(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListAccessKeysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccessKeysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccessKeysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccessKeysResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListAccessKeys(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccessKeys(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccessKeysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccessKeysRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccessKeysResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListAccessKeys(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccessKeys(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListAccountAliasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountAliasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccountAliasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccountAliasesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListAccountAliases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccountAliases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccountAliasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountAliasesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccountAliasesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListAccountAliases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccountAliases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListAttachedGroupPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAttachedGroupPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAttachedGroupPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAttachedGroupPoliciesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListAttachedGroupPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAttachedGroupPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAttachedGroupPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAttachedGroupPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAttachedGroupPoliciesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListAttachedGroupPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAttachedGroupPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListAttachedRolePoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAttachedRolePoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAttachedRolePoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAttachedRolePoliciesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListAttachedRolePolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAttachedRolePolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAttachedRolePoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAttachedRolePoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAttachedRolePoliciesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListAttachedRolePolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAttachedRolePolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListAttachedUserPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAttachedUserPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAttachedUserPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAttachedUserPoliciesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListAttachedUserPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAttachedUserPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAttachedUserPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAttachedUserPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAttachedUserPoliciesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListAttachedUserPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAttachedUserPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListEntitiesForPolicyTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEntitiesForPolicyRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEntitiesForPolicyResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEntitiesForPolicyResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListEntitiesForPolicy(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEntitiesForPolicy(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEntitiesForPolicyTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEntitiesForPolicyRequest>();

            var response = InstantiateClassGenerator.Execute<ListEntitiesForPolicyResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListEntitiesForPolicy(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEntitiesForPolicy(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListGroupPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGroupPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGroupPoliciesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListGroupPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGroupPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGroupPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListGroupPoliciesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListGroupPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGroupPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGroupsResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListGroupsResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListGroupsForUserTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupsForUserRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGroupsForUserResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGroupsForUserResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListGroupsForUser(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGroupsForUser(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGroupsForUserTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupsForUserRequest>();

            var response = InstantiateClassGenerator.Execute<ListGroupsForUserResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListGroupsForUser(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGroupsForUser(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListInstanceProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInstanceProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInstanceProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInstanceProfilesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListInstanceProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInstanceProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInstanceProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInstanceProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<ListInstanceProfilesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListInstanceProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInstanceProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListInstanceProfilesForRoleTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInstanceProfilesForRoleRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInstanceProfilesForRoleResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInstanceProfilesForRoleResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListInstanceProfilesForRole(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInstanceProfilesForRole(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInstanceProfilesForRoleTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInstanceProfilesForRoleRequest>();

            var response = InstantiateClassGenerator.Execute<ListInstanceProfilesForRoleResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListInstanceProfilesForRole(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInstanceProfilesForRole(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListMFADevicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMFADevicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMFADevicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMFADevicesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListMFADevices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMFADevices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMFADevicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMFADevicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListMFADevicesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListMFADevices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMFADevices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPoliciesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListPoliciesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListPolicyVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPolicyVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPolicyVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPolicyVersionsResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListPolicyVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPolicyVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPolicyVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPolicyVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPolicyVersionsResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListPolicyVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPolicyVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListRolePoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRolePoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRolePoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRolePoliciesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListRolePolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRolePolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRolePoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRolePoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRolePoliciesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListRolePolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRolePolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListRolesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRolesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRolesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRolesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListRoles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRoles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRolesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRolesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRolesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListRoles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRoles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListServerCertificatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServerCertificatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServerCertificatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServerCertificatesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListServerCertificates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServerCertificates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServerCertificatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServerCertificatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListServerCertificatesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListServerCertificates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServerCertificates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListSigningCertificatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSigningCertificatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSigningCertificatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSigningCertificatesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListSigningCertificates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSigningCertificates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSigningCertificatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSigningCertificatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSigningCertificatesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListSigningCertificates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSigningCertificates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListSSHPublicKeysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSSHPublicKeysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSSHPublicKeysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSSHPublicKeysResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListSSHPublicKeys(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSSHPublicKeys(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSSHPublicKeysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSSHPublicKeysRequest>();

            var response = InstantiateClassGenerator.Execute<ListSSHPublicKeysResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListSSHPublicKeys(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSSHPublicKeys(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListUserPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUserPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUserPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUserPoliciesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListUserPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUserPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUserPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUserPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListUserPoliciesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListUserPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUserPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListUsersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUsersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUsersResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListUsers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUsers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUsersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();

            var response = InstantiateClassGenerator.Execute<ListUsersResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListUsers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUsers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void ListVirtualMFADevicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVirtualMFADevicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVirtualMFADevicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVirtualMFADevicesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListVirtualMFADevices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVirtualMFADevices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVirtualMFADevicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVirtualMFADevicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListVirtualMFADevicesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListVirtualMFADevices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVirtualMFADevices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void SimulateCustomPolicyTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SimulateCustomPolicyRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SimulateCustomPolicyResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SimulateCustomPolicyResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.SimulateCustomPolicy(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SimulateCustomPolicy(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SimulateCustomPolicyTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SimulateCustomPolicyRequest>();

            var response = InstantiateClassGenerator.Execute<SimulateCustomPolicyResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.SimulateCustomPolicy(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SimulateCustomPolicy(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        public void SimulatePrincipalPolicyTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SimulatePrincipalPolicyRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SimulatePrincipalPolicyResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SimulatePrincipalPolicyResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.SimulatePrincipalPolicy(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SimulatePrincipalPolicy(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SimulatePrincipalPolicyTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SimulatePrincipalPolicyRequest>();

            var response = InstantiateClassGenerator.Execute<SimulatePrincipalPolicyResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.SimulatePrincipalPolicy(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SimulatePrincipalPolicy(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif