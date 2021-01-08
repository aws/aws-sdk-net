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
 * Do not modify this file. This file is generated from the redshift-data-2019-12-20.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.RedshiftDataAPIService.Model
{
    /// <summary>
    /// Base class for DescribeTable paginators.
    /// </summary>
    internal sealed partial class DescribeTablePaginator : IPaginator<DescribeTableResponse>, IDescribeTablePaginator
    {
        private readonly IAmazonRedshiftDataAPIService _client;
        private readonly DescribeTableRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeTableResponse> Responses => new PaginatedResponse<DescribeTableResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ColumnList
        /// </summary>
        public IPaginatedEnumerable<ColumnMetadata> ColumnList => 
            new PaginatedResultKeyResponse<DescribeTableResponse, ColumnMetadata>(this, (i) => i.ColumnList);

        internal DescribeTablePaginator(IAmazonRedshiftDataAPIService client, DescribeTableRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeTableResponse> IPaginator<DescribeTableResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeTableResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.DescribeTable(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeTableResponse> IPaginator<DescribeTableResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeTableResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.DescribeTableAsync(_request, cancellationToken).ConfigureAwait(false);
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