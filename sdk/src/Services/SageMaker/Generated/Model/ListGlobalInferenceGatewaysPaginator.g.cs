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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Paginator for the ListGlobalInferenceGateways operation
    /// </summary>
    internal sealed partial class ListGlobalInferenceGatewaysPaginator : IPaginator<ListGlobalInferenceGatewaysResponse>, IListGlobalInferenceGatewaysPaginator
    {
        private readonly IAmazonSageMaker _client;
        private readonly ListGlobalInferenceGatewaysRequest _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListGlobalInferenceGatewaysResponse> Responses => new PaginatedResponse<ListGlobalInferenceGatewaysResponse>(this);

        /// <summary>
        /// Enumerable containing all of the GlobalInferenceGatewaySummaries
        /// </summary>
        public IPaginatedEnumerable<GlobalInferenceGatewaySummary> GlobalInferenceGatewaySummaries =>
            new PaginatedResultKeyResponse<ListGlobalInferenceGatewaysResponse, GlobalInferenceGatewaySummary>(this, (i) => i.GlobalInferenceGatewaySummaries ?? new List<GlobalInferenceGatewaySummary>());

        internal ListGlobalInferenceGatewaysPaginator(IAmazonSageMaker client, ListGlobalInferenceGatewaysRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if NETFRAMEWORK
        IEnumerable<ListGlobalInferenceGatewaysResponse> IPaginator<ListGlobalInferenceGatewaysResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListGlobalInferenceGatewaysResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListGlobalInferenceGateways(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListGlobalInferenceGatewaysResponse> IPaginator<ListGlobalInferenceGatewaysResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListGlobalInferenceGatewaysResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListGlobalInferenceGatewaysAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
