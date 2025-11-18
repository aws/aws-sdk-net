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
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;
using Amazon.S3.Transfer.Internal;
using Amazon.S3.Util;
using Amazon.Util;
using Amazon.Util.Internal;

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
    /// 	you should clean up any multipart uploads	that are incomplete.
    /// 	</para>
    /// </remarks>
    public partial class TransferUtility : ITransferUtility
    {
        #region Upload
        /// <inheritdoc/>
        public async Task UploadAsync(string filePath, string bucketName, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = ConstructUploadRequest(filePath, bucketName);
            await UploadAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task UploadAsync(string filePath, string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = ConstructUploadRequest(filePath, bucketName,key);
            await UploadAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task UploadAsync(Stream stream, string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = ConstructUploadRequest(stream, bucketName, key);
            await UploadAsync(request, cancellationToken).ConfigureAwait(false);
        }



        /// <inheritdoc/>
        public async Task UploadAsync(TransferUtilityUploadRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            using(CreateSpan(nameof(UploadAsync), null, Amazon.Runtime.Telemetry.Tracing.SpanKind.CLIENT))
            {
                CheckForBlockedArn(request.BucketName, "Upload");
                var command = GetUploadCommand(request, null);
                await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<TransferUtilityUploadResponse> UploadWithResponseAsync(string filePath, string bucketName, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = ConstructUploadRequest(filePath, bucketName);
            return await UploadWithResponseAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<TransferUtilityUploadResponse> UploadWithResponseAsync(string filePath, string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = ConstructUploadRequest(filePath, bucketName, key);
            return await UploadWithResponseAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<TransferUtilityUploadResponse> UploadWithResponseAsync(Stream stream, string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = ConstructUploadRequest(stream, bucketName, key);
            return await UploadWithResponseAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<TransferUtilityUploadResponse> UploadWithResponseAsync(TransferUtilityUploadRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            using(CreateSpan(nameof(UploadWithResponseAsync), null, Amazon.Runtime.Telemetry.Tracing.SpanKind.CLIENT))
            {
                CheckForBlockedArn(request.BucketName, "Upload");
                var command = GetUploadCommand(request, null);
                return await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }
    #endregion

        #region AbortMultipartUploads
        /// <inheritdoc/>
        public async Task AbortMultipartUploadsAsync(string bucketName, DateTime initiatedDate, CancellationToken cancellationToken = default(CancellationToken))
        {
            using(CreateSpan(nameof(AbortMultipartUploadsAsync), null, Amazon.Runtime.Telemetry.Tracing.SpanKind.CLIENT))
            {
                CheckForBlockedArn(bucketName, "AbortMultipartUploads");
                var request = new TransferUtilityAbortMultipartUploadRequest
                {
                    BucketName = bucketName,
                    InitiatedDate = initiatedDate
                };
                var command = new AbortMultipartUploadsCommand(this._s3Client, request, this._config);
                await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task AbortMultipartUploadsAsync(TransferUtilityAbortMultipartUploadRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            using(CreateSpan(nameof(AbortMultipartUploadsAsync), null, Amazon.Runtime.Telemetry.Tracing.SpanKind.CLIENT))
            {
                CheckForBlockedArn(request.BucketName, "AbortMultipartUploads");
                var command = new AbortMultipartUploadsCommand(this._s3Client, request, this._config);
                await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }
        #endregion

        #region Download

        /// <inheritdoc/>
        public async Task DownloadAsync(TransferUtilityDownloadRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            using(CreateSpan(nameof(DownloadAsync), null, Amazon.Runtime.Telemetry.Tracing.SpanKind.CLIENT))
            {
                CheckForBlockedArn(request.BucketName, "Download");
                var command = new DownloadCommand(this._s3Client, request);
                await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<TransferUtilityDownloadResponse> DownloadWithResponseAsync(string filePath, string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = ConstructDownloadRequest(filePath, bucketName, key);
            return await DownloadWithResponseAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<TransferUtilityDownloadResponse> DownloadWithResponseAsync(TransferUtilityDownloadRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            using(CreateSpan(nameof(DownloadWithResponseAsync), null, Amazon.Runtime.Telemetry.Tracing.SpanKind.CLIENT))
            {
                CheckForBlockedArn(request.BucketName, "Download");
                var command = new MultipartDownloadCommand(this._s3Client, request, this._config);
                return await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

    #endregion

        #region OpenStream
        /// <inheritdoc/>
        public async Task<Stream> OpenStreamAsync(string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            TransferUtilityOpenStreamRequest request = new TransferUtilityOpenStreamRequest()
            {
                BucketName = bucketName,
                Key = key
            };
            return await OpenStreamAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<Stream> OpenStreamAsync(TransferUtilityOpenStreamRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            using(CreateSpan(nameof(OpenStreamAsync), null, Amazon.Runtime.Telemetry.Tracing.SpanKind.CLIENT))
            {
                CheckForBlockedArn(request.BucketName, "OpenStream");
                OpenStreamCommand command = new OpenStreamCommand(this._s3Client, request);
                await command.ExecuteAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
                return command.ResponseStream;
            }
        }

        /// <inheritdoc/>
        public async Task<TransferUtilityOpenStreamResponse> OpenStreamWithResponseAsync(string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            TransferUtilityOpenStreamRequest request = new TransferUtilityOpenStreamRequest()
            {
                BucketName = bucketName,
                Key = key
            };
            return await OpenStreamWithResponseAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<TransferUtilityOpenStreamResponse> OpenStreamWithResponseAsync(TransferUtilityOpenStreamRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            using(CreateSpan(nameof(OpenStreamWithResponseAsync), null, Amazon.Runtime.Telemetry.Tracing.SpanKind.CLIENT))
            {
                CheckForBlockedArn(request.BucketName, "OpenStreamWithResponse");
                OpenStreamWithResponseCommand command = new OpenStreamWithResponseCommand(this._s3Client, request, this._config);
                return await command.ExecuteAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
            }
        }

        #endregion

        #region DownloadDirectory

        /// <inheritdoc/>
        public async Task<TransferUtilityDownloadDirectoryResponse> DownloadDirectoryWithResponseAsync(string bucketName, string s3Directory, string localDirectory, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = ConstructDownloadDirectoryRequest(bucketName, s3Directory, localDirectory);
            return await DownloadDirectoryWithResponseAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<TransferUtilityDownloadDirectoryResponse> DownloadDirectoryWithResponseAsync(TransferUtilityDownloadDirectoryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            using(CreateSpan(nameof(DownloadDirectoryWithResponseAsync), null, Amazon.Runtime.Telemetry.Tracing.SpanKind.CLIENT))
            {
                CheckForBlockedArn(request.BucketName, "DownloadDirectory");
                var command = new DownloadDirectoryCommand(this._s3Client, request, this._config, true);
                command.DownloadFilesConcurrently = request.DownloadFilesConcurrently;
                return await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        internal BaseCommand<TransferUtilityUploadResponse> GetUploadCommand(TransferUtilityUploadRequest request, SemaphoreSlim asyncThrottler)
        {
            validate(request);
            if (IsMultipartUpload(request))
            {
                var command = new MultipartUploadCommand(this._s3Client, this._config, request);
                command.AsyncThrottler = asyncThrottler;
                return command;
            }
            else
            {
                var command = new SimpleUploadCommand(this._s3Client, this._config, request);
                command.AsyncThrottler = asyncThrottler;
                return command;
            }
        }
    }
}
