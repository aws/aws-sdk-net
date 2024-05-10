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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Base class for DescribeUsageLimits paginators.
    /// </summary>
    internal sealed partial class DescribeUsageLimitsPaginator : IPaginator<DescribeUsageLimitsResponse>, IDescribeUsageLimitsPaginator
    {
        private readonly IAmazonRedshift _client;
        private readonly DescribeUsageLimitsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeUsageLimitsResponse> Responses => new PaginatedResponse<DescribeUsageLimitsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the UsageLimits
        /// </summary>
        public IPaginatedEnumerable<UsageLimit> UsageLimits => 
            new PaginatedResultKeyResponse<DescribeUsageLimitsResponse, UsageLimit>(this, (i) => i.UsageLimits ?? new List<UsageLimit>());

        internal DescribeUsageLimitsPaginator(IAmazonRedshift client, DescribeUsageLimitsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeUsageLimitsResponse> IPaginator<DescribeUsageLimitsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            DescribeUsageLimitsResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.DescribeUsageLimits(_request);
                marker = response.Marker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeUsageLimitsResponse> IPaginator<DescribeUsageLimitsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            DescribeUsageLimitsResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.DescribeUsageLimitsAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.Marker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
    }
}