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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Paginators for the FSx service
    ///</summary>
    public interface IFSxPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeBackups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeBackupsPaginator DescribeBackups(DescribeBackupsRequest request);

        /// <summary>
        /// Paginator for DescribeDataRepositoryAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeDataRepositoryAssociationsPaginator DescribeDataRepositoryAssociations(DescribeDataRepositoryAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeDataRepositoryTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeDataRepositoryTasksPaginator DescribeDataRepositoryTasks(DescribeDataRepositoryTasksRequest request);

        /// <summary>
        /// Paginator for DescribeFileCaches operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFileCachesPaginator DescribeFileCaches(DescribeFileCachesRequest request);

        /// <summary>
        /// Paginator for DescribeFileSystemAliases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFileSystemAliasesPaginator DescribeFileSystemAliases(DescribeFileSystemAliasesRequest request);

        /// <summary>
        /// Paginator for DescribeFileSystems operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFileSystemsPaginator DescribeFileSystems(DescribeFileSystemsRequest request);

        /// <summary>
        /// Paginator for DescribeS3AccessPointAttachments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeS3AccessPointAttachmentsPaginator DescribeS3AccessPointAttachments(DescribeS3AccessPointAttachmentsRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSnapshotsPaginator DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeStorageVirtualMachines operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeStorageVirtualMachinesPaginator DescribeStorageVirtualMachines(DescribeStorageVirtualMachinesRequest request);

        /// <summary>
        /// Paginator for DescribeVolumes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVolumesPaginator DescribeVolumes(DescribeVolumesRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);
    }
}