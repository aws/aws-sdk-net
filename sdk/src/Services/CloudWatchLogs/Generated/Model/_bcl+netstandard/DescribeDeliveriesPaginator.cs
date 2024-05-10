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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Base class for DescribeDeliveries paginators.
    /// </summary>
    internal sealed partial class DescribeDeliveriesPaginator : IPaginator<DescribeDeliveriesResponse>, IDescribeDeliveriesPaginator
    {
        private readonly IAmazonCloudWatchLogs _client;
        private readonly DescribeDeliveriesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeDeliveriesResponse> Responses => new PaginatedResponse<DescribeDeliveriesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Deliveries
        /// </summary>
        public IPaginatedEnumerable<Delivery> Deliveries => 
            new PaginatedResultKeyResponse<DescribeDeliveriesResponse, Delivery>(this, (i) => i.Deliveries ?? new List<Delivery>());

        internal DescribeDeliveriesPaginator(IAmazonCloudWatchLogs client, DescribeDeliveriesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeDeliveriesResponse> IPaginator<DescribeDeliveriesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeDeliveriesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.DescribeDeliveries(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeDeliveriesResponse> IPaginator<DescribeDeliveriesResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeDeliveriesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.DescribeDeliveriesAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}