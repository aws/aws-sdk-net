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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeCacheClustersPaginator DescribeCacheClusters(DescribeCacheClustersRequest request);

        /// <summary>
        /// Paginator for DescribeCacheEngineVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeCacheEngineVersionsPaginator DescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeCacheParameterGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeCacheParameterGroupsPaginator DescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeCacheParameters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeCacheParametersPaginator DescribeCacheParameters(DescribeCacheParametersRequest request);

        /// <summary>
        /// Paginator for DescribeCacheSecurityGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeCacheSecurityGroupsPaginator DescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeCacheSubnetGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeCacheSubnetGroupsPaginator DescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeEngineDefaultParameters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "EngineDefaults.Marker" }
        )]
        IDescribeEngineDefaultParametersPaginator DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeGlobalReplicationGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeGlobalReplicationGroupsPaginator DescribeGlobalReplicationGroups(DescribeGlobalReplicationGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReplicationGroupsPaginator DescribeReplicationGroups(DescribeReplicationGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeReservedCacheNodes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReservedCacheNodesPaginator DescribeReservedCacheNodes(DescribeReservedCacheNodesRequest request);

        /// <summary>
        /// Paginator for DescribeReservedCacheNodesOfferings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReservedCacheNodesOfferingsPaginator DescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeServerlessCaches operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeServerlessCachesPaginator DescribeServerlessCaches(DescribeServerlessCachesRequest request);

        /// <summary>
        /// Paginator for DescribeServerlessCacheSnapshots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeServerlessCacheSnapshotsPaginator DescribeServerlessCacheSnapshots(DescribeServerlessCacheSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeServiceUpdates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeServiceUpdatesPaginator DescribeServiceUpdates(DescribeServiceUpdatesRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeSnapshotsPaginator DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeUpdateActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeUpdateActionsPaginator DescribeUpdateActions(DescribeUpdateActionsRequest request);

        /// <summary>
        /// Paginator for DescribeUserGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeUserGroupsPaginator DescribeUserGroups(DescribeUserGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeUsers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeUsersPaginator DescribeUsers(DescribeUsersRequest request);
    }
}