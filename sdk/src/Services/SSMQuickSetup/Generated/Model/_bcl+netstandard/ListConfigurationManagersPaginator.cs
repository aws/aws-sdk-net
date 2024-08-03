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
 * Do not modify this file. This file is generated from the ssm-quicksetup-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.SSMQuickSetup.Model
{
    /// <summary>
    /// Base class for ListConfigurationManagers paginators.
    /// </summary>
    internal sealed partial class ListConfigurationManagersPaginator : IPaginator<ListConfigurationManagersResponse>, IListConfigurationManagersPaginator
    {
        private readonly IAmazonSSMQuickSetup _client;
        private readonly ListConfigurationManagersRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListConfigurationManagersResponse> Responses => new PaginatedResponse<ListConfigurationManagersResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ConfigurationManagersList
        /// </summary>
        public IPaginatedEnumerable<ConfigurationManagerSummary> ConfigurationManagersList => 
            new PaginatedResultKeyResponse<ListConfigurationManagersResponse, ConfigurationManagerSummary>(this, (i) => i.ConfigurationManagersList ?? new List<ConfigurationManagerSummary>());

        internal ListConfigurationManagersPaginator(IAmazonSSMQuickSetup client, ListConfigurationManagersRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListConfigurationManagersResponse> IPaginator<ListConfigurationManagersResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var startingToken = _request.StartingToken;
            ListConfigurationManagersResponse response;
            do
            {
                _request.StartingToken = startingToken;
                response = _client.ListConfigurationManagers(_request);
                startingToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(startingToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListConfigurationManagersResponse> IPaginator<ListConfigurationManagersResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var startingToken = _request.StartingToken;
            ListConfigurationManagersResponse response;
            do
            {
                _request.StartingToken = startingToken;
                response = await _client.ListConfigurationManagersAsync(_request, cancellationToken).ConfigureAwait(false);
                startingToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(startingToken));
        }
#endif
    }
}