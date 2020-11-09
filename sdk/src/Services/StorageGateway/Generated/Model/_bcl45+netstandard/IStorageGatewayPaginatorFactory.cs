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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Paginators for the StorageGateway service
    ///</summary>
    public interface IStorageGatewayPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeTapeArchives operation
        ///</summary>
        IDescribeTapeArchivesPaginator DescribeTapeArchives(DescribeTapeArchivesRequest request);

        /// <summary>
        /// Paginator for DescribeTapeRecoveryPoints operation
        ///</summary>
        IDescribeTapeRecoveryPointsPaginator DescribeTapeRecoveryPoints(DescribeTapeRecoveryPointsRequest request);

        /// <summary>
        /// Paginator for DescribeTapes operation
        ///</summary>
        IDescribeTapesPaginator DescribeTapes(DescribeTapesRequest request);

        /// <summary>
        /// Paginator for DescribeVTLDevices operation
        ///</summary>
        IDescribeVTLDevicesPaginator DescribeVTLDevices(DescribeVTLDevicesRequest request);

        /// <summary>
        /// Paginator for ListFileShares operation
        ///</summary>
        IListFileSharesPaginator ListFileShares(ListFileSharesRequest request);

        /// <summary>
        /// Paginator for ListGateways operation
        ///</summary>
        IListGatewaysPaginator ListGateways(ListGatewaysRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListTapePools operation
        ///</summary>
        IListTapePoolsPaginator ListTapePools(ListTapePoolsRequest request);

        /// <summary>
        /// Paginator for ListTapes operation
        ///</summary>
        IListTapesPaginator ListTapes(ListTapesRequest request);

        /// <summary>
        /// Paginator for ListVolumes operation
        ///</summary>
        IListVolumesPaginator ListVolumes(ListVolumesRequest request);
    }
}
#endif