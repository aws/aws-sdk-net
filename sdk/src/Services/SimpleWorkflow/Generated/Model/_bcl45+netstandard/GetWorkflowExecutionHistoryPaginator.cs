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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Base class for GetWorkflowExecutionHistory paginators.
    /// </summary>
    internal sealed partial class GetWorkflowExecutionHistoryPaginator : IPaginator<GetWorkflowExecutionHistoryResponse>, IGetWorkflowExecutionHistoryPaginator
    {
        private readonly IAmazonSimpleWorkflow _client;
        private readonly GetWorkflowExecutionHistoryRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<GetWorkflowExecutionHistoryResponse> Responses => new PaginatedResponse<GetWorkflowExecutionHistoryResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Events
        /// </summary>
        public IPaginatedEnumerable<HistoryEvent> Events => 
            new PaginatedResultKeyResponse<GetWorkflowExecutionHistoryResponse, HistoryEvent>(this, (i) => i.History.Events);

        internal GetWorkflowExecutionHistoryPaginator(IAmazonSimpleWorkflow client, GetWorkflowExecutionHistoryRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<GetWorkflowExecutionHistoryResponse> IPaginator<GetWorkflowExecutionHistoryResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextPageToken = _request.NextPageToken;
            GetWorkflowExecutionHistoryResponse response;
            do
            {
                _request.NextPageToken = nextPageToken;
                response = _client.GetWorkflowExecutionHistory(_request);
                nextPageToken = response.History.NextPageToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextPageToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<GetWorkflowExecutionHistoryResponse> IPaginator<GetWorkflowExecutionHistoryResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextPageToken = _request.NextPageToken;
            GetWorkflowExecutionHistoryResponse response;
            do
            {
                _request.NextPageToken = nextPageToken;
                response = await _client.GetWorkflowExecutionHistoryAsync(_request, cancellationToken).ConfigureAwait(false);
                nextPageToken = response.History.NextPageToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextPageToken));
        }
#endif
    }
}
#endif