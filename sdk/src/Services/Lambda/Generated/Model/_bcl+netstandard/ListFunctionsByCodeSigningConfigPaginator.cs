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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Base class for ListFunctionsByCodeSigningConfig paginators.
    /// </summary>
    internal sealed partial class ListFunctionsByCodeSigningConfigPaginator : IPaginator<ListFunctionsByCodeSigningConfigResponse>, IListFunctionsByCodeSigningConfigPaginator
    {
        private readonly IAmazonLambda _client;
        private readonly ListFunctionsByCodeSigningConfigRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListFunctionsByCodeSigningConfigResponse> Responses => new PaginatedResponse<ListFunctionsByCodeSigningConfigResponse>(this);

        /// <summary>
        /// Enumerable containing all of the FunctionArns
        /// </summary>
        public IPaginatedEnumerable<string> FunctionArns => 
            new PaginatedResultKeyResponse<ListFunctionsByCodeSigningConfigResponse, string>(this, (i) => i.FunctionArns ?? new List<string>());

        internal ListFunctionsByCodeSigningConfigPaginator(IAmazonLambda client, ListFunctionsByCodeSigningConfigRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListFunctionsByCodeSigningConfigResponse> IPaginator<ListFunctionsByCodeSigningConfigResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListFunctionsByCodeSigningConfigResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListFunctionsByCodeSigningConfig(_request);
                marker = response.NextMarker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListFunctionsByCodeSigningConfigResponse> IPaginator<ListFunctionsByCodeSigningConfigResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListFunctionsByCodeSigningConfigResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListFunctionsByCodeSigningConfigAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.NextMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
    }
}