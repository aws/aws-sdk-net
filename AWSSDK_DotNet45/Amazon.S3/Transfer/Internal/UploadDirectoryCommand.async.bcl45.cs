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
using Amazon.S3.Encryption;
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
    internal partial class UploadDirectoryCommand : BaseCommand
    {
        public bool UploadFilesConcurrently { get; set; }

        public override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            string prefix = GetKeyPrefix();

            string basePath = new DirectoryInfo(this._request.Directory).FullName;

            string[] filePaths = await GetFiles(basePath, this._request.SearchPattern, this._request.SearchOption, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);                
            this._totalNumberOfFiles = filePaths.Length;

            SemaphoreSlim asyncThrottler = null;
            SemaphoreSlim loopThrottler = null;
            CancellationTokenSource internalCts = null;
            try
            {
                var pendingTasks = new List<Task>();
                loopThrottler = UploadFilesConcurrently ? 
                    new SemaphoreSlim(this._config.ConcurrentServiceRequests) :
                    new SemaphoreSlim(1);

                asyncThrottler = this._utility.S3Client is AmazonS3EncryptionClient ?
                    // If we are using AmazonS3EncryptionClient, don't set the async throttler.
                    // The loopThrottler will be used to control how many files are uploaded in parallel.
                    // Each upload (multipart) will upload parts serially.
                    null :
                    // Use a throttler which will be shared between simple and multipart uploads
                    // to control concurrent IO.
                    new SemaphoreSlim(this._config.ConcurrentServiceRequests);


                internalCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
                foreach (string filepath in filePaths)
                {
                    await loopThrottler.WaitAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);

                    cancellationToken.ThrowIfCancellationRequested();
                    if (internalCts.IsCancellationRequested)
                    {
                        // Operation cancelled as one of the upload requests failed with an exception,
                        // don't schedule any more upload tasks. 
                        // Don't throw an OperationCanceledException here as we want to process the 
                        // responses and throw the original exception.
                        break;
                    }
                    var uploadRequest = ConstructRequest(basePath, filepath, prefix);
                    var uploadCommand = _utility.GetUploadCommand(uploadRequest, asyncThrottler);

                    var task = ExecuteCommandAsync(uploadCommand, internalCts, loopThrottler);
                    pendingTasks.Add(task);
                }
                await WhenAllOrFirstExceptionAsync(pendingTasks, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);
            }
            finally
            {                
                internalCts.Dispose();
                loopThrottler.Dispose();
                asyncThrottler.Dispose();
            }
        }

        private Task<string[]> GetFiles(string path, string searchPattern, SearchOption searchOption, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
                { 
                    var filePaths = Directory.GetFiles(path, searchPattern, searchOption);
                    foreach (var filePath in filePaths)
                    {
                        _totalBytes += new FileInfo(filePath).Length;
                    }
                    return filePaths;
                }, cancellationToken);

        }
    }
}
