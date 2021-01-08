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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Base class for DescribeClusterTracks paginators.
    /// </summary>
    internal sealed partial class DescribeClusterTracksPaginator : IPaginator<DescribeClusterTracksResponse>, IDescribeClusterTracksPaginator
    {
        private readonly IAmazonRedshift _client;
        private readonly DescribeClusterTracksRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeClusterTracksResponse> Responses => new PaginatedResponse<DescribeClusterTracksResponse>(this);

        /// <summary>
        /// Enumerable containing all of the MaintenanceTracks
        /// </summary>
        public IPaginatedEnumerable<MaintenanceTrack> MaintenanceTracks => 
            new PaginatedResultKeyResponse<DescribeClusterTracksResponse, MaintenanceTrack>(this, (i) => i.MaintenanceTracks);

        internal DescribeClusterTracksPaginator(IAmazonRedshift client, DescribeClusterTracksRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeClusterTracksResponse> IPaginator<DescribeClusterTracksResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            DescribeClusterTracksResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.DescribeClusterTracks(_request);
                marker = response.Marker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeClusterTracksResponse> IPaginator<DescribeClusterTracksResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            DescribeClusterTracksResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.DescribeClusterTracksAsync(_request, cancellationToken).ConfigureAwait(false);
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