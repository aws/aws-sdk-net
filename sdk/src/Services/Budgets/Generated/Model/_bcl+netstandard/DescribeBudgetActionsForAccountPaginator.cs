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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.Budgets.Model
{
    /// <summary>
    /// Base class for DescribeBudgetActionsForAccount paginators.
    /// </summary>
    internal sealed partial class DescribeBudgetActionsForAccountPaginator : IPaginator<DescribeBudgetActionsForAccountResponse>, IDescribeBudgetActionsForAccountPaginator
    {
        private readonly IAmazonBudgets _client;
        private readonly DescribeBudgetActionsForAccountRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeBudgetActionsForAccountResponse> Responses => new PaginatedResponse<DescribeBudgetActionsForAccountResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Actions
        /// </summary>
        public IPaginatedEnumerable<Action> Actions => 
            new PaginatedResultKeyResponse<DescribeBudgetActionsForAccountResponse, Action>(this, (i) => i.Actions ?? new List<Action>());

        internal DescribeBudgetActionsForAccountPaginator(IAmazonBudgets client, DescribeBudgetActionsForAccountRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeBudgetActionsForAccountResponse> IPaginator<DescribeBudgetActionsForAccountResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeBudgetActionsForAccountResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.DescribeBudgetActionsForAccount(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeBudgetActionsForAccountResponse> IPaginator<DescribeBudgetActionsForAccountResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeBudgetActionsForAccountResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.DescribeBudgetActionsForAccountAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}