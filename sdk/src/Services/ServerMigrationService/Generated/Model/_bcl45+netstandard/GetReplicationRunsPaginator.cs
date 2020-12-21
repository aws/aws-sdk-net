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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Base class for GetReplicationRuns paginators.
    /// </summary>
    internal sealed partial class GetReplicationRunsPaginator : IPaginator<GetReplicationRunsResponse>, IGetReplicationRunsPaginator
    {
        private readonly IAmazonServerMigrationService _client;
        private readonly GetReplicationRunsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<GetReplicationRunsResponse> Responses => new PaginatedResponse<GetReplicationRunsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ReplicationRunList
        /// </summary>
        public IPaginatedEnumerable<ReplicationRun> ReplicationRunList => 
            new PaginatedResultKeyResponse<GetReplicationRunsResponse, ReplicationRun>(this, (i) => i.ReplicationRunList);

        internal GetReplicationRunsPaginator(IAmazonServerMigrationService client, GetReplicationRunsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<GetReplicationRunsResponse> IPaginator<GetReplicationRunsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            GetReplicationRunsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.GetReplicationRuns(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<GetReplicationRunsResponse> IPaginator<GetReplicationRunsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            GetReplicationRunsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.GetReplicationRunsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
#endif