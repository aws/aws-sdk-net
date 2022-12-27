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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Paginators for the MemoryDB service
    ///</summary>
    public interface IMemoryDBPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeACLs operation
        ///</summary>
        IDescribeACLsPaginator DescribeACLs(DescribeACLsRequest request);

        /// <summary>
        /// Paginator for DescribeClusters operation
        ///</summary>
        IDescribeClustersPaginator DescribeClusters(DescribeClustersRequest request);

        /// <summary>
        /// Paginator for DescribeEngineVersions operation
        ///</summary>
        IDescribeEngineVersionsPaginator DescribeEngineVersions(DescribeEngineVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeParameterGroups operation
        ///</summary>
        IDescribeParameterGroupsPaginator DescribeParameterGroups(DescribeParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeParameters operation
        ///</summary>
        IDescribeParametersPaginator DescribeParameters(DescribeParametersRequest request);

        /// <summary>
        /// Paginator for DescribeReservedNodes operation
        ///</summary>
        IDescribeReservedNodesPaginator DescribeReservedNodes(DescribeReservedNodesRequest request);

        /// <summary>
        /// Paginator for DescribeReservedNodesOfferings operation
        ///</summary>
        IDescribeReservedNodesOfferingsPaginator DescribeReservedNodesOfferings(DescribeReservedNodesOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeServiceUpdates operation
        ///</summary>
        IDescribeServiceUpdatesPaginator DescribeServiceUpdates(DescribeServiceUpdatesRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshots operation
        ///</summary>
        IDescribeSnapshotsPaginator DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeSubnetGroups operation
        ///</summary>
        IDescribeSubnetGroupsPaginator DescribeSubnetGroups(DescribeSubnetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeUsers operation
        ///</summary>
        IDescribeUsersPaginator DescribeUsers(DescribeUsersRequest request);
    }
}