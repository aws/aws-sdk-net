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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Base class for GetUsagePlanKeys paginators.
    /// </summary>
    internal sealed partial class GetUsagePlanKeysPaginator : IPaginator<GetUsagePlanKeysResponse>, IGetUsagePlanKeysPaginator
    {
        private readonly IAmazonAPIGateway _client;
        private readonly GetUsagePlanKeysRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<GetUsagePlanKeysResponse> Responses => new PaginatedResponse<GetUsagePlanKeysResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Items
        /// </summary>
        public IPaginatedEnumerable<UsagePlanKey> Items => 
            new PaginatedResultKeyResponse<GetUsagePlanKeysResponse, UsagePlanKey>(this, (i) => i.Items);

        internal GetUsagePlanKeysPaginator(IAmazonAPIGateway client, GetUsagePlanKeysRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<GetUsagePlanKeysResponse> IPaginator<GetUsagePlanKeysResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var position = _request.Position;
            GetUsagePlanKeysResponse response;
            do
            {
                _request.Position = position;
                response = _client.GetUsagePlanKeys(_request);
                position = response.Position;
                yield return response;
            }
            while (!string.IsNullOrEmpty(position));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<GetUsagePlanKeysResponse> IPaginator<GetUsagePlanKeysResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var position = _request.Position;
            GetUsagePlanKeysResponse response;
            do
            {
                _request.Position = position;
                response = await _client.GetUsagePlanKeysAsync(_request, cancellationToken).ConfigureAwait(false);
                position = response.Position;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(position));
        }
#endif
    }
}
#endif