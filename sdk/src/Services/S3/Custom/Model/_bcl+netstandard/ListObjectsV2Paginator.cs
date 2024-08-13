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
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.S3.Model
{
    /// <summary>
    /// Base class for ListObjectsV2 paginators.
    /// </summary>
    internal sealed partial class ListObjectsV2Paginator : IPaginator<ListObjectsV2Response>, IListObjectsV2Paginator
    {
        private readonly IAmazonS3 _client;
        private readonly ListObjectsV2Request _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListObjectsV2Response> Responses => new PaginatedResponse<ListObjectsV2Response>(this);
        
        /// <summary>
        /// Enumerable containing all of the S3Objects
        /// </summary>
        public IPaginatedEnumerable<S3Object> S3Objects => 
            new PaginatedResultKeyResponse<ListObjectsV2Response, S3Object>(this, (i) => i.S3Objects ?? new List<S3Object>());

        /// <summary>
        /// Enumerable containing all of the CommonPrefixes
        /// </summary>
        public IPaginatedEnumerable<string> CommonPrefixes => 
            new PaginatedResultKeyResponse<ListObjectsV2Response, string>(this, (i) => i.CommonPrefixes ?? new List<string>());

        internal ListObjectsV2Paginator(IAmazonS3 client, ListObjectsV2Request request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListObjectsV2Response> IPaginator<ListObjectsV2Response>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var continuationToken = _request.ContinuationToken;
            ListObjectsV2Response response;
            do
            {
                _request.ContinuationToken = continuationToken;
                response = _client.ListObjectsV2(_request);
                continuationToken = response.NextContinuationToken;
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListObjectsV2Response> IPaginator<ListObjectsV2Response>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var continuationToken = _request.ContinuationToken;
            ListObjectsV2Response response;
            do
            {
                _request.ContinuationToken = continuationToken;
                response = await _client.ListObjectsV2Async(_request, cancellationToken).ConfigureAwait(false);
                continuationToken = response.NextContinuationToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
    }
}