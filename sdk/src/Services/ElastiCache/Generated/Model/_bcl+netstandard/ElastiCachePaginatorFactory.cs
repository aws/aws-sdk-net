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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Paginators for the ElastiCache service
    ///</summary>
    public class ElastiCachePaginatorFactory : IElastiCachePaginatorFactory
    {
        private readonly IAmazonElastiCache client;

        internal ElastiCachePaginatorFactory(IAmazonElastiCache client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeCacheClusters operation
        ///</summary>
        public IDescribeCacheClustersPaginator DescribeCacheClusters(DescribeCacheClustersRequest request) 
        {
            return new DescribeCacheClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeCacheEngineVersions operation
        ///</summary>
        public IDescribeCacheEngineVersionsPaginator DescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest request) 
        {
            return new DescribeCacheEngineVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeCacheParameterGroups operation
        ///</summary>
        public IDescribeCacheParameterGroupsPaginator DescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest request) 
        {
            return new DescribeCacheParameterGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeCacheParameters operation
        ///</summary>
        public IDescribeCacheParametersPaginator DescribeCacheParameters(DescribeCacheParametersRequest request) 
        {
            return new DescribeCacheParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeCacheSecurityGroups operation
        ///</summary>
        public IDescribeCacheSecurityGroupsPaginator DescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest request) 
        {
            return new DescribeCacheSecurityGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeCacheSubnetGroups operation
        ///</summary>
        public IDescribeCacheSubnetGroupsPaginator DescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest request) 
        {
            return new DescribeCacheSubnetGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEngineDefaultParameters operation
        ///</summary>
        public IDescribeEngineDefaultParametersPaginator DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request) 
        {
            return new DescribeEngineDefaultParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        public IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request) 
        {
            return new DescribeEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeGlobalReplicationGroups operation
        ///</summary>
        public IDescribeGlobalReplicationGroupsPaginator DescribeGlobalReplicationGroups(DescribeGlobalReplicationGroupsRequest request) 
        {
            return new DescribeGlobalReplicationGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplicationGroups operation
        ///</summary>
        public IDescribeReplicationGroupsPaginator DescribeReplicationGroups(DescribeReplicationGroupsRequest request) 
        {
            return new DescribeReplicationGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedCacheNodes operation
        ///</summary>
        public IDescribeReservedCacheNodesPaginator DescribeReservedCacheNodes(DescribeReservedCacheNodesRequest request) 
        {
            return new DescribeReservedCacheNodesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedCacheNodesOfferings operation
        ///</summary>
        public IDescribeReservedCacheNodesOfferingsPaginator DescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest request) 
        {
            return new DescribeReservedCacheNodesOfferingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeServerlessCaches operation
        ///</summary>
        public IDescribeServerlessCachesPaginator DescribeServerlessCaches(DescribeServerlessCachesRequest request) 
        {
            return new DescribeServerlessCachesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeServerlessCacheSnapshots operation
        ///</summary>
        public IDescribeServerlessCacheSnapshotsPaginator DescribeServerlessCacheSnapshots(DescribeServerlessCacheSnapshotsRequest request) 
        {
            return new DescribeServerlessCacheSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeServiceUpdates operation
        ///</summary>
        public IDescribeServiceUpdatesPaginator DescribeServiceUpdates(DescribeServiceUpdatesRequest request) 
        {
            return new DescribeServiceUpdatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSnapshots operation
        ///</summary>
        public IDescribeSnapshotsPaginator DescribeSnapshots(DescribeSnapshotsRequest request) 
        {
            return new DescribeSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeUpdateActions operation
        ///</summary>
        public IDescribeUpdateActionsPaginator DescribeUpdateActions(DescribeUpdateActionsRequest request) 
        {
            return new DescribeUpdateActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeUserGroups operation
        ///</summary>
        public IDescribeUserGroupsPaginator DescribeUserGroups(DescribeUserGroupsRequest request) 
        {
            return new DescribeUserGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeUsers operation
        ///</summary>
        public IDescribeUsersPaginator DescribeUsers(DescribeUsersRequest request) 
        {
            return new DescribeUsersPaginator(this.client, request);
        }
    }
}