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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Paginator for the GetReservationPurchaseRecommendation operation
    /// </summary>
    internal sealed partial class GetReservationPurchaseRecommendationPaginator : IPaginator<GetReservationPurchaseRecommendationResponse>, IGetReservationPurchaseRecommendationPaginator
    {
        private readonly IAmazonCostExplorer _client;
        private readonly GetReservationPurchaseRecommendationRequest _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<GetReservationPurchaseRecommendationResponse> Responses => new PaginatedResponse<GetReservationPurchaseRecommendationResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Recommendations
        /// </summary>
        public IPaginatedEnumerable<ReservationPurchaseRecommendation> Recommendations =>
            new PaginatedResultKeyResponse<GetReservationPurchaseRecommendationResponse, ReservationPurchaseRecommendation>(this, (i) => i.Recommendations ?? new List<ReservationPurchaseRecommendation>());

        internal GetReservationPurchaseRecommendationPaginator(IAmazonCostExplorer client, GetReservationPurchaseRecommendationRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if NETFRAMEWORK
        IEnumerable<GetReservationPurchaseRecommendationResponse> IPaginator<GetReservationPurchaseRecommendationResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextPageToken;
            GetReservationPurchaseRecommendationResponse response;
            do
            {
                _request.NextPageToken = nextToken;
                response = _client.GetReservationPurchaseRecommendation(_request);
                nextToken = response.NextPageToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<GetReservationPurchaseRecommendationResponse> IPaginator<GetReservationPurchaseRecommendationResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextPageToken;
            GetReservationPurchaseRecommendationResponse response;
            do
            {
                _request.NextPageToken = nextToken;
                response = await _client.GetReservationPurchaseRecommendationAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextPageToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
