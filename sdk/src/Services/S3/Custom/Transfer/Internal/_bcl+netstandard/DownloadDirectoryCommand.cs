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

using Amazon.S3.Model;
using Amazon.S3.Util;
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
            : this(s3Client, request)
        {
            this._config = config;
        }

        public override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            ValidateRequest();
            EnsureDirectoryExists(new DirectoryInfo(this._request.LocalDirectory));

            List<S3Object> objs;
            string listRequestPrefix;
            try
            {
                ListObjectsRequest listRequest = ConstructListObjectRequest();
                listRequestPrefix = listRequest.Prefix;
                objs = await GetS3ObjectsToDownloadAsync(listRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (AmazonS3Exception ex)
            {
                if (ex.StatusCode != System.Net.HttpStatusCode.NotImplemented)
                    throw;

                ListObjectsV2Request listRequestV2 = ConstructListObjectRequestV2();
                listRequestPrefix = listRequestV2.Prefix;
                objs = await GetS3ObjectsToDownloadV2Async(listRequestV2, cancellationToken).ConfigureAwait(false);
            }

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
                    int prefixLength = listRequestPrefix.Length;

                    // If DisableSlashCorrection is enabled (i.e. S3Directory is a key prefix) and it doesn't end with '/' then we need the parent directory to properly construct download path.
                    if (_request.DisableSlashCorrection && !listRequestPrefix.EndsWith("/"))
                    {
                        prefixLength = listRequestPrefix.LastIndexOf("/") + 1;
                    }

                    this._currentFile = s3o.Key.Substring(prefixLength);

                    var downloadRequest = ConstructTransferUtilityDownloadRequest(s3o, prefixLength);
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

        private async Task<List<S3Object>> GetS3ObjectsToDownloadAsync(ListObjectsRequest listRequest, CancellationToken cancellationToken)
        {
            List<S3Object> objs = new List<S3Object>();
            do
            {
                ListObjectsResponse listResponse = await this._s3Client.ListObjectsAsync(listRequest, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);

                if (listResponse.S3Objects != null) 
                {
                    foreach (S3Object s3o in listResponse.S3Objects)
                    {
                        if (ShouldDownload(s3o))
                        {
                            this._totalBytes += s3o.Size.GetValueOrDefault();
                            objs.Add(s3o);
                        }
                    }
                }
                listRequest.Marker = listResponse.NextMarker;
            } while (!string.IsNullOrEmpty(listRequest.Marker));
            return objs;
        }

        private async Task<List<S3Object>> GetS3ObjectsToDownloadV2Async(ListObjectsV2Request listRequestV2, CancellationToken cancellationToken)
        {
            List<S3Object> objs = new List<S3Object>();
            do
            {
                ListObjectsV2Response listResponse = await this._s3Client.ListObjectsV2Async(listRequestV2, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);

                if (listResponse.S3Objects != null)
                {
                    foreach (S3Object s3o in listResponse.S3Objects)
                    {
                        if (ShouldDownload(s3o))
                        {
                            this._totalBytes += s3o.Size.GetValueOrDefault();
                            objs.Add(s3o);
                        }
                    }
                }
                listRequestV2.ContinuationToken = listResponse.NextContinuationToken;
            } while (!string.IsNullOrEmpty(listRequestV2.ContinuationToken));
            return objs;
        }
    }
}
