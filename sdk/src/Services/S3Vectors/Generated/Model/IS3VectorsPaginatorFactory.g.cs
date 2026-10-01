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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.S3Vectors.Model
{
    /// <summary>
    /// Paginators for the S3Vectors service
    /// </summary>
    public interface IS3VectorsPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListIndexes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIndexesPaginator ListIndexes(ListIndexesRequest request);

        /// <summary>
        /// Paginator for ListVectorBuckets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListVectorBucketsPaginator ListVectorBuckets(ListVectorBucketsRequest request);

        /// <summary>
        /// Paginator for ListVectors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListVectorsPaginator ListVectors(ListVectorsRequest request);

        /// <summary>
        /// Paginator for QueryVectors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IQueryVectorsPaginator QueryVectors(QueryVectorsRequest request);
    }
}
