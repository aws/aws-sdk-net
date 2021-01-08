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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.Route53.Model
{
    /// <summary>
    /// Base class for ListHostedZones paginators.
    /// </summary>
    internal sealed partial class ListHostedZonesPaginator : IPaginator<ListHostedZonesResponse>, IListHostedZonesPaginator
    {
        private readonly IAmazonRoute53 _client;
        private readonly ListHostedZonesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListHostedZonesResponse> Responses => new PaginatedResponse<ListHostedZonesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the HostedZones
        /// </summary>
        public IPaginatedEnumerable<HostedZone> HostedZones => 
            new PaginatedResultKeyResponse<ListHostedZonesResponse, HostedZone>(this, (i) => i.HostedZones);

        internal ListHostedZonesPaginator(IAmazonRoute53 client, ListHostedZonesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListHostedZonesResponse> IPaginator<ListHostedZonesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListHostedZonesResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListHostedZones(_request);
                marker = response.NextMarker;
                yield return response;
            }
            while (response.IsTruncated);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListHostedZonesResponse> IPaginator<ListHostedZonesResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListHostedZonesResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListHostedZonesAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.NextMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (response.IsTruncated);
        }
#endif
    }
}
#endif