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
    /// Base class for ListGroupsForUser paginators.
    /// </summary>
    internal sealed partial class ListGroupsForUserPaginator : IPaginator<ListGroupsForUserResponse>, IListGroupsForUserPaginator
    {
        private readonly IAmazonIdentityManagementService _client;
        private readonly ListGroupsForUserRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListGroupsForUserResponse> Responses => new PaginatedResponse<ListGroupsForUserResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Groups
        /// </summary>
        public IPaginatedEnumerable<Group> Groups => 
            new PaginatedResultKeyResponse<ListGroupsForUserResponse, Group>(this, (i) => i.Groups ?? new List<Group>());

        internal ListGroupsForUserPaginator(IAmazonIdentityManagementService client, ListGroupsForUserRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListGroupsForUserResponse> IPaginator<ListGroupsForUserResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListGroupsForUserResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListGroupsForUser(_request);
                marker = response.Marker;
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListGroupsForUserResponse> IPaginator<ListGroupsForUserResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListGroupsForUserResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListGroupsForUserAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.Marker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
    }
}