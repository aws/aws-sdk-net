#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.IVS.Model
{
    /// <summary>
    /// Base class for ListPlaybackKeyPairs paginators.
    /// </summary>
    internal sealed partial class ListPlaybackKeyPairsPaginator : IPaginator<ListPlaybackKeyPairsResponse>, IListPlaybackKeyPairsPaginator
    {
        private readonly IAmazonIVS _client;
        private readonly ListPlaybackKeyPairsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListPlaybackKeyPairsResponse> Responses => new PaginatedResponse<ListPlaybackKeyPairsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the KeyPairs
        /// </summary>
        public IPaginatedEnumerable<PlaybackKeyPairSummary> KeyPairs => 
            new PaginatedResultKeyResponse<ListPlaybackKeyPairsResponse, PlaybackKeyPairSummary>(this, (i) => i.KeyPairs);

        internal ListPlaybackKeyPairsPaginator(IAmazonIVS client, ListPlaybackKeyPairsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListPlaybackKeyPairsResponse> IPaginator<ListPlaybackKeyPairsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListPlaybackKeyPairsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListPlaybackKeyPairs(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListPlaybackKeyPairsResponse> IPaginator<ListPlaybackKeyPairsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListPlaybackKeyPairsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListPlaybackKeyPairsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
#endif