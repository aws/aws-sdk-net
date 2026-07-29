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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Base class for DescribeQev2IdcApplications paginators.
    /// </summary>
    internal sealed partial class DescribeQev2IdcApplicationsPaginator : IPaginator<DescribeQev2IdcApplicationsResponse>, IDescribeQev2IdcApplicationsPaginator
    {
        private readonly IAmazonRedshift _client;
        private readonly DescribeQev2IdcApplicationsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeQev2IdcApplicationsResponse> Responses => new PaginatedResponse<DescribeQev2IdcApplicationsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Qev2IdcApplications
        /// </summary>
        public IPaginatedEnumerable<Qev2IdcApplication> Qev2IdcApplications => 
            new PaginatedResultKeyResponse<DescribeQev2IdcApplicationsResponse, Qev2IdcApplication>(this, (i) => i.Qev2IdcApplications ?? new List<Qev2IdcApplication>());

        internal DescribeQev2IdcApplicationsPaginator(IAmazonRedshift client, DescribeQev2IdcApplicationsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeQev2IdcApplicationsResponse> IPaginator<DescribeQev2IdcApplicationsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            DescribeQev2IdcApplicationsResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.DescribeQev2IdcApplications(_request);
                marker = response.Marker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeQev2IdcApplicationsResponse> IPaginator<DescribeQev2IdcApplicationsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            DescribeQev2IdcApplicationsResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.DescribeQev2IdcApplicationsAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.Marker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
    }
}