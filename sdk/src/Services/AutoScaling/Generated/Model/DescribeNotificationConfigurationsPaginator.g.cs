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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Paginator for the DescribeNotificationConfigurations operation
    /// </summary>
    internal sealed partial class DescribeNotificationConfigurationsPaginator : IPaginator<DescribeNotificationConfigurationsResponse>, IDescribeNotificationConfigurationsPaginator
    {
        private readonly IAmazonAutoScaling _client;
        private readonly DescribeNotificationConfigurationsRequest _request;
        private int _isPaginatorInUse = 0;

        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeNotificationConfigurationsResponse> Responses => new PaginatedResponse<DescribeNotificationConfigurationsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the NotificationConfigurations
        /// </summary>
        public IPaginatedEnumerable<NotificationConfiguration> NotificationConfigurations =>
            new PaginatedResultKeyResponse<DescribeNotificationConfigurationsResponse, NotificationConfiguration>(this, (i) => i.NotificationConfigurations ?? new List<NotificationConfiguration>());

        internal DescribeNotificationConfigurationsPaginator(IAmazonAutoScaling client, DescribeNotificationConfigurationsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if NETFRAMEWORK
        IEnumerable<DescribeNotificationConfigurationsResponse> IPaginator<DescribeNotificationConfigurationsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeNotificationConfigurationsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.DescribeNotificationConfigurations(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeNotificationConfigurationsResponse> IPaginator<DescribeNotificationConfigurationsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeNotificationConfigurationsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.DescribeNotificationConfigurationsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}
