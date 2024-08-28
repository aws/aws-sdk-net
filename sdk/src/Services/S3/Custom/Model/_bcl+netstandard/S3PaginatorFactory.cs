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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Paginators for the S3 service
    ///</summary>
    public class S3PaginatorFactory : IS3PaginatorFactory
    {
        private readonly IAmazonS3 _client;

        internal S3PaginatorFactory(IAmazonS3 client)
        {
            this._client = client;
        }

        /// <summary>
        /// Paginator for ListMultipartUploads operation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public IListMultipartUploadsPaginator ListMultipartUploads(ListMultipartUploadsRequest request)
        {
            return new ListMultipartUploadsPaginator(this._client, request);
        }

        /// <summary>
        /// Paginator for ListObjects operation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public IListObjectsPaginator ListObjects(ListObjectsRequest request)
        {
            return new ListObjectsPaginator(this._client, request);
        }

        /// <summary>
        /// Paginator for ListObjectsV2 operation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public IListObjectsV2Paginator ListObjectsV2(ListObjectsV2Request request)
        {
            return new ListObjectsV2Paginator(this._client, request);
        }

        /// <summary>
        /// Paginator for ListParts operation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public IListPartsPaginator ListParts(ListPartsRequest request)
        {
            return new ListPartsPaginator(this._client, request);
        }

        /// <summary>
        /// Paginator for ListVersions operation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public IListVersionsPaginator ListVersions(ListVersionsRequest request)
        {
            return new ListVersionsPaginator(this._client, request);
        }

        /// <summary>
        /// Paginator for ListBuckets operation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public IListBucketsPaginator ListBuckets(ListBucketsRequest request)
        {
            return new ListBucketsPaginator(this._client, request);
        }
    }
}
