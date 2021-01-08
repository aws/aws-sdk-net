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
    /// Base class for ListCloudFrontOriginAccessIdentities paginators.
    /// </summary>
    internal sealed partial class ListCloudFrontOriginAccessIdentitiesPaginator : IPaginator<ListCloudFrontOriginAccessIdentitiesResponse>, IListCloudFrontOriginAccessIdentitiesPaginator
    {
        private readonly IAmazonCloudFront _client;
        private readonly ListCloudFrontOriginAccessIdentitiesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListCloudFrontOriginAccessIdentitiesResponse> Responses => new PaginatedResponse<ListCloudFrontOriginAccessIdentitiesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Items
        /// </summary>
        public IPaginatedEnumerable<CloudFrontOriginAccessIdentitySummary> Items => 
            new PaginatedResultKeyResponse<ListCloudFrontOriginAccessIdentitiesResponse, CloudFrontOriginAccessIdentitySummary>(this, (i) => i.CloudFrontOriginAccessIdentityList.Items);

        internal ListCloudFrontOriginAccessIdentitiesPaginator(IAmazonCloudFront client, ListCloudFrontOriginAccessIdentitiesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListCloudFrontOriginAccessIdentitiesResponse> IPaginator<ListCloudFrontOriginAccessIdentitiesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListCloudFrontOriginAccessIdentitiesResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListCloudFrontOriginAccessIdentities(_request);
                marker = response.CloudFrontOriginAccessIdentityList.NextMarker;
                yield return response;
            }
            while (response.CloudFrontOriginAccessIdentityList.IsTruncated);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListCloudFrontOriginAccessIdentitiesResponse> IPaginator<ListCloudFrontOriginAccessIdentitiesResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListCloudFrontOriginAccessIdentitiesResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListCloudFrontOriginAccessIdentitiesAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.CloudFrontOriginAccessIdentityList.NextMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (response.CloudFrontOriginAccessIdentityList.IsTruncated);
        }
#endif
    }
}
#endif