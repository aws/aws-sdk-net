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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Base class for ListEventSourceMappings paginators.
    /// </summary>
    internal sealed partial class ListEventSourceMappingsPaginator : IPaginator<ListEventSourceMappingsResponse>, IListEventSourceMappingsPaginator
    {
        private readonly IAmazonLambda _client;
        private readonly ListEventSourceMappingsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListEventSourceMappingsResponse> Responses => new PaginatedResponse<ListEventSourceMappingsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the EventSourceMappings
        /// </summary>
        public IPaginatedEnumerable<EventSourceMappingConfiguration> EventSourceMappings => 
            new PaginatedResultKeyResponse<ListEventSourceMappingsResponse, EventSourceMappingConfiguration>(this, (i) => i.EventSourceMappings);

        internal ListEventSourceMappingsPaginator(IAmazonLambda client, ListEventSourceMappingsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListEventSourceMappingsResponse> IPaginator<ListEventSourceMappingsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListEventSourceMappingsResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListEventSourceMappings(_request);
                marker = response.NextMarker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListEventSourceMappingsResponse> IPaginator<ListEventSourceMappingsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListEventSourceMappingsResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListEventSourceMappingsAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.NextMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
    }
}
#endif