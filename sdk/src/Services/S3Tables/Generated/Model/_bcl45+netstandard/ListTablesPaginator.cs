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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Base class for ListTables paginators.
    /// </summary>
    internal sealed partial class ListTablesPaginator : IPaginator<ListTablesResponse>, IListTablesPaginator
    {
        private readonly IAmazonS3Tables _client;
        private readonly ListTablesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListTablesResponse> Responses => new PaginatedResponse<ListTablesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Tables
        /// </summary>
        public IPaginatedEnumerable<TableSummary> Tables => 
            new PaginatedResultKeyResponse<ListTablesResponse, TableSummary>(this, (i) => i.Tables ?? new List<TableSummary>());

        internal ListTablesPaginator(IAmazonS3Tables client, ListTablesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListTablesResponse> IPaginator<ListTablesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var continuationToken = _request.ContinuationToken;
            ListTablesResponse response;
            do
            {
                _request.ContinuationToken = continuationToken;
                response = _client.ListTables(_request);
                continuationToken = response.ContinuationToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(continuationToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListTablesResponse> IPaginator<ListTablesResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var continuationToken = _request.ContinuationToken;
            ListTablesResponse response;
            do
            {
                _request.ContinuationToken = continuationToken;
                response = await _client.ListTablesAsync(_request, cancellationToken).ConfigureAwait(false);
                continuationToken = response.ContinuationToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(continuationToken));
        }
#endif
    }
}