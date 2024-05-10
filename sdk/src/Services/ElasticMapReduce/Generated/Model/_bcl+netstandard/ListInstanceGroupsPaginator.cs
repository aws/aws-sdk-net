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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Base class for ListInstanceGroups paginators.
    /// </summary>
    internal sealed partial class ListInstanceGroupsPaginator : IPaginator<ListInstanceGroupsResponse>, IListInstanceGroupsPaginator
    {
        private readonly IAmazonElasticMapReduce _client;
        private readonly ListInstanceGroupsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListInstanceGroupsResponse> Responses => new PaginatedResponse<ListInstanceGroupsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the InstanceGroups
        /// </summary>
        public IPaginatedEnumerable<InstanceGroup> InstanceGroups => 
            new PaginatedResultKeyResponse<ListInstanceGroupsResponse, InstanceGroup>(this, (i) => i.InstanceGroups ?? new List<InstanceGroup>());

        internal ListInstanceGroupsPaginator(IAmazonElasticMapReduce client, ListInstanceGroupsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListInstanceGroupsResponse> IPaginator<ListInstanceGroupsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListInstanceGroupsResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListInstanceGroups(_request);
                marker = response.Marker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListInstanceGroupsResponse> IPaginator<ListInstanceGroupsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            ListInstanceGroupsResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListInstanceGroupsAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.Marker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
    }
}