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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Base class for ListJobTemplates paginators.
    /// </summary>
    internal sealed partial class ListJobTemplatesPaginator : IPaginator<ListJobTemplatesResponse>, IListJobTemplatesPaginator
    {
        private readonly IAmazonMediaConvert _client;
        private readonly ListJobTemplatesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListJobTemplatesResponse> Responses => new PaginatedResponse<ListJobTemplatesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the JobTemplates
        /// </summary>
        public IPaginatedEnumerable<JobTemplate> JobTemplates => 
            new PaginatedResultKeyResponse<ListJobTemplatesResponse, JobTemplate>(this, (i) => i.JobTemplates);

        internal ListJobTemplatesPaginator(IAmazonMediaConvert client, ListJobTemplatesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListJobTemplatesResponse> IPaginator<ListJobTemplatesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListJobTemplatesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListJobTemplates(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListJobTemplatesResponse> IPaginator<ListJobTemplatesResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListJobTemplatesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListJobTemplatesAsync(_request, cancellationToken).ConfigureAwait(false);
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