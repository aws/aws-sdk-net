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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Base class for ListOrders paginators.
    /// </summary>
    internal sealed partial class ListOrdersPaginator : IPaginator<ListOrdersResponse>, IListOrdersPaginator
    {
        private readonly IAmazonPrivate5G _client;
        private readonly ListOrdersRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListOrdersResponse> Responses => new PaginatedResponse<ListOrdersResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Orders
        /// </summary>
        public IPaginatedEnumerable<Order> Orders => 
            new PaginatedResultKeyResponse<ListOrdersResponse, Order>(this, (i) => i.Orders ?? new List<Order>());

        internal ListOrdersPaginator(IAmazonPrivate5G client, ListOrdersRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListOrdersResponse> IPaginator<ListOrdersResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var startToken = _request.StartToken;
            ListOrdersResponse response;
            do
            {
                _request.StartToken = startToken;
                response = _client.ListOrders(_request);
                startToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(startToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListOrdersResponse> IPaginator<ListOrdersResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var startToken = _request.StartToken;
            ListOrdersResponse response;
            do
            {
                _request.StartToken = startToken;
                response = await _client.ListOrdersAsync(_request, cancellationToken).ConfigureAwait(false);
                startToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(startToken));
        }
#endif
    }
}