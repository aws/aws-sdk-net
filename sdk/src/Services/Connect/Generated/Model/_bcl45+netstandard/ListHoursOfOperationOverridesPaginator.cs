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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Base class for ListHoursOfOperationOverrides paginators.
    /// </summary>
    internal sealed partial class ListHoursOfOperationOverridesPaginator : IPaginator<ListHoursOfOperationOverridesResponse>, IListHoursOfOperationOverridesPaginator
    {
        private readonly IAmazonConnect _client;
        private readonly ListHoursOfOperationOverridesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListHoursOfOperationOverridesResponse> Responses => new PaginatedResponse<ListHoursOfOperationOverridesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the HoursOfOperationOverrideList
        /// </summary>
        public IPaginatedEnumerable<HoursOfOperationOverride> HoursOfOperationOverrideList => 
            new PaginatedResultKeyResponse<ListHoursOfOperationOverridesResponse, HoursOfOperationOverride>(this, (i) => i.HoursOfOperationOverrideList ?? new List<HoursOfOperationOverride>());

        internal ListHoursOfOperationOverridesPaginator(IAmazonConnect client, ListHoursOfOperationOverridesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListHoursOfOperationOverridesResponse> IPaginator<ListHoursOfOperationOverridesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListHoursOfOperationOverridesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListHoursOfOperationOverrides(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListHoursOfOperationOverridesResponse> IPaginator<ListHoursOfOperationOverridesResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListHoursOfOperationOverridesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListHoursOfOperationOverridesAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}