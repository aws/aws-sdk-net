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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */

using Amazon.Macie2;
using Amazon.Macie2.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class Macie2PaginatorTests
    {
        private static Mock<AmazonMacie2Client> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMacie2Client>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Macie2")]
        public void DescribeBucketsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeBucketsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeBucketsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeBucketsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeBuckets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeBuckets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Macie2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeBucketsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeBucketsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeBucketsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeBuckets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeBuckets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Macie2")]
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
        [TestCategory("Macie2")]
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
        [TestCategory("Macie2")]
        public void ListClassificationJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListClassificationJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListClassificationJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListClassificationJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListClassificationJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListClassificationJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Macie2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListClassificationJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListClassificationJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListClassificationJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListClassificationJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListClassificationJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Macie2")]
        public void ListCustomDataIdentifiersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomDataIdentifiersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCustomDataIdentifiersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCustomDataIdentifiersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCustomDataIdentifiers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCustomDataIdentifiers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Macie2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCustomDataIdentifiersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomDataIdentifiersRequest>();

            var response = InstantiateClassGenerator.Execute<ListCustomDataIdentifiersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCustomDataIdentifiers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCustomDataIdentifiers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Macie2")]
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
        [TestCategory("Macie2")]
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
        [TestCategory("Macie2")]
        public void ListFindingsFiltersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFindingsFiltersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFindingsFiltersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFindingsFiltersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFindingsFilters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFindingsFilters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Macie2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFindingsFiltersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFindingsFiltersRequest>();

            var response = InstantiateClassGenerator.Execute<ListFindingsFiltersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFindingsFilters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFindingsFilters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Macie2")]
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
        [TestCategory("Macie2")]
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
        [TestCategory("Macie2")]
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
        [TestCategory("Macie2")]
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
        [TestCategory("Macie2")]
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
        [TestCategory("Macie2")]
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