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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Base class for DescribeEventAggregates paginators.
    /// </summary>
    internal sealed partial class DescribeEventAggregatesPaginator : IPaginator<DescribeEventAggregatesResponse>, IDescribeEventAggregatesPaginator
    {
        private readonly IAmazonAWSHealth _client;
        private readonly DescribeEventAggregatesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeEventAggregatesResponse> Responses => new PaginatedResponse<DescribeEventAggregatesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the EventAggregates
        /// </summary>
        public IPaginatedEnumerable<EventAggregate> EventAggregates => 
            new PaginatedResultKeyResponse<DescribeEventAggregatesResponse, EventAggregate>(this, (i) => i.EventAggregates);

        internal DescribeEventAggregatesPaginator(IAmazonAWSHealth client, DescribeEventAggregatesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeEventAggregatesResponse> IPaginator<DescribeEventAggregatesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeEventAggregatesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.DescribeEventAggregates(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeEventAggregatesResponse> IPaginator<DescribeEventAggregatesResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeEventAggregatesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.DescribeEventAggregatesAsync(_request, cancellationToken).ConfigureAwait(false);
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