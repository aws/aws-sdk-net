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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Base class for ListOTAUpdates paginators.
    /// </summary>
    internal sealed partial class ListOTAUpdatesPaginator : IPaginator<ListOTAUpdatesResponse>, IListOTAUpdatesPaginator
    {
        private readonly IAmazonIoT _client;
        private readonly ListOTAUpdatesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListOTAUpdatesResponse> Responses => new PaginatedResponse<ListOTAUpdatesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the OtaUpdates
        /// </summary>
        public IPaginatedEnumerable<OTAUpdateSummary> OtaUpdates => 
            new PaginatedResultKeyResponse<ListOTAUpdatesResponse, OTAUpdateSummary>(this, (i) => i.OtaUpdates);

        internal ListOTAUpdatesPaginator(IAmazonIoT client, ListOTAUpdatesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListOTAUpdatesResponse> IPaginator<ListOTAUpdatesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListOTAUpdatesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListOTAUpdates(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListOTAUpdatesResponse> IPaginator<ListOTAUpdatesResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListOTAUpdatesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListOTAUpdatesAsync(_request, cancellationToken).ConfigureAwait(false);
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