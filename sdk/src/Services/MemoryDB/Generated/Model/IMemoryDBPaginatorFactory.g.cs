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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Paginators for the MemoryDB service
    /// </summary>
    public interface IMemoryDBPaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeACLs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeACLsPaginator DescribeACLs(DescribeACLsRequest request);

        /// <summary>
        /// Paginator for DescribeClusters operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeClustersPaginator DescribeClusters(DescribeClustersRequest request);

        /// <summary>
        /// Paginator for DescribeEngineVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeEngineVersionsPaginator DescribeEngineVersions(DescribeEngineVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeMultiRegionClusters operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeMultiRegionClustersPaginator DescribeMultiRegionClusters(DescribeMultiRegionClustersRequest request);

        /// <summary>
        /// Paginator for DescribeParameterGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeParameterGroupsPaginator DescribeParameterGroups(DescribeParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeParameters operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeParametersPaginator DescribeParameters(DescribeParametersRequest request);

        /// <summary>
        /// Paginator for DescribeReservedNodes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeReservedNodesPaginator DescribeReservedNodes(DescribeReservedNodesRequest request);

        /// <summary>
        /// Paginator for DescribeReservedNodesOfferings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeReservedNodesOfferingsPaginator DescribeReservedNodesOfferings(DescribeReservedNodesOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeServiceUpdates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeServiceUpdatesPaginator DescribeServiceUpdates(DescribeServiceUpdatesRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshots operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeSnapshotsPaginator DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeSubnetGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeSubnetGroupsPaginator DescribeSubnetGroups(DescribeSubnetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeUsers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeUsersPaginator DescribeUsers(DescribeUsersRequest request);
    }
}
