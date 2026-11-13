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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Paginator for the DescribeNetworkingFlexCostAllocationPolicies operation
    /// </summary>
    internal sealed partial class DescribeNetworkingFlexCostAllocationPoliciesPaginator : IPaginator<DescribeNetworkingFlexCostAllocationPoliciesResponse>, IDescribeNetworkingFlexCostAllocationPoliciesPaginator
    {
        private readonly IAmazonEC2 _client;
        private readonly DescribeNetworkingFlexCostAllocationPoliciesRequest _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeNetworkingFlexCostAllocationPoliciesResponse> Responses => new PaginatedResponse<DescribeNetworkingFlexCostAllocationPoliciesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the FlexCostAllocationPolicies
        /// </summary>
        public IPaginatedEnumerable<FlexCostAllocationPolicyDescription> FlexCostAllocationPolicies =>
            new PaginatedResultKeyResponse<DescribeNetworkingFlexCostAllocationPoliciesResponse, FlexCostAllocationPolicyDescription>(this, (i) => i.FlexCostAllocationPolicies ?? new List<FlexCostAllocationPolicyDescription>());

        internal DescribeNetworkingFlexCostAllocationPoliciesPaginator(IAmazonEC2 client, DescribeNetworkingFlexCostAllocationPoliciesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if NETFRAMEWORK
        IEnumerable<DescribeNetworkingFlexCostAllocationPoliciesResponse> IPaginator<DescribeNetworkingFlexCostAllocationPoliciesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeNetworkingFlexCostAllocationPoliciesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.DescribeNetworkingFlexCostAllocationPolicies(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeNetworkingFlexCostAllocationPoliciesResponse> IPaginator<DescribeNetworkingFlexCostAllocationPoliciesResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeNetworkingFlexCostAllocationPoliciesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.DescribeNetworkingFlexCostAllocationPoliciesAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
