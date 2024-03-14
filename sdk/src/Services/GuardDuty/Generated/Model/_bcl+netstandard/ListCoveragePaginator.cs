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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Base class for ListCoverage paginators.
    /// </summary>
    internal sealed partial class ListCoveragePaginator : IPaginator<ListCoverageResponse>, IListCoveragePaginator
    {
        private readonly IAmazonGuardDuty _client;
        private readonly ListCoverageRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListCoverageResponse> Responses => new PaginatedResponse<ListCoverageResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Resources
        /// </summary>
        public IPaginatedEnumerable<CoverageResource> Resources => 
            new PaginatedResultKeyResponse<ListCoverageResponse, CoverageResource>(this, (i) => i.Resources);

        internal ListCoveragePaginator(IAmazonGuardDuty client, ListCoverageRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListCoverageResponse> IPaginator<ListCoverageResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListCoverageResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListCoverage(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListCoverageResponse> IPaginator<ListCoverageResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListCoverageResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListCoverageAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}