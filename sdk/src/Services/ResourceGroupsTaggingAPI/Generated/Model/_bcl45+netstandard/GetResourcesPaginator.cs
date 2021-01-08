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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Base class for GetResources paginators.
    /// </summary>
    internal sealed partial class GetResourcesPaginator : IPaginator<GetResourcesResponse>, IGetResourcesPaginator
    {
        private readonly IAmazonResourceGroupsTaggingAPI _client;
        private readonly GetResourcesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<GetResourcesResponse> Responses => new PaginatedResponse<GetResourcesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ResourceTagMappingList
        /// </summary>
        public IPaginatedEnumerable<ResourceTagMapping> ResourceTagMappingList => 
            new PaginatedResultKeyResponse<GetResourcesResponse, ResourceTagMapping>(this, (i) => i.ResourceTagMappingList);

        internal GetResourcesPaginator(IAmazonResourceGroupsTaggingAPI client, GetResourcesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<GetResourcesResponse> IPaginator<GetResourcesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var paginationToken = _request.PaginationToken;
            GetResourcesResponse response;
            do
            {
                _request.PaginationToken = paginationToken;
                response = _client.GetResources(_request);
                paginationToken = response.PaginationToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(paginationToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<GetResourcesResponse> IPaginator<GetResourcesResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var paginationToken = _request.PaginationToken;
            GetResourcesResponse response;
            do
            {
                _request.PaginationToken = paginationToken;
                response = await _client.GetResourcesAsync(_request, cancellationToken).ConfigureAwait(false);
                paginationToken = response.PaginationToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(paginationToken));
        }
#endif
    }
}
#endif