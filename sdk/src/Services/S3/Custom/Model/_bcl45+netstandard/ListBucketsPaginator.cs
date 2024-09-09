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
using System.Threading;
using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Base class for ListBuckets paginators.
    /// </summary>
    internal sealed partial class ListBucketsPaginator : IPaginator<ListBucketsResponse>, IListBucketsPaginator
    {
        private readonly IAmazonS3 _client;
        private readonly ListBucketsRequest _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation.
        /// </summary>
        public IPaginatedEnumerable<ListBucketsResponse> Responses => new PaginatedResponse<ListBucketsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the buckets.
        /// </summary>
        public IPaginatedEnumerable<S3Bucket> Buckets =>
            new PaginatedResultKeyResponse<ListBucketsResponse, S3Bucket>(this, (i) => i.Buckets ?? new List<S3Bucket>());

        internal ListBucketsPaginator(IAmazonS3 client, ListBucketsRequest request)
        {
            this._client = client;
            this._request = request;
        }

#if BCL
        IEnumerable<ListBucketsResponse> IPaginator<ListBucketsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var continuationToken = _request.ContinuationToken;
            ListBucketsResponse response;
            do
            {
                _request.ContinuationToken = continuationToken;
                response = _client.ListBuckets(_request);
                continuationToken = response.ContinuationToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(continuationToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListBucketsResponse> IPaginator<ListBucketsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var continuationToken = _request.ContinuationToken;
            ListBucketsResponse response;
            do
            {
                _request.ContinuationToken = continuationToken;
                response = await _client.ListBucketsAsync(_request, cancellationToken).ConfigureAwait(false);
                continuationToken = response.ContinuationToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(continuationToken));
        }
#endif
    }
}
