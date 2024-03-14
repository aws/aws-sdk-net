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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Base class for ListHealthEvents paginators.
    /// </summary>
    internal sealed partial class ListHealthEventsPaginator : IPaginator<ListHealthEventsResponse>, IListHealthEventsPaginator
    {
        private readonly IAmazonInternetMonitor _client;
        private readonly ListHealthEventsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListHealthEventsResponse> Responses => new PaginatedResponse<ListHealthEventsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the HealthEvents
        /// </summary>
        public IPaginatedEnumerable<HealthEvent> HealthEvents => 
            new PaginatedResultKeyResponse<ListHealthEventsResponse, HealthEvent>(this, (i) => i.HealthEvents);

        internal ListHealthEventsPaginator(IAmazonInternetMonitor client, ListHealthEventsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListHealthEventsResponse> IPaginator<ListHealthEventsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListHealthEventsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListHealthEvents(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListHealthEventsResponse> IPaginator<ListHealthEventsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListHealthEventsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListHealthEventsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}