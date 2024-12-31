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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Base class for ListNamespaces paginators.
    /// </summary>
    internal sealed partial class ListNamespacesPaginator : IPaginator<ListNamespacesResponse>, IListNamespacesPaginator
    {
        private readonly IAmazonS3Tables _client;
        private readonly ListNamespacesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListNamespacesResponse> Responses => new PaginatedResponse<ListNamespacesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Namespaces
        /// </summary>
        public IPaginatedEnumerable<NamespaceSummary> Namespaces => 
            new PaginatedResultKeyResponse<ListNamespacesResponse, NamespaceSummary>(this, (i) => i.Namespaces ?? new List<NamespaceSummary>());

        internal ListNamespacesPaginator(IAmazonS3Tables client, ListNamespacesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListNamespacesResponse> IPaginator<ListNamespacesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var continuationToken = _request.ContinuationToken;
            ListNamespacesResponse response;
            do
            {
                _request.ContinuationToken = continuationToken;
                response = _client.ListNamespaces(_request);
                continuationToken = response.ContinuationToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(continuationToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListNamespacesResponse> IPaginator<ListNamespacesResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var continuationToken = _request.ContinuationToken;
            ListNamespacesResponse response;
            do
            {
                _request.ContinuationToken = continuationToken;
                response = await _client.ListNamespacesAsync(_request, cancellationToken).ConfigureAwait(false);
                continuationToken = response.ContinuationToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(continuationToken));
        }
#endif
    }
}