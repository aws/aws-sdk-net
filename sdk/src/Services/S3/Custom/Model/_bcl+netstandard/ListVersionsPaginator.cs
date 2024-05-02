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
    /// Base class for ListVersions paginators.
    /// </summary>
    internal sealed partial class ListVersionsPaginator : IPaginator<ListVersionsResponse>, IListVersionsPaginator
    {
        private readonly IAmazonS3 _client;
        private readonly ListVersionsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListVersionsResponse> Responses => new PaginatedResponse<ListVersionsResponse>(this);
        
        /// <summary>
        /// Enumerable containing all of the Versions
        /// </summary>
        public IPaginatedEnumerable<S3ObjectVersion> Versions => 
            new PaginatedResultKeyResponse<ListVersionsResponse, S3ObjectVersion>(this, (i) => i.Versions ?? new List<S3ObjectVersion>());

        /// <summary>
        /// Enumerable containing all of the CommonPrefixes
        /// </summary>
        public IPaginatedEnumerable<string> CommonPrefixes => 
            new PaginatedResultKeyResponse<ListVersionsResponse, string>(this, (i) => i.CommonPrefixes ?? new List<string>());

        internal ListVersionsPaginator(IAmazonS3 client, ListVersionsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListVersionsResponse> IPaginator<ListVersionsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var keyMarker = _request.KeyMarker;
            var versionIdMarker = _request.VersionIdMarker;
            ListVersionsResponse response;
            do
            {
                _request.KeyMarker = keyMarker;
                _request.VersionIdMarker = versionIdMarker;
                response = _client.ListVersions(_request);
                keyMarker = response.NextKeyMarker;
                versionIdMarker = response.NextVersionIdMarker;
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListVersionsResponse> IPaginator<ListVersionsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var keyMarker = _request.KeyMarker;
            var versionIdMarker = _request.VersionIdMarker;
            ListVersionsResponse response;
            do
            {
                _request.KeyMarker = keyMarker;
                _request.VersionIdMarker = versionIdMarker;
                response = await _client.ListVersionsAsync(_request, cancellationToken).ConfigureAwait(false);
                keyMarker = response.NextKeyMarker;
                versionIdMarker = response.NextVersionIdMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
    }
}