#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Base class for ListSecurityProfilesForTarget paginators.
    /// </summary>
    internal sealed partial class ListSecurityProfilesForTargetPaginator : IPaginator<ListSecurityProfilesForTargetResponse>, IListSecurityProfilesForTargetPaginator
    {
        private readonly IAmazonIoT _client;
        private readonly ListSecurityProfilesForTargetRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListSecurityProfilesForTargetResponse> Responses => new PaginatedResponse<ListSecurityProfilesForTargetResponse>(this);

        /// <summary>
        /// Enumerable containing all of the SecurityProfileTargetMappings
        /// </summary>
        public IPaginatedEnumerable<SecurityProfileTargetMapping> SecurityProfileTargetMappings => 
            new PaginatedResultKeyResponse<ListSecurityProfilesForTargetResponse, SecurityProfileTargetMapping>(this, (i) => i.SecurityProfileTargetMappings);

        internal ListSecurityProfilesForTargetPaginator(IAmazonIoT client, ListSecurityProfilesForTargetRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListSecurityProfilesForTargetResponse> IPaginator<ListSecurityProfilesForTargetResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListSecurityProfilesForTargetResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListSecurityProfilesForTarget(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListSecurityProfilesForTargetResponse> IPaginator<ListSecurityProfilesForTargetResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListSecurityProfilesForTargetResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListSecurityProfilesForTargetAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
#endif