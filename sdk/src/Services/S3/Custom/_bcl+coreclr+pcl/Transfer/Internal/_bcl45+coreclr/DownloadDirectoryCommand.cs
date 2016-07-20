/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Internal
{
    internal partial class DownloadDirectoryCommand : BaseCommand
    {
        TransferUtilityConfig _config;

        public bool DownloadFilesConcurrently { get; set; }

        internal DownloadDirectoryCommand(IAmazonS3 s3Client, TransferUtilityDownloadDirectoryRequest request, TransferUtilityConfig config)
        {
            this._s3Client = s3Client;
            this._request = request;
            this._config = config;
        }

        public override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            ValidateRequest();
            EnsureDirectoryExists(new DirectoryInfo(this._request.LocalDirectory));

            ListObjectsRequest listRequest = ConstructListObjectRequest();
            List<S3Object> objs = new List<S3Object>();
            do
            {
                ListObjectsResponse listResponse = await this._s3Client.ListObjectsAsync(listRequest, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);
                foreach (S3Object s3o in listResponse.S3Objects)
                {
                    if (this._request.IsSetModifiedSinceDate() && s3o.LastModified <= this._request.ModifiedSinceDate)
                        continue;
                    if (this._request.IsSetUnmodifiedSinceDate() && s3o.LastModified > this._request.UnmodifiedSinceDate)
                        continue;

                    this._totalBytes += s3o.Size;
                    objs.Add(s3o);
                }
                listRequest.Marker = listResponse.NextMarker;
            } while (!string.IsNullOrEmpty(listRequest.Marker));
            this._totalNumberOfFilesToDownload = objs.Count;

            SemaphoreSlim asyncThrottler = null;
            CancellationTokenSource internalCts = null;

            try
            {
                asyncThrottler = DownloadFilesConcurrently ?
                    new SemaphoreSlim(this._config.ConcurrentServiceRequests) :
                    new SemaphoreSlim(1);

                internalCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
                var pendingTasks = new List<Task>();
                foreach (S3Object s3o in objs)
                {
                    if (s3o.Key.EndsWith("/", StringComparison.Ordinal))
                        continue;

                    await asyncThrottler.WaitAsync(cancellationToken)
                        .ConfigureAwait(continueOnCapturedContext: false);

                    cancellationToken.ThrowIfCancellationRequested();
                    if (internalCts.IsCancellationRequested)
                    {
                        // Operation cancelled as one of the download requests failed with an exception,
                        // don't schedule any more download tasks.
                        // Don't throw an OperationCanceledException here as we want to process the 
                        // responses and throw the original exception.
                        break;
                    }

                    // Valid for serial uploads when
                    // TransferUtilityDownloadDirectoryRequest.DownloadFilesConcurrently is set to false.
                    this._currentFile = s3o.Key.Substring(listRequest.Prefix.Length);

                    var downloadRequest = ConstructTransferUtilityDownloadRequest(s3o, listRequest.Prefix.Length);
                    var command = new DownloadCommand(this._s3Client, downloadRequest);

                    var task = ExecuteCommandAsync(command, internalCts, asyncThrottler);
                    pendingTasks.Add(task);
                }
                await WhenAllOrFirstExceptionAsync(pendingTasks, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);
            }
            finally
            {
                internalCts.Dispose();
                asyncThrottler.Dispose();
            }
        }
    }
}
