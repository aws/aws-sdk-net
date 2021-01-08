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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */

using Amazon.Redshift;
using Amazon.Redshift.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class RedshiftPaginatorTests
    {
        private static Mock<AmazonRedshiftClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonRedshiftClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeClusterDbRevisionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterDbRevisionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClusterDbRevisionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClusterDbRevisionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeClusterDbRevisions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClusterDbRevisions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClusterDbRevisionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterDbRevisionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClusterDbRevisionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeClusterDbRevisions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClusterDbRevisions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeClusterParameterGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterParameterGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClusterParameterGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClusterParameterGroupsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeClusterParameterGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClusterParameterGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClusterParameterGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterParameterGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClusterParameterGroupsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeClusterParameterGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClusterParameterGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeClusterParametersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterParametersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClusterParametersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClusterParametersResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeClusterParameters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClusterParameters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClusterParametersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterParametersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClusterParametersResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeClusterParameters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClusterParameters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeClustersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClustersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClustersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClustersResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeClusters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClusters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClustersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClustersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClustersResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeClusters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClusters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeClusterSecurityGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterSecurityGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClusterSecurityGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClusterSecurityGroupsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeClusterSecurityGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClusterSecurityGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClusterSecurityGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterSecurityGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClusterSecurityGroupsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeClusterSecurityGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClusterSecurityGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeClusterSnapshotsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterSnapshotsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClusterSnapshotsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClusterSnapshotsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeClusterSnapshots(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClusterSnapshots(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClusterSnapshotsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterSnapshotsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClusterSnapshotsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeClusterSnapshots(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClusterSnapshots(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeClusterSubnetGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterSubnetGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClusterSubnetGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClusterSubnetGroupsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeClusterSubnetGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClusterSubnetGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClusterSubnetGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterSubnetGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClusterSubnetGroupsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeClusterSubnetGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClusterSubnetGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeClusterTracksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterTracksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClusterTracksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClusterTracksResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeClusterTracks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClusterTracks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClusterTracksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterTracksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClusterTracksResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeClusterTracks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClusterTracks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeClusterVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClusterVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClusterVersionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeClusterVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClusterVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClusterVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClusterVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClusterVersionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeClusterVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClusterVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeDefaultClusterParametersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDefaultClusterParametersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDefaultClusterParametersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDefaultClusterParametersResponse>();
            secondResponse.DefaultClusterParameters.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeDefaultClusterParameters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDefaultClusterParameters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDefaultClusterParametersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDefaultClusterParametersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDefaultClusterParametersResponse>();
            response.DefaultClusterParameters.Marker = null;

            _mockClient.Setup(x => x.DescribeDefaultClusterParameters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDefaultClusterParameters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeEventSubscriptionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeEventSubscriptions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEventSubscriptions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEventSubscriptionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeEventSubscriptions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEventSubscriptions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeHsmClientCertificatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeHsmClientCertificatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeHsmClientCertificatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeHsmClientCertificatesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeHsmClientCertificates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeHsmClientCertificates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeHsmClientCertificatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeHsmClientCertificatesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeHsmClientCertificatesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeHsmClientCertificates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeHsmClientCertificates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeHsmConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeHsmConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeHsmConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeHsmConfigurationsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeHsmConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeHsmConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeHsmConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeHsmConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeHsmConfigurationsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeHsmConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeHsmConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeNodeConfigurationOptionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNodeConfigurationOptionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeNodeConfigurationOptionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeNodeConfigurationOptionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeNodeConfigurationOptions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeNodeConfigurationOptions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeNodeConfigurationOptionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNodeConfigurationOptionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeNodeConfigurationOptionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeNodeConfigurationOptions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeNodeConfigurationOptions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeOrderableClusterOptionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrderableClusterOptionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeOrderableClusterOptionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeOrderableClusterOptionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeOrderableClusterOptions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeOrderableClusterOptions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeOrderableClusterOptionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrderableClusterOptionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeOrderableClusterOptionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeOrderableClusterOptions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeOrderableClusterOptions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodeOfferingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedNodeOfferingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReservedNodeOfferingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReservedNodeOfferingsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeReservedNodeOfferings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReservedNodeOfferings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReservedNodeOfferingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedNodeOfferingsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReservedNodeOfferingsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeReservedNodeOfferings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReservedNodeOfferings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedNodesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReservedNodesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReservedNodesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeReservedNodes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReservedNodes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReservedNodesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedNodesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReservedNodesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeReservedNodes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReservedNodes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeScheduledActionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScheduledActionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeScheduledActionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeScheduledActionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeScheduledActions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeScheduledActions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeScheduledActionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScheduledActionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeScheduledActionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeScheduledActions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeScheduledActions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeSnapshotCopyGrantsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSnapshotCopyGrantsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeSnapshotCopyGrantsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeSnapshotCopyGrantsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeSnapshotCopyGrants(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSnapshotCopyGrants(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeSnapshotCopyGrantsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSnapshotCopyGrantsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeSnapshotCopyGrantsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeSnapshotCopyGrants(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSnapshotCopyGrants(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeSnapshotSchedulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSnapshotSchedulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeSnapshotSchedulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeSnapshotSchedulesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeSnapshotSchedules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSnapshotSchedules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeSnapshotSchedulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSnapshotSchedulesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeSnapshotSchedulesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeSnapshotSchedules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSnapshotSchedules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeTableRestoreStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTableRestoreStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTableRestoreStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTableRestoreStatusResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeTableRestoreStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTableRestoreStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTableRestoreStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTableRestoreStatusRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTableRestoreStatusResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeTableRestoreStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTableRestoreStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeTagsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTagsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTagsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeTags(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTags(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTagsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTagsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeTags(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTags(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void DescribeUsageLimitsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeUsageLimitsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeUsageLimitsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeUsageLimitsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeUsageLimits(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeUsageLimits(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeUsageLimitsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeUsageLimitsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeUsageLimitsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeUsageLimits(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeUsageLimits(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        public void GetReservedNodeExchangeOfferingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeOfferingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetReservedNodeExchangeOfferingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetReservedNodeExchangeOfferingsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.GetReservedNodeExchangeOfferings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetReservedNodeExchangeOfferings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Redshift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetReservedNodeExchangeOfferingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetReservedNodeExchangeOfferingsRequest>();

            var response = InstantiateClassGenerator.Execute<GetReservedNodeExchangeOfferingsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.GetReservedNodeExchangeOfferings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetReservedNodeExchangeOfferings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif