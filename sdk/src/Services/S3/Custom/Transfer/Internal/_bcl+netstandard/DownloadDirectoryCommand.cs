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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Util.Internal;

namespace Amazon.S3.Transfer.Internal
{
    internal partial class DownloadDirectoryCommand : BaseCommand<TransferUtilityDownloadDirectoryResponse>
    {
        TransferUtilityConfig _config;

        public bool DownloadFilesConcurrently { get; set; }

        internal DownloadDirectoryCommand(IAmazonS3 s3Client, TransferUtilityDownloadDirectoryRequest request, TransferUtilityConfig config)
            : this(s3Client, request)
        {
            this._config = config;
        }

        public override async Task<TransferUtilityDownloadDirectoryResponse> ExecuteAsync(CancellationToken cancellationToken)
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

            // Two-level throttling architecture:
            // 1. File-level throttler: Controls how many files are downloaded concurrently
            // 2. HTTP-level throttler: Controls total HTTP requests across ALL file downloads
            //
            // Example with ConcurrentServiceRequests = 10:
            //   - fileOperationThrottler = 10: Up to 10 files can download simultaneously
            //   - sharedHttpRequestThrottler = 10: All 10 files share 10 total HTTP request slots
            //   - Without HTTP throttler: Would result in 10 files × 10 parts = 100 concurrent HTTP requests
            //   - With HTTP throttler: Enforces 10 total concurrent HTTP requests across all files
            //
            // This prevents resource exhaustion when downloading many large files with multipart downloads.
            SemaphoreSlim fileOperationThrottler = null;
            SemaphoreSlim sharedHttpRequestThrottler = null;
            CancellationTokenSource internalCts = null;

            try
            {
                // File-level throttler: Controls concurrent file operations
                fileOperationThrottler = DownloadFilesConcurrently ?
                    new SemaphoreSlim(this._config.ConcurrentServiceRequests) :
                    new SemaphoreSlim(1);

                // HTTP-level throttler: Shared across all downloads to control total HTTP concurrency
                // Only needed for multipart downloads where each file makes multiple HTTP requests
                if (this._useMultipartDownload)
                {
                    sharedHttpRequestThrottler = new SemaphoreSlim(this._config.ConcurrentServiceRequests);
                }

                internalCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
                var pendingTasks = new List<Task>();
                foreach (S3Object s3o in objs)
                {
                    if (s3o.Key.EndsWith("/", StringComparison.Ordinal))
                        continue;

                    await fileOperationThrottler.WaitAsync(cancellationToken)
                        .ConfigureAwait(continueOnCapturedContext: false);

                    try
                    {
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

                        TransferUtilityDownloadRequest downloadRequest = ConstructTransferUtilityDownloadRequest(s3o, prefixLength);

                        Action<Exception> onFailure = (ex) =>
                        {
                            this._request.OnRaiseObjectDownloadFailedEvent(
                                new ObjectDownloadFailedEventArgs(
                                    this._request, 
                                    downloadRequest, 
                                    ex));
                        };
                        
                        var isValid = await _failurePolicy.ExecuteAsync(
                            () => {
                                //Ensure the target file is a rooted within LocalDirectory. Otherwise error.
                                if(!InternalSDKUtils.IsFilePathRootedWithDirectoryPath(downloadRequest.FilePath, _request.LocalDirectory))
                                {
                                    throw new AmazonClientException($"The file {downloadRequest.FilePath} is not allowed outside of the target directory {_request.LocalDirectory}.");
                                }

                                return Task.CompletedTask;
                            },
                            onFailure,
                            internalCts
                        ).ConfigureAwait(false);
                        if (!isValid) continue;

                        var task = _failurePolicy.ExecuteAsync(
                            async () => {
                                BaseCommand<TransferUtilityDownloadResponse> command;
                                if (this._useMultipartDownload)
                                {
                                    command = new MultipartDownloadCommand(this._s3Client, downloadRequest, this._config, sharedHttpRequestThrottler);
                                }
                                else
                                {
                                    command = new DownloadCommand(this._s3Client, downloadRequest);
                                }
                                await command.ExecuteAsync(internalCts.Token)
                                    .ConfigureAwait(false);
                            },
                            onFailure,
                            internalCts
                        );

                        pendingTasks.Add(task);
                    }
                    finally
                    {
                        fileOperationThrottler.Release();
                    }
                }
                await TaskHelpers.WhenAllOrFirstExceptionAsync(pendingTasks, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);

                return new TransferUtilityDownloadDirectoryResponse
                {
                    ObjectsDownloaded = _numberOfFilesDownloaded,
                    ObjectsFailed = _errors.Count,
                    Errors = _errors.ToList(),
                    Result = _errors.Count == 0 ?
                        DirectoryResult.Success :
                        (_numberOfFilesDownloaded > 0 ?
                            DirectoryResult.PartialSuccess :
                            DirectoryResult.Failure)
                };
            }
            finally
            {
                internalCts.Dispose();
                fileOperationThrottler.Dispose();
                sharedHttpRequestThrottler?.Dispose();
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
