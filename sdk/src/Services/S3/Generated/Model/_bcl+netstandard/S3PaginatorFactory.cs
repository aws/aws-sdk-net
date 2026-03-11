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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model
{
    /// <summary>
    /// Paginators for the S3 service
    ///</summary>
    public partial class S3PaginatorFactory : IS3PaginatorFactory
    {
        private readonly IAmazonS3 client;

        internal S3PaginatorFactory(IAmazonS3 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListBuckets operation
        ///</summary>
        public IListBucketsPaginator ListBuckets(ListBucketsRequest request) 
        {
            return new ListBucketsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDirectoryBuckets operation
        ///</summary>
        public IListDirectoryBucketsPaginator ListDirectoryBuckets(ListDirectoryBucketsRequest request) 
        {
            return new ListDirectoryBucketsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMultipartUploads operation
        ///</summary>
        public IListMultipartUploadsPaginator ListMultipartUploads(ListMultipartUploadsRequest request) 
        {
            return new ListMultipartUploadsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListObjectsV2 operation
        ///</summary>
        public IListObjectsV2Paginator ListObjectsV2(ListObjectsV2Request request) 
        {
            return new ListObjectsV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListParts operation
        ///</summary>
        public IListPartsPaginator ListParts(ListPartsRequest request) 
        {
            return new ListPartsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVersions operation
        ///</summary>
        public IListVersionsPaginator ListVersions(ListVersionsRequest request) 
        {
            return new ListVersionsPaginator(this.client, request);
        }
    }
}