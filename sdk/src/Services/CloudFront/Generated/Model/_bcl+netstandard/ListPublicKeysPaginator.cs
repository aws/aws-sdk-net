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

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Base class for ListPublicKeys paginators.
    /// </summary>
    internal sealed partial class ListPublicKeysPaginator : IPaginator<ListPublicKeysResponse>, IListPublicKeysPaginator
    {
        private readonly IAmazonCloudFront _client;
        private readonly ListPublicKeysRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListPublicKeysResponse> Responses => new PaginatedResponse<ListPublicKeysResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Items
        /// </summary>
        public IPaginatedEnumerable<PublicKeySummary> Items => 
            new PaginatedResultKeyResponse<ListPublicKeysResponse, PublicKeySummary>(this, (i) => i.PublicKeyList.Items ?? new List<PublicKeySummary>());

        internal ListPublicKeysPaginator(IAmazonCloudFront client, ListPublicKeysRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListPublicKeysResponse> IPaginator<ListPublicKeysResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListPublicKeysResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListPublicKeys(_request);
                marker = response.PublicKeyList.NextMarker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListPublicKeysResponse> IPaginator<ListPublicKeysResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListPublicKeysResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListPublicKeysAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.PublicKeyList.NextMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
    }
}