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

namespace Amazon.OpenSearchMemory.Model
{
    /// <summary>
    /// Paginator for the SearchMemories operation
    /// </summary>
    internal sealed partial class SearchMemoriesPaginator : IPaginator<SearchMemoriesResponse>, ISearchMemoriesPaginator
    {
        private readonly IAmazonOpenSearchMemory _client;
        private readonly SearchMemoriesRequest _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<SearchMemoriesResponse> Responses => new PaginatedResponse<SearchMemoriesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Memories
        /// </summary>
        public IPaginatedEnumerable<MemorySearchSummary> Memories =>
            new PaginatedResultKeyResponse<SearchMemoriesResponse, MemorySearchSummary>(this, (i) => i.Memories ?? new List<MemorySearchSummary>());

        internal SearchMemoriesPaginator(IAmazonOpenSearchMemory client, SearchMemoriesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if NETFRAMEWORK
        IEnumerable<SearchMemoriesResponse> IPaginator<SearchMemoriesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            SearchMemoriesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.SearchMemories(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<SearchMemoriesResponse> IPaginator<SearchMemoriesResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            SearchMemoriesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.SearchMemoriesAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
