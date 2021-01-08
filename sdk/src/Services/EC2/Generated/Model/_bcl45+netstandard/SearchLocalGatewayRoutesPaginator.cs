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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Base class for SearchLocalGatewayRoutes paginators.
    /// </summary>
    internal sealed partial class SearchLocalGatewayRoutesPaginator : IPaginator<SearchLocalGatewayRoutesResponse>, ISearchLocalGatewayRoutesPaginator
    {
        private readonly IAmazonEC2 _client;
        private readonly SearchLocalGatewayRoutesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<SearchLocalGatewayRoutesResponse> Responses => new PaginatedResponse<SearchLocalGatewayRoutesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Routes
        /// </summary>
        public IPaginatedEnumerable<LocalGatewayRoute> Routes => 
            new PaginatedResultKeyResponse<SearchLocalGatewayRoutesResponse, LocalGatewayRoute>(this, (i) => i.Routes);

        internal SearchLocalGatewayRoutesPaginator(IAmazonEC2 client, SearchLocalGatewayRoutesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<SearchLocalGatewayRoutesResponse> IPaginator<SearchLocalGatewayRoutesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            SearchLocalGatewayRoutesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.SearchLocalGatewayRoutes(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<SearchLocalGatewayRoutesResponse> IPaginator<SearchLocalGatewayRoutesResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            SearchLocalGatewayRoutesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.SearchLocalGatewayRoutesAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
#endif