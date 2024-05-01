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
 * Do not modify this file. This file is generated from the migrationhuborchestrator-2021-08-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// Base class for ListWorkflowStepGroups paginators.
    /// </summary>
    internal sealed partial class ListWorkflowStepGroupsPaginator : IPaginator<ListWorkflowStepGroupsResponse>, IListWorkflowStepGroupsPaginator
    {
        private readonly IAmazonMigrationHubOrchestrator _client;
        private readonly ListWorkflowStepGroupsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListWorkflowStepGroupsResponse> Responses => new PaginatedResponse<ListWorkflowStepGroupsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the WorkflowStepGroupsSummary
        /// </summary>
        public IPaginatedEnumerable<WorkflowStepGroupSummary> WorkflowStepGroupsSummary => 
            new PaginatedResultKeyResponse<ListWorkflowStepGroupsResponse, WorkflowStepGroupSummary>(this, (i) => i.WorkflowStepGroupsSummary ?? new List<WorkflowStepGroupSummary>());

        internal ListWorkflowStepGroupsPaginator(IAmazonMigrationHubOrchestrator client, ListWorkflowStepGroupsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListWorkflowStepGroupsResponse> IPaginator<ListWorkflowStepGroupsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListWorkflowStepGroupsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListWorkflowStepGroups(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListWorkflowStepGroupsResponse> IPaginator<ListWorkflowStepGroupsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListWorkflowStepGroupsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListWorkflowStepGroupsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}