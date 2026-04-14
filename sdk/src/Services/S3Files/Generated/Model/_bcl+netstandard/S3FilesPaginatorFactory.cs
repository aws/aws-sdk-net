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
 * Do not modify this file. This file is generated from the s3files-2025-05-05.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Files.Model
{
    /// <summary>
    /// Paginators for the S3Files service
    ///</summary>
    public class S3FilesPaginatorFactory : IS3FilesPaginatorFactory
    {
        private readonly IAmazonS3Files client;

        internal S3FilesPaginatorFactory(IAmazonS3Files client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccessPoints operation
        ///</summary>
        public IListAccessPointsPaginator ListAccessPoints(ListAccessPointsRequest request) 
        {
            return new ListAccessPointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFileSystems operation
        ///</summary>
        public IListFileSystemsPaginator ListFileSystems(ListFileSystemsRequest request) 
        {
            return new ListFileSystemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMountTargets operation
        ///</summary>
        public IListMountTargetsPaginator ListMountTargets(ListMountTargetsRequest request) 
        {
            return new ListMountTargetsPaginator(this.client, request);
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