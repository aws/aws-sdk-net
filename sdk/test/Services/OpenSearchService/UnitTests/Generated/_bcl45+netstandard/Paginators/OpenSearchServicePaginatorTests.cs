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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */

using Amazon.OpenSearchService;
using Amazon.OpenSearchService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class OpenSearchServicePaginatorTests
    {
        private static Mock<AmazonOpenSearchServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonOpenSearchServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        public void DescribeDomainAutoTunesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDomainAutoTunesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDomainAutoTunesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDomainAutoTunesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeDomainAutoTunes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDomainAutoTunes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDomainAutoTunesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDomainAutoTunesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDomainAutoTunesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeDomainAutoTunes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDomainAutoTunes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        public void DescribeInboundConnectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInboundConnectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInboundConnectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInboundConnectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInboundConnections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInboundConnections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInboundConnectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInboundConnectionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInboundConnectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInboundConnections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInboundConnections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        public void DescribeOutboundConnectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOutboundConnectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeOutboundConnectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeOutboundConnectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeOutboundConnections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeOutboundConnections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeOutboundConnectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOutboundConnectionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeOutboundConnectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeOutboundConnections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeOutboundConnections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        public void DescribePackagesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribePackagesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribePackagesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribePackagesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribePackages(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribePackages(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribePackagesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribePackagesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribePackagesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribePackages(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribePackages(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        public void DescribeReservedInstanceOfferingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedInstanceOfferingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReservedInstanceOfferingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReservedInstanceOfferingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeReservedInstanceOfferings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReservedInstanceOfferings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReservedInstanceOfferingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedInstanceOfferingsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReservedInstanceOfferingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeReservedInstanceOfferings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReservedInstanceOfferings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        public void DescribeReservedInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReservedInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReservedInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeReservedInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReservedInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReservedInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReservedInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeReservedInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReservedInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        public void GetPackageVersionHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetPackageVersionHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetPackageVersionHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetPackageVersionHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetPackageVersionHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetPackageVersionHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetPackageVersionHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetPackageVersionHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<GetPackageVersionHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetPackageVersionHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetPackageVersionHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        public void GetUpgradeHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetUpgradeHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetUpgradeHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetUpgradeHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetUpgradeHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetUpgradeHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetUpgradeHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetUpgradeHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<GetUpgradeHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetUpgradeHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetUpgradeHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        public void ListDomainsForPackageTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainsForPackageRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDomainsForPackageResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDomainsForPackageResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDomainsForPackage(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDomainsForPackage(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDomainsForPackageTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainsForPackageRequest>();

            var response = InstantiateClassGenerator.Execute<ListDomainsForPackageResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDomainsForPackage(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDomainsForPackage(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        public void ListInstanceTypeDetailsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInstanceTypeDetailsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInstanceTypeDetailsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInstanceTypeDetailsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInstanceTypeDetails(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInstanceTypeDetails(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInstanceTypeDetailsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInstanceTypeDetailsRequest>();

            var response = InstantiateClassGenerator.Execute<ListInstanceTypeDetailsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInstanceTypeDetails(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInstanceTypeDetails(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        public void ListPackagesForDomainTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPackagesForDomainRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPackagesForDomainResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPackagesForDomainResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPackagesForDomain(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPackagesForDomain(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPackagesForDomainTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPackagesForDomainRequest>();

            var response = InstantiateClassGenerator.Execute<ListPackagesForDomainResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPackagesForDomain(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPackagesForDomain(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        public void ListVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("OpenSearchService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}