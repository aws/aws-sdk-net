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
 * Do not modify this file. This file is generated from the backupstorage-2018-04-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.BackupStorage.Model
{
    /// <summary>
    /// Paginators for the BackupStorage service
    ///</summary>
    public class BackupStoragePaginatorFactory : IBackupStoragePaginatorFactory
    {
        private readonly IAmazonBackupStorage client;

        internal BackupStoragePaginatorFactory(IAmazonBackupStorage client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListChunks operation
        ///</summary>
        public IListChunksPaginator ListChunks(ListChunksRequest request) 
        {
            return new ListChunksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListObjects operation
        ///</summary>
        public IListObjectsPaginator ListObjects(ListObjectsRequest request) 
        {
            return new ListObjectsPaginator(this.client, request);
        }
    }
}