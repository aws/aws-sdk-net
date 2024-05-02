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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Base class for ListJobsByPipeline paginators.
    /// </summary>
    internal sealed partial class ListJobsByPipelinePaginator : IPaginator<ListJobsByPipelineResponse>, IListJobsByPipelinePaginator
    {
        private readonly IAmazonElasticTranscoder _client;
        private readonly ListJobsByPipelineRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListJobsByPipelineResponse> Responses => new PaginatedResponse<ListJobsByPipelineResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Jobs
        /// </summary>
        public IPaginatedEnumerable<Job> Jobs => 
            new PaginatedResultKeyResponse<ListJobsByPipelineResponse, Job>(this, (i) => i.Jobs ?? new List<Job>());

        internal ListJobsByPipelinePaginator(IAmazonElasticTranscoder client, ListJobsByPipelineRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListJobsByPipelineResponse> IPaginator<ListJobsByPipelineResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var pageToken = _request.PageToken;
            ListJobsByPipelineResponse response;
            do
            {
                _request.PageToken = pageToken;
                response = _client.ListJobsByPipeline(_request);
                pageToken = response.NextPageToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(pageToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListJobsByPipelineResponse> IPaginator<ListJobsByPipelineResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var pageToken = _request.PageToken;
            ListJobsByPipelineResponse response;
            do
            {
                _request.PageToken = pageToken;
                response = await _client.ListJobsByPipelineAsync(_request, cancellationToken).ConfigureAwait(false);
                pageToken = response.NextPageToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(pageToken));
        }
#endif
    }
}