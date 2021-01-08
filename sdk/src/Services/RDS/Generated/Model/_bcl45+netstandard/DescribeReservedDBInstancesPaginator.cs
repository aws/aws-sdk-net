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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Base class for DescribeReservedDBInstances paginators.
    /// </summary>
    internal sealed partial class DescribeReservedDBInstancesPaginator : IPaginator<DescribeReservedDBInstancesResponse>, IDescribeReservedDBInstancesPaginator
    {
        private readonly IAmazonRDS _client;
        private readonly DescribeReservedDBInstancesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeReservedDBInstancesResponse> Responses => new PaginatedResponse<DescribeReservedDBInstancesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ReservedDBInstances
        /// </summary>
        public IPaginatedEnumerable<ReservedDBInstance> ReservedDBInstances => 
            new PaginatedResultKeyResponse<DescribeReservedDBInstancesResponse, ReservedDBInstance>(this, (i) => i.ReservedDBInstances);

        internal DescribeReservedDBInstancesPaginator(IAmazonRDS client, DescribeReservedDBInstancesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeReservedDBInstancesResponse> IPaginator<DescribeReservedDBInstancesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            DescribeReservedDBInstancesResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.DescribeReservedDBInstances(_request);
                marker = response.Marker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeReservedDBInstancesResponse> IPaginator<DescribeReservedDBInstancesResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            DescribeReservedDBInstancesResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.DescribeReservedDBInstancesAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.Marker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
    }
}
#endif