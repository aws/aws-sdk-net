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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Base class for GetRecommendationPreferences paginators.
    /// </summary>
    internal sealed partial class GetRecommendationPreferencesPaginator : IPaginator<GetRecommendationPreferencesResponse>, IGetRecommendationPreferencesPaginator
    {
        private readonly IAmazonComputeOptimizer _client;
        private readonly GetRecommendationPreferencesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<GetRecommendationPreferencesResponse> Responses => new PaginatedResponse<GetRecommendationPreferencesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the RecommendationPreferencesDetails
        /// </summary>
        public IPaginatedEnumerable<RecommendationPreferencesDetail> RecommendationPreferencesDetails => 
            new PaginatedResultKeyResponse<GetRecommendationPreferencesResponse, RecommendationPreferencesDetail>(this, (i) => i.RecommendationPreferencesDetails);

        internal GetRecommendationPreferencesPaginator(IAmazonComputeOptimizer client, GetRecommendationPreferencesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<GetRecommendationPreferencesResponse> IPaginator<GetRecommendationPreferencesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            GetRecommendationPreferencesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.GetRecommendationPreferences(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<GetRecommendationPreferencesResponse> IPaginator<GetRecommendationPreferencesResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            GetRecommendationPreferencesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.GetRecommendationPreferencesAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}