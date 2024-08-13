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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Base class for ListCoverageStatistics paginators.
    /// </summary>
    internal sealed partial class ListCoverageStatisticsPaginator : IPaginator<ListCoverageStatisticsResponse>, IListCoverageStatisticsPaginator
    {
        private readonly IAmazonInspector2 _client;
        private readonly ListCoverageStatisticsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListCoverageStatisticsResponse> Responses => new PaginatedResponse<ListCoverageStatisticsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the CountsByGroup
        /// </summary>
        public IPaginatedEnumerable<Counts> CountsByGroup => 
            new PaginatedResultKeyResponse<ListCoverageStatisticsResponse, Counts>(this, (i) => i.CountsByGroup ?? new List<Counts>());

        internal ListCoverageStatisticsPaginator(IAmazonInspector2 client, ListCoverageStatisticsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListCoverageStatisticsResponse> IPaginator<ListCoverageStatisticsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListCoverageStatisticsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListCoverageStatistics(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListCoverageStatisticsResponse> IPaginator<ListCoverageStatisticsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListCoverageStatisticsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListCoverageStatisticsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}