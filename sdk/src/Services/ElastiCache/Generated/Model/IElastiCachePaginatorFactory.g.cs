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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Paginators for the ElastiCache service
    /// </summary>
    public interface IElastiCachePaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeCacheClusters operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeCacheClustersPaginator DescribeCacheClusters(DescribeCacheClustersRequest request);

        /// <summary>
        /// Paginator for DescribeCacheEngineVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeCacheEngineVersionsPaginator DescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeCacheParameterGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeCacheParameterGroupsPaginator DescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeCacheParameters operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeCacheParametersPaginator DescribeCacheParameters(DescribeCacheParametersRequest request);

        /// <summary>
        /// Paginator for DescribeCacheSecurityGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeCacheSecurityGroupsPaginator DescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeCacheSubnetGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeCacheSubnetGroupsPaginator DescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeEngineDefaultParameters operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["EngineDefaults.Marker"])]
        IDescribeEngineDefaultParametersPaginator DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeGlobalReplicationGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeGlobalReplicationGroupsPaginator DescribeGlobalReplicationGroups(DescribeGlobalReplicationGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeReplicationGroupsPaginator DescribeReplicationGroups(DescribeReplicationGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeReservedCacheNodes operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeReservedCacheNodesPaginator DescribeReservedCacheNodes(DescribeReservedCacheNodesRequest request);

        /// <summary>
        /// Paginator for DescribeReservedCacheNodesOfferings operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeReservedCacheNodesOfferingsPaginator DescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeServerlessCacheSnapshots operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeServerlessCacheSnapshotsPaginator DescribeServerlessCacheSnapshots(DescribeServerlessCacheSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeServerlessCaches operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeServerlessCachesPaginator DescribeServerlessCaches(DescribeServerlessCachesRequest request);

        /// <summary>
        /// Paginator for DescribeServiceUpdates operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeServiceUpdatesPaginator DescribeServiceUpdates(DescribeServiceUpdatesRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshots operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeSnapshotsPaginator DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeUpdateActions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeUpdateActionsPaginator DescribeUpdateActions(DescribeUpdateActionsRequest request);

        /// <summary>
        /// Paginator for DescribeUserGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeUserGroupsPaginator DescribeUserGroups(DescribeUserGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeUsers operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxRecords", OutputToken = ["Marker"])]
        IDescribeUsersPaginator DescribeUsers(DescribeUsersRequest request);
    }
}
