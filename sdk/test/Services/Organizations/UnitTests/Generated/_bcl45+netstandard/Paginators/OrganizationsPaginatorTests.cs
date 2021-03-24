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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */

using Amazon.Organizations;
using Amazon.Organizations.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class OrganizationsPaginatorTests
    {
        private static Mock<AmazonOrganizationsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonOrganizationsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
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
        [TestCategory("Organizations")]
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
        [TestCategory("Organizations")]
        public void ListAccountsForParentTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountsForParentRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccountsForParentResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccountsForParentResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccountsForParent(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccountsForParent(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccountsForParentTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountsForParentRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccountsForParentResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccountsForParent(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccountsForParent(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        public void ListAWSServiceAccessForOrganizationTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAWSServiceAccessForOrganizationRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAWSServiceAccessForOrganizationResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAWSServiceAccessForOrganizationResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAWSServiceAccessForOrganization(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAWSServiceAccessForOrganization(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAWSServiceAccessForOrganizationTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAWSServiceAccessForOrganizationRequest>();

            var response = InstantiateClassGenerator.Execute<ListAWSServiceAccessForOrganizationResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAWSServiceAccessForOrganization(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAWSServiceAccessForOrganization(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        public void ListChildrenTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListChildrenRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListChildrenResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListChildrenResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListChildren(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListChildren(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListChildrenTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListChildrenRequest>();

            var response = InstantiateClassGenerator.Execute<ListChildrenResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListChildren(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListChildren(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        public void ListCreateAccountStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCreateAccountStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCreateAccountStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCreateAccountStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCreateAccountStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCreateAccountStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCreateAccountStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCreateAccountStatusRequest>();

            var response = InstantiateClassGenerator.Execute<ListCreateAccountStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCreateAccountStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCreateAccountStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        public void ListDelegatedAdministratorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDelegatedAdministratorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDelegatedAdministratorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDelegatedAdministratorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDelegatedAdministrators(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDelegatedAdministrators(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDelegatedAdministratorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDelegatedAdministratorsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDelegatedAdministratorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDelegatedAdministrators(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDelegatedAdministrators(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        public void ListDelegatedServicesForAccountTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDelegatedServicesForAccountRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDelegatedServicesForAccountResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDelegatedServicesForAccountResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDelegatedServicesForAccount(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDelegatedServicesForAccount(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDelegatedServicesForAccountTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDelegatedServicesForAccountRequest>();

            var response = InstantiateClassGenerator.Execute<ListDelegatedServicesForAccountResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDelegatedServicesForAccount(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDelegatedServicesForAccount(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        public void ListHandshakesForAccountTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListHandshakesForAccountRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListHandshakesForAccountResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListHandshakesForAccountResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListHandshakesForAccount(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListHandshakesForAccount(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListHandshakesForAccountTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListHandshakesForAccountRequest>();

            var response = InstantiateClassGenerator.Execute<ListHandshakesForAccountResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListHandshakesForAccount(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListHandshakesForAccount(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        public void ListHandshakesForOrganizationTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListHandshakesForOrganizationRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListHandshakesForOrganizationResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListHandshakesForOrganizationResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListHandshakesForOrganization(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListHandshakesForOrganization(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListHandshakesForOrganizationTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListHandshakesForOrganizationRequest>();

            var response = InstantiateClassGenerator.Execute<ListHandshakesForOrganizationResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListHandshakesForOrganization(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListHandshakesForOrganization(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        public void ListOrganizationalUnitsForParentTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOrganizationalUnitsForParentRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOrganizationalUnitsForParentResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOrganizationalUnitsForParentResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOrganizationalUnitsForParent(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOrganizationalUnitsForParent(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOrganizationalUnitsForParentTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOrganizationalUnitsForParentRequest>();

            var response = InstantiateClassGenerator.Execute<ListOrganizationalUnitsForParentResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOrganizationalUnitsForParent(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOrganizationalUnitsForParent(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        public void ListParentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListParentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListParentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListParentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListParents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListParents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListParentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListParentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListParentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListParents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListParents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        public void ListPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPoliciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListPoliciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        public void ListPoliciesForTargetTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPoliciesForTargetRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPoliciesForTargetResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPoliciesForTargetResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPoliciesForTarget(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPoliciesForTarget(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPoliciesForTargetTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPoliciesForTargetRequest>();

            var response = InstantiateClassGenerator.Execute<ListPoliciesForTargetResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPoliciesForTarget(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPoliciesForTarget(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        public void ListRootsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRootsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRootsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRootsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRoots(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRoots(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRootsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRootsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRootsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRoots(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRoots(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        public void ListTagsForResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTagsForResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsForResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTagsForResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        public void ListTargetsForPolicyTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTargetsForPolicyRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTargetsForPolicyResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTargetsForPolicyResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTargetsForPolicy(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTargetsForPolicy(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Organizations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTargetsForPolicyTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTargetsForPolicyRequest>();

            var response = InstantiateClassGenerator.Execute<ListTargetsForPolicyResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTargetsForPolicy(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTargetsForPolicy(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}