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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// Base class for ListIdMappingJobs paginators.
    /// </summary>
    internal sealed partial class ListIdMappingJobsPaginator : IPaginator<ListIdMappingJobsResponse>, IListIdMappingJobsPaginator
    {
        private readonly IAmazonEntityResolution _client;
        private readonly ListIdMappingJobsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListIdMappingJobsResponse> Responses => new PaginatedResponse<ListIdMappingJobsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Jobs
        /// </summary>
        public IPaginatedEnumerable<JobSummary> Jobs => 
            new PaginatedResultKeyResponse<ListIdMappingJobsResponse, JobSummary>(this, (i) => i.Jobs ?? new List<JobSummary>());

        internal ListIdMappingJobsPaginator(IAmazonEntityResolution client, ListIdMappingJobsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListIdMappingJobsResponse> IPaginator<ListIdMappingJobsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListIdMappingJobsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListIdMappingJobs(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListIdMappingJobsResponse> IPaginator<ListIdMappingJobsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListIdMappingJobsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListIdMappingJobsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}