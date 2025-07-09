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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Base class for DescribeProductsV2 paginators.
    /// </summary>
    internal sealed partial class DescribeProductsV2Paginator : IPaginator<DescribeProductsV2Response>, IDescribeProductsV2Paginator
    {
        private readonly IAmazonSecurityHub _client;
        private readonly DescribeProductsV2Request _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeProductsV2Response> Responses => new PaginatedResponse<DescribeProductsV2Response>(this);

        /// <summary>
        /// Enumerable containing all of the ProductsV2
        /// </summary>
        public IPaginatedEnumerable<ProductV2> ProductsV2 => 
            new PaginatedResultKeyResponse<DescribeProductsV2Response, ProductV2>(this, (i) => i.ProductsV2 ?? new List<ProductV2>());

        internal DescribeProductsV2Paginator(IAmazonSecurityHub client, DescribeProductsV2Request request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeProductsV2Response> IPaginator<DescribeProductsV2Response>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeProductsV2Response response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.DescribeProductsV2(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeProductsV2Response> IPaginator<DescribeProductsV2Response>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeProductsV2Response response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.DescribeProductsV2Async(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}