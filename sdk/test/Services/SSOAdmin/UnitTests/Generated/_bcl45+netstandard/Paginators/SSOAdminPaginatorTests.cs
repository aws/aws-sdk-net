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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */

using Amazon.SSOAdmin;
using Amazon.SSOAdmin.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SSOAdminPaginatorTests
    {
        private static Mock<AmazonSSOAdminClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSSOAdminClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        public void ListAccountAssignmentCreationStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountAssignmentCreationStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccountAssignmentCreationStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccountAssignmentCreationStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccountAssignmentCreationStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccountAssignmentCreationStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccountAssignmentCreationStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountAssignmentCreationStatusRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccountAssignmentCreationStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccountAssignmentCreationStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccountAssignmentCreationStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        public void ListAccountAssignmentDeletionStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountAssignmentDeletionStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccountAssignmentDeletionStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccountAssignmentDeletionStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccountAssignmentDeletionStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccountAssignmentDeletionStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccountAssignmentDeletionStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountAssignmentDeletionStatusRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccountAssignmentDeletionStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccountAssignmentDeletionStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccountAssignmentDeletionStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        public void ListAccountAssignmentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountAssignmentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccountAssignmentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccountAssignmentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccountAssignments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccountAssignments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccountAssignmentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountAssignmentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccountAssignmentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccountAssignments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccountAssignments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        public void ListAccountsForProvisionedPermissionSetTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountsForProvisionedPermissionSetRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccountsForProvisionedPermissionSetResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccountsForProvisionedPermissionSetResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccountsForProvisionedPermissionSet(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccountsForProvisionedPermissionSet(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccountsForProvisionedPermissionSetTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountsForProvisionedPermissionSetRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccountsForProvisionedPermissionSetResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccountsForProvisionedPermissionSet(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccountsForProvisionedPermissionSet(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        public void ListInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        public void ListManagedPoliciesInPermissionSetTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListManagedPoliciesInPermissionSetRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListManagedPoliciesInPermissionSetResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListManagedPoliciesInPermissionSetResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListManagedPoliciesInPermissionSet(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListManagedPoliciesInPermissionSet(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListManagedPoliciesInPermissionSetTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListManagedPoliciesInPermissionSetRequest>();

            var response = InstantiateClassGenerator.Execute<ListManagedPoliciesInPermissionSetResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListManagedPoliciesInPermissionSet(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListManagedPoliciesInPermissionSet(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        public void ListPermissionSetProvisioningStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPermissionSetProvisioningStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPermissionSetProvisioningStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPermissionSetProvisioningStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPermissionSetProvisioningStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPermissionSetProvisioningStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPermissionSetProvisioningStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPermissionSetProvisioningStatusRequest>();

            var response = InstantiateClassGenerator.Execute<ListPermissionSetProvisioningStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPermissionSetProvisioningStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPermissionSetProvisioningStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        public void ListPermissionSetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPermissionSetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPermissionSetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPermissionSetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPermissionSets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPermissionSets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPermissionSetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPermissionSetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPermissionSetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPermissionSets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPermissionSets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        public void ListPermissionSetsProvisionedToAccountTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPermissionSetsProvisionedToAccountRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPermissionSetsProvisionedToAccountResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPermissionSetsProvisionedToAccountResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPermissionSetsProvisionedToAccount(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPermissionSetsProvisionedToAccount(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPermissionSetsProvisionedToAccountTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPermissionSetsProvisionedToAccountRequest>();

            var response = InstantiateClassGenerator.Execute<ListPermissionSetsProvisionedToAccountResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPermissionSetsProvisionedToAccount(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPermissionSetsProvisionedToAccount(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSOAdmin")]
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
        [TestCategory("SSOAdmin")]
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

    }
}
#endif