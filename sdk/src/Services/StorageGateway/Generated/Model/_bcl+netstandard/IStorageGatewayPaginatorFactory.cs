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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeTapeArchivesPaginator DescribeTapeArchives(DescribeTapeArchivesRequest request);

        /// <summary>
        /// Paginator for DescribeTapeRecoveryPoints operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeTapeRecoveryPointsPaginator DescribeTapeRecoveryPoints(DescribeTapeRecoveryPointsRequest request);

        /// <summary>
        /// Paginator for DescribeTapes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeTapesPaginator DescribeTapes(DescribeTapesRequest request);

        /// <summary>
        /// Paginator for DescribeVTLDevices operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeVTLDevicesPaginator DescribeVTLDevices(DescribeVTLDevicesRequest request);

        /// <summary>
        /// Paginator for ListCacheReports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "Marker" }
        )]
        IListCacheReportsPaginator ListCacheReports(ListCacheReportsRequest request);

        /// <summary>
        /// Paginator for ListFileShares operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextMarker" }
        )]
        IListFileSharesPaginator ListFileShares(ListFileSharesRequest request);

        /// <summary>
        /// Paginator for ListFileSystemAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextMarker" }
        )]
        IListFileSystemAssociationsPaginator ListFileSystemAssociations(ListFileSystemAssociationsRequest request);

        /// <summary>
        /// Paginator for ListGateways operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IListGatewaysPaginator ListGateways(ListGatewaysRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListTapePools operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IListTapePoolsPaginator ListTapePools(ListTapePoolsRequest request);

        /// <summary>
        /// Paginator for ListTapes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IListTapesPaginator ListTapes(ListTapesRequest request);

        /// <summary>
        /// Paginator for ListVolumes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IListVolumesPaginator ListVolumes(ListVolumesRequest request);
    }
}