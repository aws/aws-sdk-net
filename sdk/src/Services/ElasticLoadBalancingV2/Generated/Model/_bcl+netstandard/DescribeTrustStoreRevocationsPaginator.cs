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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Base class for DescribeTrustStoreRevocations paginators.
    /// </summary>
    internal sealed partial class DescribeTrustStoreRevocationsPaginator : IPaginator<DescribeTrustStoreRevocationsResponse>, IDescribeTrustStoreRevocationsPaginator
    {
        private readonly IAmazonElasticLoadBalancingV2 _client;
        private readonly DescribeTrustStoreRevocationsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeTrustStoreRevocationsResponse> Responses => new PaginatedResponse<DescribeTrustStoreRevocationsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the TrustStoreRevocations
        /// </summary>
        public IPaginatedEnumerable<DescribeTrustStoreRevocation> TrustStoreRevocations => 
            new PaginatedResultKeyResponse<DescribeTrustStoreRevocationsResponse, DescribeTrustStoreRevocation>(this, (i) => i.TrustStoreRevocations ?? new List<DescribeTrustStoreRevocation>());

        internal DescribeTrustStoreRevocationsPaginator(IAmazonElasticLoadBalancingV2 client, DescribeTrustStoreRevocationsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeTrustStoreRevocationsResponse> IPaginator<DescribeTrustStoreRevocationsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            DescribeTrustStoreRevocationsResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.DescribeTrustStoreRevocations(_request);
                marker = response.NextMarker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeTrustStoreRevocationsResponse> IPaginator<DescribeTrustStoreRevocationsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            DescribeTrustStoreRevocationsResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.DescribeTrustStoreRevocationsAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.NextMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
    }
}