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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */

using Amazon.SecurityHub;
using Amazon.SecurityHub.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SecurityHubPaginatorTests
    {
        private static Mock<AmazonSecurityHubClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSecurityHubClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        public void DescribeActionTargetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeActionTargetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeActionTargetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeActionTargetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeActionTargets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeActionTargets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeActionTargetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeActionTargetsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeActionTargetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeActionTargets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeActionTargets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        public void DescribeProductsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeProductsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeProductsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeProductsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeProducts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeProducts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeProductsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeProductsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeProductsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeProducts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeProducts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        public void DescribeStandardsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStandardsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeStandardsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeStandardsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeStandards(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeStandards(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeStandardsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStandardsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeStandardsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeStandards(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeStandards(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        public void DescribeStandardsControlsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStandardsControlsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeStandardsControlsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeStandardsControlsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeStandardsControls(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeStandardsControls(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeStandardsControlsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStandardsControlsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeStandardsControlsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeStandardsControls(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeStandardsControls(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        public void GetEnabledStandardsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetEnabledStandardsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetEnabledStandardsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetEnabledStandardsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetEnabledStandards(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetEnabledStandards(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetEnabledStandardsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetEnabledStandardsRequest>();

            var response = InstantiateClassGenerator.Execute<GetEnabledStandardsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetEnabledStandards(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetEnabledStandards(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        public void GetFindingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetFindingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetFindingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetFindingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetFindings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetFindings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetFindingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetFindingsRequest>();

            var response = InstantiateClassGenerator.Execute<GetFindingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetFindings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetFindings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        public void GetInsightsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetInsightsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetInsightsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetInsightsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetInsights(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetInsights(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetInsightsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetInsightsRequest>();

            var response = InstantiateClassGenerator.Execute<GetInsightsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetInsights(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetInsights(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        public void ListEnabledProductsForImportTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEnabledProductsForImportRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEnabledProductsForImportResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEnabledProductsForImportResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEnabledProductsForImport(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEnabledProductsForImport(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEnabledProductsForImportTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEnabledProductsForImportRequest>();

            var response = InstantiateClassGenerator.Execute<ListEnabledProductsForImportResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEnabledProductsForImport(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEnabledProductsForImport(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        public void ListInvitationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInvitationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInvitationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInvitationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInvitations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInvitations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInvitationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInvitationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListInvitationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInvitations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInvitations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        public void ListMembersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMembersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMembersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMembersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMembers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMembers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMembersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMembersRequest>();

            var response = InstantiateClassGenerator.Execute<ListMembersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMembers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMembers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        public void ListOrganizationAdminAccountsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOrganizationAdminAccountsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOrganizationAdminAccountsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOrganizationAdminAccountsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOrganizationAdminAccounts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOrganizationAdminAccounts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecurityHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOrganizationAdminAccountsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOrganizationAdminAccountsRequest>();

            var response = InstantiateClassGenerator.Execute<ListOrganizationAdminAccountsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOrganizationAdminAccounts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOrganizationAdminAccounts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif