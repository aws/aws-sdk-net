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
    /// Base class for ListCisScanResultsAggregatedByChecks paginators.
    /// </summary>
    internal sealed partial class ListCisScanResultsAggregatedByChecksPaginator : IPaginator<ListCisScanResultsAggregatedByChecksResponse>, IListCisScanResultsAggregatedByChecksPaginator
    {
        private readonly IAmazonInspector2 _client;
        private readonly ListCisScanResultsAggregatedByChecksRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListCisScanResultsAggregatedByChecksResponse> Responses => new PaginatedResponse<ListCisScanResultsAggregatedByChecksResponse>(this);

        /// <summary>
        /// Enumerable containing all of the CheckAggregations
        /// </summary>
        public IPaginatedEnumerable<CisCheckAggregation> CheckAggregations => 
            new PaginatedResultKeyResponse<ListCisScanResultsAggregatedByChecksResponse, CisCheckAggregation>(this, (i) => i.CheckAggregations ?? new List<CisCheckAggregation>());

        internal ListCisScanResultsAggregatedByChecksPaginator(IAmazonInspector2 client, ListCisScanResultsAggregatedByChecksRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListCisScanResultsAggregatedByChecksResponse> IPaginator<ListCisScanResultsAggregatedByChecksResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListCisScanResultsAggregatedByChecksResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListCisScanResultsAggregatedByChecks(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListCisScanResultsAggregatedByChecksResponse> IPaginator<ListCisScanResultsAggregatedByChecksResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListCisScanResultsAggregatedByChecksResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListCisScanResultsAggregatedByChecksAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}