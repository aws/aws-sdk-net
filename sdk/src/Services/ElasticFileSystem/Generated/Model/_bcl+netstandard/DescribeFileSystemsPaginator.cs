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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Base class for DescribeFileSystems paginators.
    /// </summary>
    internal sealed partial class DescribeFileSystemsPaginator : IPaginator<DescribeFileSystemsResponse>, IDescribeFileSystemsPaginator
    {
        private readonly IAmazonElasticFileSystem _client;
        private readonly DescribeFileSystemsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeFileSystemsResponse> Responses => new PaginatedResponse<DescribeFileSystemsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the FileSystems
        /// </summary>
        public IPaginatedEnumerable<FileSystemDescription> FileSystems => 
            new PaginatedResultKeyResponse<DescribeFileSystemsResponse, FileSystemDescription>(this, (i) => i.FileSystems ?? new List<FileSystemDescription>());

        internal DescribeFileSystemsPaginator(IAmazonElasticFileSystem client, DescribeFileSystemsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeFileSystemsResponse> IPaginator<DescribeFileSystemsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            DescribeFileSystemsResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.DescribeFileSystems(_request);
                marker = response.NextMarker;
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeFileSystemsResponse> IPaginator<DescribeFileSystemsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var marker = _request.Marker;
            DescribeFileSystemsResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.DescribeFileSystemsAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.NextMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(marker));
        }
#endif
    }
}