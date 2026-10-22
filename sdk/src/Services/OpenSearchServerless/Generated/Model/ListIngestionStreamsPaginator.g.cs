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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Paginator for the ListIngestionStreams operation
    /// </summary>
    internal sealed partial class ListIngestionStreamsPaginator : IPaginator<ListIngestionStreamsResponse>, IListIngestionStreamsPaginator
    {
        private readonly IAmazonOpenSearchServerless _client;
        private readonly ListIngestionStreamsRequest _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListIngestionStreamsResponse> Responses => new PaginatedResponse<ListIngestionStreamsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the IngestionStreamSummaries
        /// </summary>
        public IPaginatedEnumerable<IngestionStreamSummary> IngestionStreamSummaries =>
            new PaginatedResultKeyResponse<ListIngestionStreamsResponse, IngestionStreamSummary>(this, (i) => i.IngestionStreamSummaries ?? new List<IngestionStreamSummary>());

        internal ListIngestionStreamsPaginator(IAmazonOpenSearchServerless client, ListIngestionStreamsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if NETFRAMEWORK
        IEnumerable<ListIngestionStreamsResponse> IPaginator<ListIngestionStreamsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListIngestionStreamsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListIngestionStreams(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListIngestionStreamsResponse> IPaginator<ListIngestionStreamsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListIngestionStreamsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListIngestionStreamsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
