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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Base class for ListAttachedGroupPolicies paginators.
    /// </summary>
    internal sealed partial class ListAttachedGroupPoliciesPaginator : IPaginator<ListAttachedGroupPoliciesResponse>, IListAttachedGroupPoliciesPaginator
    {
        private readonly IAmazonIdentityManagementService _client;
        private readonly ListAttachedGroupPoliciesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListAttachedGroupPoliciesResponse> Responses => new PaginatedResponse<ListAttachedGroupPoliciesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the AttachedPolicies
        /// </summary>
        public IPaginatedEnumerable<AttachedPolicyType> AttachedPolicies => 
            new PaginatedResultKeyResponse<ListAttachedGroupPoliciesResponse, AttachedPolicyType>(this, (i) => i.AttachedPolicies ?? new List<AttachedPolicyType>());

        internal ListAttachedGroupPoliciesPaginator(IAmazonIdentityManagementService client, ListAttachedGroupPoliciesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListAttachedGroupPoliciesResponse> IPaginator<ListAttachedGroupPoliciesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListAttachedGroupPoliciesResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListAttachedGroupPolicies(_request);
                marker = response.Marker;
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListAttachedGroupPoliciesResponse> IPaginator<ListAttachedGroupPoliciesResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListAttachedGroupPoliciesResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListAttachedGroupPoliciesAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.Marker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
    }
}