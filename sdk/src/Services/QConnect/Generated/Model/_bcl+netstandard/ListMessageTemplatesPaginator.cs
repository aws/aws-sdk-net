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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Base class for ListMessageTemplates paginators.
    /// </summary>
    internal sealed partial class ListMessageTemplatesPaginator : IPaginator<ListMessageTemplatesResponse>, IListMessageTemplatesPaginator
    {
        private readonly IAmazonQConnect _client;
        private readonly ListMessageTemplatesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListMessageTemplatesResponse> Responses => new PaginatedResponse<ListMessageTemplatesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the MessageTemplateSummaries
        /// </summary>
        public IPaginatedEnumerable<MessageTemplateSummary> MessageTemplateSummaries => 
            new PaginatedResultKeyResponse<ListMessageTemplatesResponse, MessageTemplateSummary>(this, (i) => i.MessageTemplateSummaries ?? new List<MessageTemplateSummary>());

        internal ListMessageTemplatesPaginator(IAmazonQConnect client, ListMessageTemplatesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListMessageTemplatesResponse> IPaginator<ListMessageTemplatesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListMessageTemplatesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListMessageTemplates(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListMessageTemplatesResponse> IPaginator<ListMessageTemplatesResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListMessageTemplatesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListMessageTemplatesAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}