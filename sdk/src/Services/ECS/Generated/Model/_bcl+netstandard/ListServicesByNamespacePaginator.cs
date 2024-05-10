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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Base class for ListServicesByNamespace paginators.
    /// </summary>
    internal sealed partial class ListServicesByNamespacePaginator : IPaginator<ListServicesByNamespaceResponse>, IListServicesByNamespacePaginator
    {
        private readonly IAmazonECS _client;
        private readonly ListServicesByNamespaceRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListServicesByNamespaceResponse> Responses => new PaginatedResponse<ListServicesByNamespaceResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ServiceArns
        /// </summary>
        public IPaginatedEnumerable<string> ServiceArns => 
            new PaginatedResultKeyResponse<ListServicesByNamespaceResponse, string>(this, (i) => i.ServiceArns ?? new List<string>());

        internal ListServicesByNamespacePaginator(IAmazonECS client, ListServicesByNamespaceRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListServicesByNamespaceResponse> IPaginator<ListServicesByNamespaceResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListServicesByNamespaceResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListServicesByNamespace(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListServicesByNamespaceResponse> IPaginator<ListServicesByNamespaceResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListServicesByNamespaceResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListServicesByNamespaceAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}