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
    /// Base class for ListMultipartUploads paginators.
    /// </summary>
    internal sealed partial class ListMultipartUploadsPaginator : IPaginator<ListMultipartUploadsResponse>, IListMultipartUploadsPaginator
    {
        private readonly IAmazonS3 _client;
        private readonly ListMultipartUploadsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListMultipartUploadsResponse> Responses => new PaginatedResponse<ListMultipartUploadsResponse>(this);
        
        /// <summary>
        /// Enumerable containing all of the Uploads
        /// </summary>
        public IPaginatedEnumerable<MultipartUpload> Uploads => 
            new PaginatedResultKeyResponse<ListMultipartUploadsResponse, MultipartUpload>(this, (i) => i.MultipartUploads ?? new List<MultipartUpload>());

        /// <summary>
        /// Enumerable containing all of the CommonPrefixes
        /// </summary>
        public IPaginatedEnumerable<string> CommonPrefixes => 
            new PaginatedResultKeyResponse<ListMultipartUploadsResponse, string>(this, (i) => i.CommonPrefixes ?? new List<string>());

        internal ListMultipartUploadsPaginator(IAmazonS3 client, ListMultipartUploadsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListMultipartUploadsResponse> IPaginator<ListMultipartUploadsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var keyMarker = _request.KeyMarker;
            var uploadIdMarker = _request.UploadIdMarker;
            ListMultipartUploadsResponse response;
            do
            {
                _request.KeyMarker = keyMarker;
                _request.UploadIdMarker = uploadIdMarker;
                response = _client.ListMultipartUploads(_request);
                keyMarker = response.NextKeyMarker;
                uploadIdMarker = response.NextUploadIdMarker;
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListMultipartUploadsResponse> IPaginator<ListMultipartUploadsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var keyMarker = _request.KeyMarker;
            var uploadIdMarker = _request.UploadIdMarker;
            ListMultipartUploadsResponse response;
            do
            {
                _request.KeyMarker = keyMarker;
                _request.UploadIdMarker = uploadIdMarker;
                response = await _client.ListMultipartUploadsAsync(_request, cancellationToken).ConfigureAwait(false);
                keyMarker = response.NextKeyMarker;
                uploadIdMarker = response.NextUploadIdMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (response.IsTruncated.GetValueOrDefault());
        }
#endif
    }
}