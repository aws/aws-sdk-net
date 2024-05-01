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

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Base class for ListOpenWorkflowExecutions paginators.
    /// </summary>
    internal sealed partial class ListOpenWorkflowExecutionsPaginator : IPaginator<ListOpenWorkflowExecutionsResponse>, IListOpenWorkflowExecutionsPaginator
    {
        private readonly IAmazonSimpleWorkflow _client;
        private readonly ListOpenWorkflowExecutionsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListOpenWorkflowExecutionsResponse> Responses => new PaginatedResponse<ListOpenWorkflowExecutionsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ExecutionInfos
        /// </summary>
        public IPaginatedEnumerable<WorkflowExecutionInfo> ExecutionInfos => 
            new PaginatedResultKeyResponse<ListOpenWorkflowExecutionsResponse, WorkflowExecutionInfo>(this, (i) => i.WorkflowExecutionInfos.ExecutionInfos ?? new List<WorkflowExecutionInfo>());

        internal ListOpenWorkflowExecutionsPaginator(IAmazonSimpleWorkflow client, ListOpenWorkflowExecutionsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListOpenWorkflowExecutionsResponse> IPaginator<ListOpenWorkflowExecutionsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextPageToken = _request.NextPageToken;
            ListOpenWorkflowExecutionsResponse response;
            do
            {
                _request.NextPageToken = nextPageToken;
                response = _client.ListOpenWorkflowExecutions(_request);
                nextPageToken = response.WorkflowExecutionInfos.NextPageToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextPageToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListOpenWorkflowExecutionsResponse> IPaginator<ListOpenWorkflowExecutionsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextPageToken = _request.NextPageToken;
            ListOpenWorkflowExecutionsResponse response;
            do
            {
                _request.NextPageToken = nextPageToken;
                response = await _client.ListOpenWorkflowExecutionsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextPageToken = response.WorkflowExecutionInfos.NextPageToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextPageToken));
        }
#endif
    }
}