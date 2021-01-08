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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Paginators for the ElastiCache service
    ///</summary>
    public interface IElastiCachePaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeCacheClusters operation
        ///</summary>
        IDescribeCacheClustersPaginator DescribeCacheClusters(DescribeCacheClustersRequest request);

        /// <summary>
        /// Paginator for DescribeCacheEngineVersions operation
        ///</summary>
        IDescribeCacheEngineVersionsPaginator DescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeCacheParameterGroups operation
        ///</summary>
        IDescribeCacheParameterGroupsPaginator DescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeCacheParameters operation
        ///</summary>
        IDescribeCacheParametersPaginator DescribeCacheParameters(DescribeCacheParametersRequest request);

        /// <summary>
        /// Paginator for DescribeCacheSecurityGroups operation
        ///</summary>
        IDescribeCacheSecurityGroupsPaginator DescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeCacheSubnetGroups operation
        ///</summary>
        IDescribeCacheSubnetGroupsPaginator DescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeEngineDefaultParameters operation
        ///</summary>
        IDescribeEngineDefaultParametersPaginator DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeGlobalReplicationGroups operation
        ///</summary>
        IDescribeGlobalReplicationGroupsPaginator DescribeGlobalReplicationGroups(DescribeGlobalReplicationGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationGroups operation
        ///</summary>
        IDescribeReplicationGroupsPaginator DescribeReplicationGroups(DescribeReplicationGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeReservedCacheNodes operation
        ///</summary>
        IDescribeReservedCacheNodesPaginator DescribeReservedCacheNodes(DescribeReservedCacheNodesRequest request);

        /// <summary>
        /// Paginator for DescribeReservedCacheNodesOfferings operation
        ///</summary>
        IDescribeReservedCacheNodesOfferingsPaginator DescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeServiceUpdates operation
        ///</summary>
        IDescribeServiceUpdatesPaginator DescribeServiceUpdates(DescribeServiceUpdatesRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshots operation
        ///</summary>
        IDescribeSnapshotsPaginator DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeUpdateActions operation
        ///</summary>
        IDescribeUpdateActionsPaginator DescribeUpdateActions(DescribeUpdateActionsRequest request);

        /// <summary>
        /// Paginator for DescribeUserGroups operation
        ///</summary>
        IDescribeUserGroupsPaginator DescribeUserGroups(DescribeUserGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeUsers operation
        ///</summary>
        IDescribeUsersPaginator DescribeUsers(DescribeUsersRequest request);
    }
}
#endif