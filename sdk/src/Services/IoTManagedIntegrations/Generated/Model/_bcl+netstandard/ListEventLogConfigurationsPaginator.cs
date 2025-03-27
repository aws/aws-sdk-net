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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Base class for ListEventLogConfigurations paginators.
    /// </summary>
    internal sealed partial class ListEventLogConfigurationsPaginator : IPaginator<ListEventLogConfigurationsResponse>, IListEventLogConfigurationsPaginator
    {
        private readonly IAmazonIoTManagedIntegrations _client;
        private readonly ListEventLogConfigurationsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListEventLogConfigurationsResponse> Responses => new PaginatedResponse<ListEventLogConfigurationsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the EventLogConfigurationList
        /// </summary>
        public IPaginatedEnumerable<EventLogConfigurationSummary> EventLogConfigurationList => 
            new PaginatedResultKeyResponse<ListEventLogConfigurationsResponse, EventLogConfigurationSummary>(this, (i) => i.EventLogConfigurationList ?? new List<EventLogConfigurationSummary>());

        internal ListEventLogConfigurationsPaginator(IAmazonIoTManagedIntegrations client, ListEventLogConfigurationsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListEventLogConfigurationsResponse> IPaginator<ListEventLogConfigurationsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListEventLogConfigurationsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListEventLogConfigurations(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListEventLogConfigurationsResponse> IPaginator<ListEventLogConfigurationsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListEventLogConfigurationsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListEventLogConfigurationsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}