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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Paginator for the ListAttachedUserPolicies operation
    /// </summary>
    internal sealed partial class ListAttachedUserPoliciesPaginator : IPaginator<ListAttachedUserPoliciesResponse>, IListAttachedUserPoliciesPaginator
    {
        private readonly IAmazonIdentityManagementService _client;
        private readonly ListAttachedUserPoliciesRequest _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListAttachedUserPoliciesResponse> Responses => new PaginatedResponse<ListAttachedUserPoliciesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the AttachedPolicies
        /// </summary>
        public IPaginatedEnumerable<AttachedPolicyType> AttachedPolicies =>
            new PaginatedResultKeyResponse<ListAttachedUserPoliciesResponse, AttachedPolicyType>(this, (i) => i.AttachedPolicies ?? new List<AttachedPolicyType>());

        internal ListAttachedUserPoliciesPaginator(IAmazonIdentityManagementService client, ListAttachedUserPoliciesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if NETFRAMEWORK
        IEnumerable<ListAttachedUserPoliciesResponse> IPaginator<ListAttachedUserPoliciesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.Marker;
            ListAttachedUserPoliciesResponse response;
            do
            {
                _request.Marker = nextToken;
                response = _client.ListAttachedUserPolicies(_request);
                nextToken = response.Marker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListAttachedUserPoliciesResponse> IPaginator<ListAttachedUserPoliciesResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.Marker;
            ListAttachedUserPoliciesResponse response;
            do
            {
                _request.Marker = nextToken;
                response = await _client.ListAttachedUserPoliciesAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.Marker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
