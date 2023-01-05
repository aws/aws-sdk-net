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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Paginators for the MemoryDB service
    ///</summary>
    public class MemoryDBPaginatorFactory : IMemoryDBPaginatorFactory
    {
        private readonly IAmazonMemoryDB client;

        internal MemoryDBPaginatorFactory(IAmazonMemoryDB client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeACLs operation
        ///</summary>
        public IDescribeACLsPaginator DescribeACLs(DescribeACLsRequest request) 
        {
            return new DescribeACLsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClusters operation
        ///</summary>
        public IDescribeClustersPaginator DescribeClusters(DescribeClustersRequest request) 
        {
            return new DescribeClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEngineVersions operation
        ///</summary>
        public IDescribeEngineVersionsPaginator DescribeEngineVersions(DescribeEngineVersionsRequest request) 
        {
            return new DescribeEngineVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        public IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request) 
        {
            return new DescribeEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeParameterGroups operation
        ///</summary>
        public IDescribeParameterGroupsPaginator DescribeParameterGroups(DescribeParameterGroupsRequest request) 
        {
            return new DescribeParameterGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeParameters operation
        ///</summary>
        public IDescribeParametersPaginator DescribeParameters(DescribeParametersRequest request) 
        {
            return new DescribeParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedNodes operation
        ///</summary>
        public IDescribeReservedNodesPaginator DescribeReservedNodes(DescribeReservedNodesRequest request) 
        {
            return new DescribeReservedNodesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedNodesOfferings operation
        ///</summary>
        public IDescribeReservedNodesOfferingsPaginator DescribeReservedNodesOfferings(DescribeReservedNodesOfferingsRequest request) 
        {
            return new DescribeReservedNodesOfferingsPaginator(this.client, request);
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
        /// Paginator for DescribeSubnetGroups operation
        ///</summary>
        public IDescribeSubnetGroupsPaginator DescribeSubnetGroups(DescribeSubnetGroupsRequest request) 
        {
            return new DescribeSubnetGroupsPaginator(this.client, request);
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