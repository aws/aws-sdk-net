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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Paginator for the DescribeReservedCacheNodesOfferings operation
    /// </summary>
    internal sealed partial class DescribeReservedCacheNodesOfferingsPaginator : IPaginator<DescribeReservedCacheNodesOfferingsResponse>, IDescribeReservedCacheNodesOfferingsPaginator
    {
        private readonly IAmazonElastiCache _client;
        private readonly DescribeReservedCacheNodesOfferingsRequest _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeReservedCacheNodesOfferingsResponse> Responses => new PaginatedResponse<DescribeReservedCacheNodesOfferingsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ReservedCacheNodesOfferings
        /// </summary>
        public IPaginatedEnumerable<ReservedCacheNodesOffering> ReservedCacheNodesOfferings =>
            new PaginatedResultKeyResponse<DescribeReservedCacheNodesOfferingsResponse, ReservedCacheNodesOffering>(this, (i) => i.ReservedCacheNodesOfferings ?? new List<ReservedCacheNodesOffering>());

        internal DescribeReservedCacheNodesOfferingsPaginator(IAmazonElastiCache client, DescribeReservedCacheNodesOfferingsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if NETFRAMEWORK
        IEnumerable<DescribeReservedCacheNodesOfferingsResponse> IPaginator<DescribeReservedCacheNodesOfferingsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.Marker;
            DescribeReservedCacheNodesOfferingsResponse response;
            do
            {
                _request.Marker = nextToken;
                response = _client.DescribeReservedCacheNodesOfferings(_request);
                nextToken = response.Marker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeReservedCacheNodesOfferingsResponse> IPaginator<DescribeReservedCacheNodesOfferingsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.Marker;
            DescribeReservedCacheNodesOfferingsResponse response;
            do
            {
                _request.Marker = nextToken;
                response = await _client.DescribeReservedCacheNodesOfferingsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.Marker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
