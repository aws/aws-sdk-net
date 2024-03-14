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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Base class for ListRotationOverrides paginators.
    /// </summary>
    internal sealed partial class ListRotationOverridesPaginator : IPaginator<ListRotationOverridesResponse>, IListRotationOverridesPaginator
    {
        private readonly IAmazonSSMContacts _client;
        private readonly ListRotationOverridesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListRotationOverridesResponse> Responses => new PaginatedResponse<ListRotationOverridesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the RotationOverrides
        /// </summary>
        public IPaginatedEnumerable<RotationOverride> RotationOverrides => 
            new PaginatedResultKeyResponse<ListRotationOverridesResponse, RotationOverride>(this, (i) => i.RotationOverrides);

        internal ListRotationOverridesPaginator(IAmazonSSMContacts client, ListRotationOverridesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListRotationOverridesResponse> IPaginator<ListRotationOverridesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListRotationOverridesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListRotationOverrides(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListRotationOverridesResponse> IPaginator<ListRotationOverridesResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListRotationOverridesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListRotationOverridesAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}