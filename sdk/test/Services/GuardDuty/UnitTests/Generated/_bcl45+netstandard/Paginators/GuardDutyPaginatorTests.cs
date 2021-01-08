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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */

using Amazon.GuardDuty;
using Amazon.GuardDuty.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class GuardDutyPaginatorTests
    {
        private static Mock<AmazonGuardDutyClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonGuardDutyClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
        public void GetUsageStatisticsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetUsageStatisticsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetUsageStatisticsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetUsageStatisticsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetUsageStatistics(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetUsageStatistics(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetUsageStatisticsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetUsageStatisticsRequest>();

            var response = InstantiateClassGenerator.Execute<GetUsageStatisticsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetUsageStatistics(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetUsageStatistics(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
        public void ListDetectorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDetectorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDetectorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDetectorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDetectors(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDetectors(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDetectorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDetectorsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDetectorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDetectors(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDetectors(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
        public void ListFiltersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFiltersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFiltersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFiltersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFilters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFilters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFiltersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFiltersRequest>();

            var response = InstantiateClassGenerator.Execute<ListFiltersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFilters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFilters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
        public void ListFindingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFindingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFindingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFindingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFindings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFindings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFindingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFindingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListFindingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFindings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFindings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
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
        [TestCategory("GuardDuty")]
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
        [TestCategory("GuardDuty")]
        public void ListIPSetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListIPSetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListIPSetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListIPSetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListIPSets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListIPSets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListIPSetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListIPSetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListIPSetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListIPSets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListIPSets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
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
        [TestCategory("GuardDuty")]
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
        [TestCategory("GuardDuty")]
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
        [TestCategory("GuardDuty")]
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


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
        public void ListPublishingDestinationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPublishingDestinationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPublishingDestinationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPublishingDestinationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPublishingDestinations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPublishingDestinations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPublishingDestinationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPublishingDestinationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPublishingDestinationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPublishingDestinations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPublishingDestinations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
        public void ListThreatIntelSetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListThreatIntelSetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListThreatIntelSetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListThreatIntelSetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListThreatIntelSets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListThreatIntelSets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GuardDuty")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListThreatIntelSetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListThreatIntelSetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListThreatIntelSetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListThreatIntelSets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListThreatIntelSets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif