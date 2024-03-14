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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// Base class for ListAssociatedRoute53HealthChecks paginators.
    /// </summary>
    internal sealed partial class ListAssociatedRoute53HealthChecksPaginator : IPaginator<ListAssociatedRoute53HealthChecksResponse>, IListAssociatedRoute53HealthChecksPaginator
    {
        private readonly IAmazonRoute53RecoveryControlConfig _client;
        private readonly ListAssociatedRoute53HealthChecksRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListAssociatedRoute53HealthChecksResponse> Responses => new PaginatedResponse<ListAssociatedRoute53HealthChecksResponse>(this);

        /// <summary>
        /// Enumerable containing all of the HealthCheckIds
        /// </summary>
        public IPaginatedEnumerable<string> HealthCheckIds => 
            new PaginatedResultKeyResponse<ListAssociatedRoute53HealthChecksResponse, string>(this, (i) => i.HealthCheckIds);

        internal ListAssociatedRoute53HealthChecksPaginator(IAmazonRoute53RecoveryControlConfig client, ListAssociatedRoute53HealthChecksRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListAssociatedRoute53HealthChecksResponse> IPaginator<ListAssociatedRoute53HealthChecksResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListAssociatedRoute53HealthChecksResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListAssociatedRoute53HealthChecks(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListAssociatedRoute53HealthChecksResponse> IPaginator<ListAssociatedRoute53HealthChecksResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListAssociatedRoute53HealthChecksResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListAssociatedRoute53HealthChecksAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}