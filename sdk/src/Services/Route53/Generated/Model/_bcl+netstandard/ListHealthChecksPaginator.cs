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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53.Model
{
    /// <summary>
    /// Base class for ListHealthChecks paginators.
    /// </summary>
    internal sealed partial class ListHealthChecksPaginator : IPaginator<ListHealthChecksResponse>, IListHealthChecksPaginator
    {
        private readonly IAmazonRoute53 _client;
        private readonly ListHealthChecksRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListHealthChecksResponse> Responses => new PaginatedResponse<ListHealthChecksResponse>(this);

        /// <summary>
        /// Enumerable containing all of the HealthChecks
        /// </summary>
        public IPaginatedEnumerable<HealthCheck> HealthChecks => 
            new PaginatedResultKeyResponse<ListHealthChecksResponse, HealthCheck>(this, (i) => i.HealthChecks ?? new List<HealthCheck>());

        internal ListHealthChecksPaginator(IAmazonRoute53 client, ListHealthChecksRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListHealthChecksResponse> IPaginator<ListHealthChecksResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListHealthChecksResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListHealthChecks(_request);
                marker = response.NextMarker;
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListHealthChecksResponse> IPaginator<ListHealthChecksResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListHealthChecksResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListHealthChecksAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.NextMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
    }
}