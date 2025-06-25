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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Paginators for the FSx service
    ///</summary>
    public class FSxPaginatorFactory : IFSxPaginatorFactory
    {
        private readonly IAmazonFSx client;

        internal FSxPaginatorFactory(IAmazonFSx client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeBackups operation
        ///</summary>
        public IDescribeBackupsPaginator DescribeBackups(DescribeBackupsRequest request) 
        {
            return new DescribeBackupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDataRepositoryAssociations operation
        ///</summary>
        public IDescribeDataRepositoryAssociationsPaginator DescribeDataRepositoryAssociations(DescribeDataRepositoryAssociationsRequest request) 
        {
            return new DescribeDataRepositoryAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDataRepositoryTasks operation
        ///</summary>
        public IDescribeDataRepositoryTasksPaginator DescribeDataRepositoryTasks(DescribeDataRepositoryTasksRequest request) 
        {
            return new DescribeDataRepositoryTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFileCaches operation
        ///</summary>
        public IDescribeFileCachesPaginator DescribeFileCaches(DescribeFileCachesRequest request) 
        {
            return new DescribeFileCachesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFileSystemAliases operation
        ///</summary>
        public IDescribeFileSystemAliasesPaginator DescribeFileSystemAliases(DescribeFileSystemAliasesRequest request) 
        {
            return new DescribeFileSystemAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFileSystems operation
        ///</summary>
        public IDescribeFileSystemsPaginator DescribeFileSystems(DescribeFileSystemsRequest request) 
        {
            return new DescribeFileSystemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeS3AccessPointAttachments operation
        ///</summary>
        public IDescribeS3AccessPointAttachmentsPaginator DescribeS3AccessPointAttachments(DescribeS3AccessPointAttachmentsRequest request) 
        {
            return new DescribeS3AccessPointAttachmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSnapshots operation
        ///</summary>
        public IDescribeSnapshotsPaginator DescribeSnapshots(DescribeSnapshotsRequest request) 
        {
            return new DescribeSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeStorageVirtualMachines operation
        ///</summary>
        public IDescribeStorageVirtualMachinesPaginator DescribeStorageVirtualMachines(DescribeStorageVirtualMachinesRequest request) 
        {
            return new DescribeStorageVirtualMachinesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVolumes operation
        ///</summary>
        public IDescribeVolumesPaginator DescribeVolumes(DescribeVolumesRequest request) 
        {
            return new DescribeVolumesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }
    }
}