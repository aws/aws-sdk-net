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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Base class for ListReputationEntities paginators.
    /// </summary>
    internal sealed partial class ListReputationEntitiesPaginator : IPaginator<ListReputationEntitiesResponse>, IListReputationEntitiesPaginator
    {
        private readonly IAmazonSimpleEmailServiceV2 _client;
        private readonly ListReputationEntitiesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListReputationEntitiesResponse> Responses => new PaginatedResponse<ListReputationEntitiesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ReputationEntities
        /// </summary>
        public IPaginatedEnumerable<ReputationEntity> ReputationEntities => 
            new PaginatedResultKeyResponse<ListReputationEntitiesResponse, ReputationEntity>(this, (i) => i.ReputationEntities ?? new List<ReputationEntity>());

        internal ListReputationEntitiesPaginator(IAmazonSimpleEmailServiceV2 client, ListReputationEntitiesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListReputationEntitiesResponse> IPaginator<ListReputationEntitiesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListReputationEntitiesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListReputationEntities(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListReputationEntitiesResponse> IPaginator<ListReputationEntitiesResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListReputationEntitiesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListReputationEntitiesAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}