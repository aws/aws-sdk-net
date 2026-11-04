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

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Paginator for the DescribeRules operation
    /// </summary>
    internal sealed partial class DescribeRulesPaginator : IPaginator<DescribeRulesResponse>, IDescribeRulesPaginator
    {
        private readonly IAmazonElasticLoadBalancingV2 _client;
        private readonly DescribeRulesRequest _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeRulesResponse> Responses => new PaginatedResponse<DescribeRulesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Rules
        /// </summary>
        public IPaginatedEnumerable<Rule> Rules =>
            new PaginatedResultKeyResponse<DescribeRulesResponse, Rule>(this, (i) => i.Rules ?? new List<Rule>());

        internal DescribeRulesPaginator(IAmazonElasticLoadBalancingV2 client, DescribeRulesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if NETFRAMEWORK
        IEnumerable<DescribeRulesResponse> IPaginator<DescribeRulesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.Marker;
            DescribeRulesResponse response;
            do
            {
                _request.Marker = nextToken;
                response = _client.DescribeRules(_request);
                nextToken = response.NextMarker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeRulesResponse> IPaginator<DescribeRulesResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.Marker;
            DescribeRulesResponse response;
            do
            {
                _request.Marker = nextToken;
                response = await _client.DescribeRulesAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
