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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Paginator for the ListServiceActions operation
    /// </summary>
    internal sealed partial class ListServiceActionsPaginator : IPaginator<ListServiceActionsResponse>, IListServiceActionsPaginator
    {
        private readonly IAmazonServiceCatalog _client;
        private readonly ListServiceActionsRequest _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListServiceActionsResponse> Responses => new PaginatedResponse<ListServiceActionsResponse>(this);

        internal ListServiceActionsPaginator(IAmazonServiceCatalog client, ListServiceActionsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if NETFRAMEWORK
        IEnumerable<ListServiceActionsResponse> IPaginator<ListServiceActionsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.PageToken;
            ListServiceActionsResponse response;
            do
            {
                _request.PageToken = nextToken;
                response = _client.ListServiceActions(_request);
                nextToken = response.NextPageToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListServiceActionsResponse> IPaginator<ListServiceActionsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.PageToken;
            ListServiceActionsResponse response;
            do
            {
                _request.PageToken = nextToken;
                response = await _client.ListServiceActionsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextPageToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
