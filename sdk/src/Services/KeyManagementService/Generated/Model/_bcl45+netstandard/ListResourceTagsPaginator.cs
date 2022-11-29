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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Base class for ListResourceTags paginators.
    /// </summary>
    internal sealed partial class ListResourceTagsPaginator : IPaginator<ListResourceTagsResponse>, IListResourceTagsPaginator
    {
        private readonly IAmazonKeyManagementService _client;
        private readonly ListResourceTagsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListResourceTagsResponse> Responses => new PaginatedResponse<ListResourceTagsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Tags
        /// </summary>
        public IPaginatedEnumerable<Tag> Tags => 
            new PaginatedResultKeyResponse<ListResourceTagsResponse, Tag>(this, (i) => i.Tags);

        internal ListResourceTagsPaginator(IAmazonKeyManagementService client, ListResourceTagsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListResourceTagsResponse> IPaginator<ListResourceTagsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListResourceTagsResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListResourceTags(_request);
                marker = response.NextMarker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListResourceTagsResponse> IPaginator<ListResourceTagsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListResourceTagsResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListResourceTagsAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.NextMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
    }
}