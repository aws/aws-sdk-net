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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */

using Amazon.WorkMail;
using Amazon.WorkMail.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class WorkMailPaginatorTests
    {
        private static Mock<AmazonWorkMailClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonWorkMailClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
        public void ListAliasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAliasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAliasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAliasesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAliases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAliases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAliasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAliasesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAliasesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAliases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAliases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
        public void ListGroupMembersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupMembersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGroupMembersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGroupMembersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGroupMembers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGroupMembers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGroupMembersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupMembersRequest>();

            var response = InstantiateClassGenerator.Execute<ListGroupMembersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGroupMembers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGroupMembers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
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
        [TestCategory("WorkMail")]
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
        [TestCategory("WorkMail")]
        public void ListMailboxExportJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMailboxExportJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMailboxExportJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMailboxExportJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMailboxExportJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMailboxExportJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMailboxExportJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMailboxExportJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListMailboxExportJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMailboxExportJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMailboxExportJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
        public void ListMailboxPermissionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMailboxPermissionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMailboxPermissionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMailboxPermissionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMailboxPermissions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMailboxPermissions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMailboxPermissionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMailboxPermissionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListMailboxPermissionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMailboxPermissions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMailboxPermissions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
        public void ListOrganizationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOrganizationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOrganizationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOrganizationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOrganizations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOrganizations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOrganizationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOrganizationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListOrganizationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOrganizations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOrganizations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
        public void ListResourceDelegatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourceDelegatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourceDelegatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourceDelegatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResourceDelegates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResourceDelegates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourceDelegatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourceDelegatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourceDelegatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResourceDelegates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResourceDelegates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
        public void ListResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkMail")]
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
        [TestCategory("WorkMail")]
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

    }
}
#endif