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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Base class for ListMonitoringAlerts paginators.
    /// </summary>
    internal sealed partial class ListMonitoringAlertsPaginator : IPaginator<ListMonitoringAlertsResponse>, IListMonitoringAlertsPaginator
    {
        private readonly IAmazonSageMaker _client;
        private readonly ListMonitoringAlertsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListMonitoringAlertsResponse> Responses => new PaginatedResponse<ListMonitoringAlertsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the MonitoringAlertSummaries
        /// </summary>
        public IPaginatedEnumerable<MonitoringAlertSummary> MonitoringAlertSummaries => 
            new PaginatedResultKeyResponse<ListMonitoringAlertsResponse, MonitoringAlertSummary>(this, (i) => i.MonitoringAlertSummaries);

        internal ListMonitoringAlertsPaginator(IAmazonSageMaker client, ListMonitoringAlertsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListMonitoringAlertsResponse> IPaginator<ListMonitoringAlertsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListMonitoringAlertsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListMonitoringAlerts(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListMonitoringAlertsResponse> IPaginator<ListMonitoringAlertsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListMonitoringAlertsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListMonitoringAlertsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}