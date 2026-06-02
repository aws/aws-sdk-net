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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Base class for GetRecommendedPolicyV2 paginators.
    /// </summary>
    internal sealed partial class GetRecommendedPolicyV2Paginator : IPaginator<GetRecommendedPolicyV2Response>, IGetRecommendedPolicyV2Paginator
    {
        private readonly IAmazonSecurityHub _client;
        private readonly GetRecommendedPolicyV2Request _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<GetRecommendedPolicyV2Response> Responses => new PaginatedResponse<GetRecommendedPolicyV2Response>(this);

        /// <summary>
        /// Enumerable containing all of the RecommendationSteps
        /// </summary>
        public IPaginatedEnumerable<RecommendationStep> RecommendationSteps => 
            new PaginatedResultKeyResponse<GetRecommendedPolicyV2Response, RecommendationStep>(this, (i) => i.RecommendationSteps ?? new List<RecommendationStep>());

        internal GetRecommendedPolicyV2Paginator(IAmazonSecurityHub client, GetRecommendedPolicyV2Request request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<GetRecommendedPolicyV2Response> IPaginator<GetRecommendedPolicyV2Response>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            GetRecommendedPolicyV2Response response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.GetRecommendedPolicyV2(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<GetRecommendedPolicyV2Response> IPaginator<GetRecommendedPolicyV2Response>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            GetRecommendedPolicyV2Response response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.GetRecommendedPolicyV2Async(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}