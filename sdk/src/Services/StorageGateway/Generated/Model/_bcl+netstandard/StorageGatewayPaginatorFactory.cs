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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Paginators for the StorageGateway service
    ///</summary>
    public class StorageGatewayPaginatorFactory : IStorageGatewayPaginatorFactory
    {
        private readonly IAmazonStorageGateway client;

        internal StorageGatewayPaginatorFactory(IAmazonStorageGateway client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeTapeArchives operation
        ///</summary>
        public IDescribeTapeArchivesPaginator DescribeTapeArchives(DescribeTapeArchivesRequest request) 
        {
            return new DescribeTapeArchivesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTapeRecoveryPoints operation
        ///</summary>
        public IDescribeTapeRecoveryPointsPaginator DescribeTapeRecoveryPoints(DescribeTapeRecoveryPointsRequest request) 
        {
            return new DescribeTapeRecoveryPointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTapes operation
        ///</summary>
        public IDescribeTapesPaginator DescribeTapes(DescribeTapesRequest request) 
        {
            return new DescribeTapesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVTLDevices operation
        ///</summary>
        public IDescribeVTLDevicesPaginator DescribeVTLDevices(DescribeVTLDevicesRequest request) 
        {
            return new DescribeVTLDevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCacheReports operation
        ///</summary>
        public IListCacheReportsPaginator ListCacheReports(ListCacheReportsRequest request) 
        {
            return new ListCacheReportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFileShares operation
        ///</summary>
        public IListFileSharesPaginator ListFileShares(ListFileSharesRequest request) 
        {
            return new ListFileSharesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFileSystemAssociations operation
        ///</summary>
        public IListFileSystemAssociationsPaginator ListFileSystemAssociations(ListFileSystemAssociationsRequest request) 
        {
            return new ListFileSystemAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGateways operation
        ///</summary>
        public IListGatewaysPaginator ListGateways(ListGatewaysRequest request) 
        {
            return new ListGatewaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTapePools operation
        ///</summary>
        public IListTapePoolsPaginator ListTapePools(ListTapePoolsRequest request) 
        {
            return new ListTapePoolsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTapes operation
        ///</summary>
        public IListTapesPaginator ListTapes(ListTapesRequest request) 
        {
            return new ListTapesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVolumes operation
        ///</summary>
        public IListVolumesPaginator ListVolumes(ListVolumesRequest request) 
        {
            return new ListVolumesPaginator(this.client, request);
        }
    }
}