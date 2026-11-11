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
    /// Paginator for the DescribeServerlessV2PlatformVersions operation
    /// </summary>
    internal sealed partial class DescribeServerlessV2PlatformVersionsPaginator : IPaginator<DescribeServerlessV2PlatformVersionsResponse>, IDescribeServerlessV2PlatformVersionsPaginator
    {
        private readonly IAmazonDocDB _client;
        private readonly DescribeServerlessV2PlatformVersionsRequest _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeServerlessV2PlatformVersionsResponse> Responses => new PaginatedResponse<DescribeServerlessV2PlatformVersionsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ServerlessV2PlatformVersions
        /// </summary>
        public IPaginatedEnumerable<ServerlessV2PlatformVersionInfo> ServerlessV2PlatformVersions =>
            new PaginatedResultKeyResponse<DescribeServerlessV2PlatformVersionsResponse, ServerlessV2PlatformVersionInfo>(this, (i) => i.ServerlessV2PlatformVersions ?? new List<ServerlessV2PlatformVersionInfo>());

        internal DescribeServerlessV2PlatformVersionsPaginator(IAmazonDocDB client, DescribeServerlessV2PlatformVersionsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if NETFRAMEWORK
        IEnumerable<DescribeServerlessV2PlatformVersionsResponse> IPaginator<DescribeServerlessV2PlatformVersionsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.Marker;
            DescribeServerlessV2PlatformVersionsResponse response;
            do
            {
                _request.Marker = nextToken;
                response = _client.DescribeServerlessV2PlatformVersions(_request);
                nextToken = response.Marker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeServerlessV2PlatformVersionsResponse> IPaginator<DescribeServerlessV2PlatformVersionsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.Marker;
            DescribeServerlessV2PlatformVersionsResponse response;
            do
            {
                _request.Marker = nextToken;
                response = await _client.DescribeServerlessV2PlatformVersionsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.Marker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
