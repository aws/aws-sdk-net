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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */

using Amazon.ElastiCache;
using Amazon.ElastiCache.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ElastiCachePaginatorTests
    {
        private static Mock<AmazonElastiCacheClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonElastiCacheClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeCacheClustersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCacheClustersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCacheClustersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCacheClustersResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeCacheClusters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCacheClusters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCacheClustersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCacheClustersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCacheClustersResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeCacheClusters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCacheClusters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeCacheEngineVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCacheEngineVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCacheEngineVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCacheEngineVersionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeCacheEngineVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCacheEngineVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCacheEngineVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCacheEngineVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCacheEngineVersionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeCacheEngineVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCacheEngineVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeCacheParameterGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCacheParameterGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCacheParameterGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCacheParameterGroupsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeCacheParameterGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCacheParameterGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCacheParameterGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCacheParameterGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCacheParameterGroupsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeCacheParameterGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCacheParameterGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeCacheParametersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCacheParametersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCacheParametersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCacheParametersResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeCacheParameters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCacheParameters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCacheParametersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCacheParametersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCacheParametersResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeCacheParameters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCacheParameters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeCacheSecurityGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCacheSecurityGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCacheSecurityGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCacheSecurityGroupsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeCacheSecurityGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCacheSecurityGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCacheSecurityGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCacheSecurityGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCacheSecurityGroupsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeCacheSecurityGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCacheSecurityGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeCacheSubnetGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCacheSubnetGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCacheSubnetGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCacheSubnetGroupsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeCacheSubnetGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCacheSubnetGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCacheSubnetGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCacheSubnetGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCacheSubnetGroupsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeCacheSubnetGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCacheSubnetGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeEngineDefaultParametersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEngineDefaultParametersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEngineDefaultParametersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEngineDefaultParametersResponse>();
            secondResponse.EngineDefaults.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeEngineDefaultParameters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEngineDefaultParameters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEngineDefaultParametersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEngineDefaultParametersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEngineDefaultParametersResponse>();
            response.EngineDefaults.Marker = null;

            _mockClient.Setup(x => x.DescribeEngineDefaultParameters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEngineDefaultParameters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
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
        [TestCategory("ElastiCache")]
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
        [TestCategory("ElastiCache")]
        public void DescribeGlobalReplicationGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeGlobalReplicationGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeGlobalReplicationGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeGlobalReplicationGroupsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeGlobalReplicationGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeGlobalReplicationGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeGlobalReplicationGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeGlobalReplicationGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeGlobalReplicationGroupsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeGlobalReplicationGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeGlobalReplicationGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeReplicationGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReplicationGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReplicationGroupsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeReplicationGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReplicationGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReplicationGroupsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeReplicationGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeReservedCacheNodesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedCacheNodesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReservedCacheNodesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReservedCacheNodesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeReservedCacheNodes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReservedCacheNodes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReservedCacheNodesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedCacheNodesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReservedCacheNodesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeReservedCacheNodes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReservedCacheNodes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeReservedCacheNodesOfferingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedCacheNodesOfferingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReservedCacheNodesOfferingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReservedCacheNodesOfferingsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeReservedCacheNodesOfferings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReservedCacheNodesOfferings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReservedCacheNodesOfferingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedCacheNodesOfferingsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReservedCacheNodesOfferingsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeReservedCacheNodesOfferings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReservedCacheNodesOfferings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeServiceUpdatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeServiceUpdatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeServiceUpdatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeServiceUpdatesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeServiceUpdates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeServiceUpdates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeServiceUpdatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeServiceUpdatesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeServiceUpdatesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeServiceUpdates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeServiceUpdates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeSnapshotsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSnapshotsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeSnapshotsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeSnapshotsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeSnapshots(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSnapshots(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeSnapshotsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSnapshotsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeSnapshotsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeSnapshots(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSnapshots(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeUpdateActionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeUpdateActionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeUpdateActionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeUpdateActionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeUpdateActions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeUpdateActions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeUpdateActionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeUpdateActionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeUpdateActionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeUpdateActions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeUpdateActions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeUserGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeUserGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeUserGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeUserGroupsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeUserGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeUserGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeUserGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeUserGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeUserGroupsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeUserGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeUserGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        public void DescribeUsersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeUsersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeUsersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeUsersResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeUsers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeUsers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElastiCache")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeUsersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeUsersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeUsersResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeUsers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeUsers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif