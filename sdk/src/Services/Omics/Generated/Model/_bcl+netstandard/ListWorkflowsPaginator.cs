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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.Omics.Model
{
    /// <summary>
    /// Base class for ListWorkflows paginators.
    /// </summary>
    internal sealed partial class ListWorkflowsPaginator : IPaginator<ListWorkflowsResponse>, IListWorkflowsPaginator
    {
        private readonly IAmazonOmics _client;
        private readonly ListWorkflowsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListWorkflowsResponse> Responses => new PaginatedResponse<ListWorkflowsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Items
        /// </summary>
        public IPaginatedEnumerable<WorkflowListItem> Items => 
            new PaginatedResultKeyResponse<ListWorkflowsResponse, WorkflowListItem>(this, (i) => i.Items);

        internal ListWorkflowsPaginator(IAmazonOmics client, ListWorkflowsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListWorkflowsResponse> IPaginator<ListWorkflowsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var startingToken = _request.StartingToken;
            ListWorkflowsResponse response;
            do
            {
                _request.StartingToken = startingToken;
                response = _client.ListWorkflows(_request);
                startingToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(startingToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListWorkflowsResponse> IPaginator<ListWorkflowsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var startingToken = _request.StartingToken;
            ListWorkflowsResponse response;
            do
            {
                _request.StartingToken = startingToken;
                response = await _client.ListWorkflowsAsync(_request, cancellationToken).ConfigureAwait(false);
                startingToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(startingToken));
        }
#endif
    }
}