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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Base class for ListConfigurations paginators.
    /// </summary>
    internal sealed partial class ListConfigurationsPaginator : IPaginator<ListConfigurationsResponse>, IListConfigurationsPaginator
    {
        private readonly IAmazonKafka _client;
        private readonly ListConfigurationsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListConfigurationsResponse> Responses => new PaginatedResponse<ListConfigurationsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Configurations
        /// </summary>
        public IPaginatedEnumerable<Configuration> Configurations => 
            new PaginatedResultKeyResponse<ListConfigurationsResponse, Configuration>(this, (i) => i.Configurations);

        internal ListConfigurationsPaginator(IAmazonKafka client, ListConfigurationsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListConfigurationsResponse> IPaginator<ListConfigurationsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListConfigurationsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListConfigurations(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListConfigurationsResponse> IPaginator<ListConfigurationsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListConfigurationsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListConfigurationsAsync(_request, cancellationToken).ConfigureAwait(false);
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