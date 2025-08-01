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
 * Do not modify this file. This file is generated from the s3vectors-2025-07-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Vectors.Model
{
    /// <summary>
    /// Paginators for the S3Vectors service
    ///</summary>
    public class S3VectorsPaginatorFactory : IS3VectorsPaginatorFactory
    {
        private readonly IAmazonS3Vectors client;

        internal S3VectorsPaginatorFactory(IAmazonS3Vectors client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListIndexes operation
        ///</summary>
        public IListIndexesPaginator ListIndexes(ListIndexesRequest request) 
        {
            return new ListIndexesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVectorBuckets operation
        ///</summary>
        public IListVectorBucketsPaginator ListVectorBuckets(ListVectorBucketsRequest request) 
        {
            return new ListVectorBucketsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVectors operation
        ///</summary>
        public IListVectorsPaginator ListVectors(ListVectorsRequest request) 
        {
            return new ListVectorsPaginator(this.client, request);
        }
    }
}