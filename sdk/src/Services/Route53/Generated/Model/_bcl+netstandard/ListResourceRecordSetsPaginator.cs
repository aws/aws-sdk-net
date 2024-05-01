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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53.Model
{
    /// <summary>
    /// Base class for ListResourceRecordSets paginators.
    /// </summary>
    internal sealed partial class ListResourceRecordSetsPaginator : IPaginator<ListResourceRecordSetsResponse>, IListResourceRecordSetsPaginator
    {
        private readonly IAmazonRoute53 _client;
        private readonly ListResourceRecordSetsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListResourceRecordSetsResponse> Responses => new PaginatedResponse<ListResourceRecordSetsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ResourceRecordSets
        /// </summary>
        public IPaginatedEnumerable<ResourceRecordSet> ResourceRecordSets => 
            new PaginatedResultKeyResponse<ListResourceRecordSetsResponse, ResourceRecordSet>(this, (i) => i.ResourceRecordSets ?? new List<ResourceRecordSet>());

        internal ListResourceRecordSetsPaginator(IAmazonRoute53 client, ListResourceRecordSetsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListResourceRecordSetsResponse> IPaginator<ListResourceRecordSetsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var startRecordName = _request.StartRecordName;
            var startRecordType = _request.StartRecordType;
            var startRecordIdentifier = _request.StartRecordIdentifier;
            ListResourceRecordSetsResponse response;
            do
            {
                _request.StartRecordName = startRecordName;
                _request.StartRecordType = startRecordType;
                _request.StartRecordIdentifier = startRecordIdentifier;
                response = _client.ListResourceRecordSets(_request);
                startRecordName = response.NextRecordName;
                startRecordType = response.NextRecordType;
                startRecordIdentifier = response.NextRecordIdentifier;
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListResourceRecordSetsResponse> IPaginator<ListResourceRecordSetsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var startRecordName = _request.StartRecordName;
            var startRecordType = _request.StartRecordType;
            var startRecordIdentifier = _request.StartRecordIdentifier;
            ListResourceRecordSetsResponse response;
            do
            {
                _request.StartRecordName = startRecordName;
                _request.StartRecordType = startRecordType;
                _request.StartRecordIdentifier = startRecordIdentifier;
                response = await _client.ListResourceRecordSetsAsync(_request, cancellationToken).ConfigureAwait(false);
                startRecordName = response.NextRecordName;
                startRecordType = response.NextRecordType;
                startRecordIdentifier = response.NextRecordIdentifier;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
    }
}