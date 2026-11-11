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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Paginator for the ListClusterExtensions operation
    /// </summary>
    internal sealed partial class ListClusterExtensionsPaginator : IPaginator<ListClusterExtensionsResponse>, IListClusterExtensionsPaginator
    {
        private readonly IAmazonSageMaker _client;
        private readonly ListClusterExtensionsRequest _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListClusterExtensionsResponse> Responses => new PaginatedResponse<ListClusterExtensionsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Extensions
        /// </summary>
        public IPaginatedEnumerable<ExtensionSummary> Extensions =>
            new PaginatedResultKeyResponse<ListClusterExtensionsResponse, ExtensionSummary>(this, (i) => i.Extensions ?? new List<ExtensionSummary>());

        internal ListClusterExtensionsPaginator(IAmazonSageMaker client, ListClusterExtensionsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if NETFRAMEWORK
        IEnumerable<ListClusterExtensionsResponse> IPaginator<ListClusterExtensionsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListClusterExtensionsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListClusterExtensions(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListClusterExtensionsResponse> IPaginator<ListClusterExtensionsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListClusterExtensionsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListClusterExtensionsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
