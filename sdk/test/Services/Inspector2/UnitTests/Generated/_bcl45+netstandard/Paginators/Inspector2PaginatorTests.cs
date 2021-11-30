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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */

using Amazon.Inspector2;
using Amazon.Inspector2.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class Inspector2PaginatorTests
    {
        private static Mock<AmazonInspector2Client> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonInspector2Client>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector2")]
        public void ListAccountPermissionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountPermissionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccountPermissionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccountPermissionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccountPermissions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccountPermissions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccountPermissionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountPermissionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccountPermissionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccountPermissions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccountPermissions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector2")]
        public void ListCoverageTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCoverageRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCoverageResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCoverageResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCoverage(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCoverage(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCoverageTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCoverageRequest>();

            var response = InstantiateClassGenerator.Execute<ListCoverageResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCoverage(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCoverage(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector2")]
        public void ListCoverageStatisticsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCoverageStatisticsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCoverageStatisticsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCoverageStatisticsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCoverageStatistics(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCoverageStatistics(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCoverageStatisticsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCoverageStatisticsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCoverageStatisticsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCoverageStatistics(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCoverageStatistics(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector2")]
        public void ListDelegatedAdminAccountsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDelegatedAdminAccountsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDelegatedAdminAccountsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDelegatedAdminAccountsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDelegatedAdminAccounts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDelegatedAdminAccounts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDelegatedAdminAccountsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDelegatedAdminAccountsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDelegatedAdminAccountsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDelegatedAdminAccounts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDelegatedAdminAccounts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector2")]
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
        [TestCategory("Inspector2")]
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
        [TestCategory("Inspector2")]
        public void ListFindingAggregationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFindingAggregationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFindingAggregationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFindingAggregationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFindingAggregations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFindingAggregations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFindingAggregationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFindingAggregationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListFindingAggregationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFindingAggregations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFindingAggregations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector2")]
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
        [TestCategory("Inspector2")]
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
        [TestCategory("Inspector2")]
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
        [TestCategory("Inspector2")]
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
        [TestCategory("Inspector2")]
        public void ListUsageTotalsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUsageTotalsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUsageTotalsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUsageTotalsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUsageTotals(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUsageTotals(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUsageTotalsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUsageTotalsRequest>();

            var response = InstantiateClassGenerator.Execute<ListUsageTotalsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUsageTotals(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUsageTotals(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}