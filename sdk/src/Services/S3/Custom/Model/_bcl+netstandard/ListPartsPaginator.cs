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

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.S3.Model
{
    /// <summary>
    /// Base class for ListParts paginators.
    /// </summary>
    internal sealed partial class ListPartsPaginator : IPaginator<ListPartsResponse>, IListPartsPaginator
    {
        private readonly IAmazonS3 _client;
        private readonly ListPartsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListPartsResponse> Responses => new PaginatedResponse<ListPartsResponse>(this);
        
        /// <summary>
        /// Enumerable containing all of the Parts
        /// </summary>
        public IPaginatedEnumerable<PartDetail> Parts => 
            new PaginatedResultKeyResponse<ListPartsResponse, PartDetail>(this, (i) => i.Parts ?? new List<PartDetail>());

        internal ListPartsPaginator(IAmazonS3 client, ListPartsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListPartsResponse> IPaginator<ListPartsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var partNumberMarker = _request.PartNumberMarker;
            ListPartsResponse response;
            do
            {
                _request.PartNumberMarker = partNumberMarker;
                response = _client.ListParts(_request);
                partNumberMarker = response.NextPartNumberMarker.ToString();
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListPartsResponse> IPaginator<ListPartsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var partNumberMarker = _request.PartNumberMarker;
            ListPartsResponse response;
            do
            {
                _request.PartNumberMarker = partNumberMarker;
                response = await _client.ListPartsAsync(_request, cancellationToken).ConfigureAwait(false);
                partNumberMarker = response.NextPartNumberMarker.ToString();
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
    }
}