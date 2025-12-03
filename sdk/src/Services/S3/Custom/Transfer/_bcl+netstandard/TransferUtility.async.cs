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
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;
using Amazon.S3.Transfer.Internal;
using Amazon.Util;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// 	<para>
    /// 	Provides a high level utility for managing transfers to and from Amazon S3.
    /// 	</para>
    /// 	<para>
    /// 	<c>TransferUtility</c> provides a simple API for 
    /// 	uploading content to and downloading content
    /// 	from Amazon S3. It makes extensive use of Amazon S3 multipart uploads to
    /// 	achieve enhanced throughput, performance, and reliability. 
    /// 	</para>
    /// 	<para>
    /// 	When uploading large files by specifying file paths instead of a stream, 
    /// 	<c>TransferUtility</c> uses multiple threads to upload
    /// 	multiple parts of a single upload at once. When dealing with large content
    /// 	sizes and high bandwidth, this can increase throughput significantly.
    /// 	</para>
    /// </summary>
    /// <remarks>
    /// 	<para>
    /// 	Transfers are stored in memory. If the application is restarted, 
    /// 	previous transfers are no longer accessible.  In this situation, if necessary, 
    /// 	you should clean up any multipart uploads that are incomplete.
    /// 	</para>
    /// </remarks>
    public partial class TransferUtility : ITransferUtility
    {
        #region UploadDirectory

        /// <inheritdoc/>
        public async Task UploadDirectoryAsync(string directory, string bucketName, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = ConstructUploadDirectoryRequest(directory, bucketName);
            await UploadDirectoryAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task UploadDirectoryAsync(string directory, string bucketName, string searchPattern, SearchOption searchOption, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = ConstructUploadDirectoryRequest(directory, bucketName, searchPattern, searchOption);
            await UploadDirectoryAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task UploadDirectoryAsync(TransferUtilityUploadDirectoryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            using(CreateSpan(nameof(UploadDirectoryAsync), null, Amazon.Runtime.Telemetry.Tracing.SpanKind.CLIENT))
            {
                CheckForBlockedArn(request.BucketName, "UploadDirectory");
                validate(request);
                UploadDirectoryCommand command = new UploadDirectoryCommand(this, this._config, request);
                command.UploadFilesConcurrently = request.UploadFilesConcurrently;
                await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<TransferUtilityUploadDirectoryResponse> UploadDirectoryWithResponseAsync(string directory, string bucketName, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = ConstructUploadDirectoryRequest(directory, bucketName);
            return await UploadDirectoryWithResponseAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<TransferUtilityUploadDirectoryResponse> UploadDirectoryWithResponseAsync(string directory, string bucketName, string searchPattern, SearchOption searchOption, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = ConstructUploadDirectoryRequest(directory, bucketName, searchPattern, searchOption);
            return await UploadDirectoryWithResponseAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<TransferUtilityUploadDirectoryResponse> UploadDirectoryWithResponseAsync(TransferUtilityUploadDirectoryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            using(CreateSpan(nameof(UploadDirectoryWithResponseAsync), null, Amazon.Runtime.Telemetry.Tracing.SpanKind.CLIENT))
            {
                CheckForBlockedArn(request.BucketName, "UploadDirectory");
                validate(request);
                UploadDirectoryCommand command = new UploadDirectoryCommand(this, this._config, request);
                command.UploadFilesConcurrently = request.UploadFilesConcurrently;
                return await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region DownloadDirectory
        /// <inheritdoc/>
        public async Task DownloadDirectoryAsync(string bucketName, string s3Directory, string localDirectory, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = ConstructDownloadDirectoryRequest(bucketName, s3Directory, localDirectory);
            await DownloadDirectoryAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task DownloadDirectoryAsync(TransferUtilityDownloadDirectoryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            using(CreateSpan(nameof(DownloadDirectoryAsync), null, Amazon.Runtime.Telemetry.Tracing.SpanKind.CLIENT))
            {
                CheckForBlockedArn(request.BucketName, "DownloadDirectory");
                var command = new DownloadDirectoryCommand(this._s3Client, request, this._config);
                command.DownloadFilesConcurrently = request.DownloadFilesConcurrently;
                await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }
        #endregion

        #region Download
        /// <inheritdoc/>
        public async Task DownloadAsync(string filePath, string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = ConstructDownloadRequest(filePath, bucketName, key);
            await DownloadAsync(request, cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
