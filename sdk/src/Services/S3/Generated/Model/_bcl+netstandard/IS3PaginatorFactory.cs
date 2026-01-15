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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model
{
    /// <summary>
    /// Paginators for the S3 service
    ///</summary>
    public partial interface IS3PaginatorFactory
    {

        /// <summary>
        /// Paginator for ListBuckets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "ContinuationToken" },
            LimitKey = "MaxBuckets",
            OutputToken = new[] { "ContinuationToken" }
        )]
        IListBucketsPaginator ListBuckets(ListBucketsRequest request);

        /// <summary>
        /// Paginator for ListDirectoryBuckets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "ContinuationToken" },
            LimitKey = "MaxDirectoryBuckets",
            OutputToken = new[] { "ContinuationToken" }
        )]
        IListDirectoryBucketsPaginator ListDirectoryBuckets(ListDirectoryBucketsRequest request);

        /// <summary>
        /// Paginator for ListMultipartUploads operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "KeyMarker","UploadIdMarker" },
            LimitKey = "MaxUploads",
            OutputToken = new[] { "NextKeyMarker","NextUploadIdMarker" }
        )]
        IListMultipartUploadsPaginator ListMultipartUploads(ListMultipartUploadsRequest request);

        /// <summary>
        /// Paginator for ListObjectsV2 operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "ContinuationToken" },
            LimitKey = "MaxKeys",
            OutputToken = new[] { "NextContinuationToken" }
        )]
        IListObjectsV2Paginator ListObjectsV2(ListObjectsV2Request request);

        /// <summary>
        /// Paginator for ListParts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PartNumberMarker" },
            LimitKey = "MaxParts",
            OutputToken = new[] { "NextPartNumberMarker" }
        )]
        IListPartsPaginator ListParts(ListPartsRequest request);

        /// <summary>
        /// Paginator for ListVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "KeyMarker","VersionIdMarker" },
            LimitKey = "MaxKeys",
            OutputToken = new[] { "NextKeyMarker","NextVersionIdMarker" }
        )]
        IListVersionsPaginator ListVersions(ListVersionsRequest request);
    }
}