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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Base class for ListStreamingDistributions paginators.
    /// </summary>
    internal sealed partial class ListStreamingDistributionsPaginator : IPaginator<ListStreamingDistributionsResponse>, IListStreamingDistributionsPaginator
    {
        private readonly IAmazonCloudFront _client;
        private readonly ListStreamingDistributionsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListStreamingDistributionsResponse> Responses => new PaginatedResponse<ListStreamingDistributionsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Items
        /// </summary>
        public IPaginatedEnumerable<StreamingDistributionSummary> Items => 
            new PaginatedResultKeyResponse<ListStreamingDistributionsResponse, StreamingDistributionSummary>(this, (i) => i.StreamingDistributionList.Items);

        internal ListStreamingDistributionsPaginator(IAmazonCloudFront client, ListStreamingDistributionsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListStreamingDistributionsResponse> IPaginator<ListStreamingDistributionsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListStreamingDistributionsResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListStreamingDistributions(_request);
                marker = response.StreamingDistributionList.NextMarker;
                yield return response;
            }
            while (response.StreamingDistributionList.IsTruncated);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListStreamingDistributionsResponse> IPaginator<ListStreamingDistributionsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListStreamingDistributionsResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListStreamingDistributionsAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.StreamingDistributionList.NextMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (response.StreamingDistributionList.IsTruncated);
        }
#endif
    }
}
#endif