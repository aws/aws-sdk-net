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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Base class for DescribeOrganizationResourceCollectionHealth paginators.
    /// </summary>
    internal sealed partial class DescribeOrganizationResourceCollectionHealthPaginator : IPaginator<DescribeOrganizationResourceCollectionHealthResponse>, IDescribeOrganizationResourceCollectionHealthPaginator
    {
        private readonly IAmazonDevOpsGuru _client;
        private readonly DescribeOrganizationResourceCollectionHealthRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeOrganizationResourceCollectionHealthResponse> Responses => new PaginatedResponse<DescribeOrganizationResourceCollectionHealthResponse>(this);

        /// <summary>
        /// Enumerable containing all of the CloudFormation
        /// </summary>
        public IPaginatedEnumerable<CloudFormationHealth> CloudFormation => 
            new PaginatedResultKeyResponse<DescribeOrganizationResourceCollectionHealthResponse, CloudFormationHealth>(this, (i) => i.CloudFormation);

        /// <summary>
        /// Enumerable containing all of the Account
        /// </summary>
        public IPaginatedEnumerable<AccountHealth> Account => 
            new PaginatedResultKeyResponse<DescribeOrganizationResourceCollectionHealthResponse, AccountHealth>(this, (i) => i.Account);

        /// <summary>
        /// Enumerable containing all of the Service
        /// </summary>
        public IPaginatedEnumerable<ServiceHealth> Service => 
            new PaginatedResultKeyResponse<DescribeOrganizationResourceCollectionHealthResponse, ServiceHealth>(this, (i) => i.Service);

        /// <summary>
        /// Enumerable containing all of the Tags
        /// </summary>
        public IPaginatedEnumerable<TagHealth> Tags => 
            new PaginatedResultKeyResponse<DescribeOrganizationResourceCollectionHealthResponse, TagHealth>(this, (i) => i.Tags);

        internal DescribeOrganizationResourceCollectionHealthPaginator(IAmazonDevOpsGuru client, DescribeOrganizationResourceCollectionHealthRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeOrganizationResourceCollectionHealthResponse> IPaginator<DescribeOrganizationResourceCollectionHealthResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeOrganizationResourceCollectionHealthResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.DescribeOrganizationResourceCollectionHealth(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeOrganizationResourceCollectionHealthResponse> IPaginator<DescribeOrganizationResourceCollectionHealthResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeOrganizationResourceCollectionHealthResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.DescribeOrganizationResourceCollectionHealthAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}