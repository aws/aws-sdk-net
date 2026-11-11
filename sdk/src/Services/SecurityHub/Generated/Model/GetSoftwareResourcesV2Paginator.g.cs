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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Paginator for the GetSoftwareResourcesV2 operation
    /// </summary>
    internal sealed partial class GetSoftwareResourcesV2Paginator : IPaginator<GetSoftwareResourcesV2Response>, IGetSoftwareResourcesV2Paginator
    {
        private readonly IAmazonSecurityHub _client;
        private readonly GetSoftwareResourcesV2Request _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<GetSoftwareResourcesV2Response> Responses => new PaginatedResponse<GetSoftwareResourcesV2Response>(this);

        /// <summary>
        /// Enumerable containing all of the SoftwareResources
        /// </summary>
        public IPaginatedEnumerable<SoftwareResourceResult> SoftwareResources =>
            new PaginatedResultKeyResponse<GetSoftwareResourcesV2Response, SoftwareResourceResult>(this, (i) => i.SoftwareResources ?? new List<SoftwareResourceResult>());

        internal GetSoftwareResourcesV2Paginator(IAmazonSecurityHub client, GetSoftwareResourcesV2Request request)
        {
            this._client = client;
            this._request = request;
        }
#if NETFRAMEWORK
        IEnumerable<GetSoftwareResourcesV2Response> IPaginator<GetSoftwareResourcesV2Response>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            GetSoftwareResourcesV2Response response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.GetSoftwareResourcesV2(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<GetSoftwareResourcesV2Response> IPaginator<GetSoftwareResourcesV2Response>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            GetSoftwareResourcesV2Response response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.GetSoftwareResourcesV2Async(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
