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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Base class for DescribeCacheSubnetGroups paginators.
    /// </summary>
    internal sealed partial class DescribeCacheSubnetGroupsPaginator : IPaginator<DescribeCacheSubnetGroupsResponse>, IDescribeCacheSubnetGroupsPaginator
    {
        private readonly IAmazonElastiCache _client;
        private readonly DescribeCacheSubnetGroupsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeCacheSubnetGroupsResponse> Responses => new PaginatedResponse<DescribeCacheSubnetGroupsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the CacheSubnetGroups
        /// </summary>
        public IPaginatedEnumerable<CacheSubnetGroup> CacheSubnetGroups => 
            new PaginatedResultKeyResponse<DescribeCacheSubnetGroupsResponse, CacheSubnetGroup>(this, (i) => i.CacheSubnetGroups);

        internal DescribeCacheSubnetGroupsPaginator(IAmazonElastiCache client, DescribeCacheSubnetGroupsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeCacheSubnetGroupsResponse> IPaginator<DescribeCacheSubnetGroupsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            DescribeCacheSubnetGroupsResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.DescribeCacheSubnetGroups(_request);
                marker = response.Marker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeCacheSubnetGroupsResponse> IPaginator<DescribeCacheSubnetGroupsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            DescribeCacheSubnetGroupsResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.DescribeCacheSubnetGroupsAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.Marker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
    }
}
#endif