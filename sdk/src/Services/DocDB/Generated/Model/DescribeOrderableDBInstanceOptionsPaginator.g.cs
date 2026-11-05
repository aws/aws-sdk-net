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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Paginator for the DescribeOrderableDBInstanceOptions operation
    /// </summary>
    internal sealed partial class DescribeOrderableDBInstanceOptionsPaginator : IPaginator<DescribeOrderableDBInstanceOptionsResponse>, IDescribeOrderableDBInstanceOptionsPaginator
    {
        private readonly IAmazonDocDB _client;
        private readonly DescribeOrderableDBInstanceOptionsRequest _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeOrderableDBInstanceOptionsResponse> Responses => new PaginatedResponse<DescribeOrderableDBInstanceOptionsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the OrderableDBInstanceOptions
        /// </summary>
        public IPaginatedEnumerable<OrderableDBInstanceOption> OrderableDBInstanceOptions =>
            new PaginatedResultKeyResponse<DescribeOrderableDBInstanceOptionsResponse, OrderableDBInstanceOption>(this, (i) => i.OrderableDBInstanceOptions ?? new List<OrderableDBInstanceOption>());

        internal DescribeOrderableDBInstanceOptionsPaginator(IAmazonDocDB client, DescribeOrderableDBInstanceOptionsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if NETFRAMEWORK
        IEnumerable<DescribeOrderableDBInstanceOptionsResponse> IPaginator<DescribeOrderableDBInstanceOptionsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.Marker;
            DescribeOrderableDBInstanceOptionsResponse response;
            do
            {
                _request.Marker = nextToken;
                response = _client.DescribeOrderableDBInstanceOptions(_request);
                nextToken = response.Marker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeOrderableDBInstanceOptionsResponse> IPaginator<DescribeOrderableDBInstanceOptionsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.Marker;
            DescribeOrderableDBInstanceOptionsResponse response;
            do
            {
                _request.Marker = nextToken;
                response = await _client.DescribeOrderableDBInstanceOptionsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.Marker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
