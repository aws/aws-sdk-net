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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */

using Amazon.Elasticsearch;
using Amazon.Elasticsearch.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ElasticsearchPaginatorTests
    {
        private static Mock<AmazonElasticsearchClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonElasticsearchClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Elasticsearch")]
        public void DescribeInboundCrossClusterSearchConnectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInboundCrossClusterSearchConnectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInboundCrossClusterSearchConnectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInboundCrossClusterSearchConnectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInboundCrossClusterSearchConnections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInboundCrossClusterSearchConnections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Elasticsearch")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInboundCrossClusterSearchConnectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInboundCrossClusterSearchConnectionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInboundCrossClusterSearchConnectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInboundCrossClusterSearchConnections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInboundCrossClusterSearchConnections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Elasticsearch")]
        public void DescribeOutboundCrossClusterSearchConnectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOutboundCrossClusterSearchConnectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeOutboundCrossClusterSearchConnectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeOutboundCrossClusterSearchConnectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeOutboundCrossClusterSearchConnections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeOutboundCrossClusterSearchConnections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Elasticsearch")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeOutboundCrossClusterSearchConnectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOutboundCrossClusterSearchConnectionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeOutboundCrossClusterSearchConnectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeOutboundCrossClusterSearchConnections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeOutboundCrossClusterSearchConnections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Elasticsearch")]
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
        [TestCategory("Elasticsearch")]
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
        [TestCategory("Elasticsearch")]
        public void DescribeReservedElasticsearchInstanceOfferingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedElasticsearchInstanceOfferingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReservedElasticsearchInstanceOfferingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReservedElasticsearchInstanceOfferingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeReservedElasticsearchInstanceOfferings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReservedElasticsearchInstanceOfferings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Elasticsearch")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReservedElasticsearchInstanceOfferingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedElasticsearchInstanceOfferingsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReservedElasticsearchInstanceOfferingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeReservedElasticsearchInstanceOfferings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReservedElasticsearchInstanceOfferings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Elasticsearch")]
        public void DescribeReservedElasticsearchInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedElasticsearchInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReservedElasticsearchInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReservedElasticsearchInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeReservedElasticsearchInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReservedElasticsearchInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Elasticsearch")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReservedElasticsearchInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedElasticsearchInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReservedElasticsearchInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeReservedElasticsearchInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReservedElasticsearchInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Elasticsearch")]
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
        [TestCategory("Elasticsearch")]
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
        [TestCategory("Elasticsearch")]
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
        [TestCategory("Elasticsearch")]
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
        [TestCategory("Elasticsearch")]
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
        [TestCategory("Elasticsearch")]
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
        [TestCategory("Elasticsearch")]
        public void ListElasticsearchInstanceTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListElasticsearchInstanceTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListElasticsearchInstanceTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListElasticsearchInstanceTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListElasticsearchInstanceTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListElasticsearchInstanceTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Elasticsearch")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListElasticsearchInstanceTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListElasticsearchInstanceTypesRequest>();

            var response = InstantiateClassGenerator.Execute<ListElasticsearchInstanceTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListElasticsearchInstanceTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListElasticsearchInstanceTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Elasticsearch")]
        public void ListElasticsearchVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListElasticsearchVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListElasticsearchVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListElasticsearchVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListElasticsearchVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListElasticsearchVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Elasticsearch")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListElasticsearchVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListElasticsearchVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListElasticsearchVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListElasticsearchVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListElasticsearchVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Elasticsearch")]
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
        [TestCategory("Elasticsearch")]
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

    }
}
#endif