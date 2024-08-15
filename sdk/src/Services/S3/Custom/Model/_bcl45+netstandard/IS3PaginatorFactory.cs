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
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Paginators for the S3 service
    ///</summary>
    public interface IS3PaginatorFactory
    {
        /// <summary>
        /// Paginator for ListMultipartUploads operation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        IListMultipartUploadsPaginator ListMultipartUploads(ListMultipartUploadsRequest request);
       
        /// <summary>
        /// Paginator for ListObjects operation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        IListObjectsPaginator ListObjects(ListObjectsRequest request);
        
        /// <summary>
        /// Paginator for ListObjectsV2 operation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        IListObjectsV2Paginator ListObjectsV2(ListObjectsV2Request request);
        
        /// <summary>
        /// Paginator for ListParts operation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        IListPartsPaginator ListParts(ListPartsRequest request);
        
        /// <summary>
        /// Paginator for ListVersions operation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        IListVersionsPaginator ListVersions(ListVersionsRequest request);

        /// <summary>
        /// Paginator for ListBuckets operation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        IListBucketsPaginator ListBuckets(ListBucketsRequest request);
    }
}
