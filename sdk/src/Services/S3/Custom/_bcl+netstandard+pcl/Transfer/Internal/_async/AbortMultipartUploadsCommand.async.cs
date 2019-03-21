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
    internal partial class AbortMultipartUploadsCommand : BaseCommand
    {
        TransferUtilityConfig _config;

        internal AbortMultipartUploadsCommand(IAmazonS3 s3Client, string bucketName, DateTime initiateDate, TransferUtilityConfig config)
        {
            this._s3Client = s3Client;
            this._bucketName = bucketName;
            this._initiatedDate = initiateDate;
            this._config = config;
        }

        public override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(this._bucketName))
            {
                throw new InvalidOperationException("The bucketName specified is null or empty!");
            }

            SemaphoreSlim asyncThrottler = null;
            CancellationTokenSource internalCts = null;
            try
            {
                asyncThrottler = new SemaphoreSlim(_config.ConcurrentServiceRequests);
                internalCts = new CancellationTokenSource();
                var internalCancellationToken = internalCts.Token;

                ListMultipartUploadsResponse listResponse = new ListMultipartUploadsResponse();
                var pendingTasks = new List<Task<AbortMultipartUploadResponse>>();
                do
                {
                    ListMultipartUploadsRequest listRequest = ConstructListMultipartUploadsRequest(listResponse);
                    listResponse = await this._s3Client.ListMultipartUploadsAsync(listRequest, cancellationToken)
                        .ConfigureAwait(continueOnCapturedContext: false);

                    foreach (MultipartUpload upload in listResponse.MultipartUploads)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        if (internalCancellationToken.IsCancellationRequested)
                        {
                            // Operation cancelled as one of the AbortMultipartUpload requests failed with an exception,
                            // don't schedule any more AbortMultipartUpload tasks. 
                            // Don't throw an OperationCanceledException here as we want to process the 
                            // responses and throw the original exception.
                            break;
                        }
                        if (upload.Initiated < this._initiatedDate)
                        {
                            await asyncThrottler.WaitAsync(cancellationToken)
                                .ConfigureAwait(continueOnCapturedContext: false);

                            var abortRequest = ConstructAbortMultipartUploadRequest(upload);
                            var task = AbortAsync(abortRequest, internalCts, cancellationToken, asyncThrottler);
                            pendingTasks.Add(task);
                        }
                    }
                }
                while (listResponse.IsTruncated);

                await WhenAllOrFirstExceptionAsync(pendingTasks,cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);
            }
            finally
            {
                if (internalCts != null)
                    internalCts.Dispose();

                if (asyncThrottler!=null)
                    asyncThrottler.Dispose();
            }
        }

        private async Task<AbortMultipartUploadResponse> AbortAsync(AbortMultipartUploadRequest abortRequest, CancellationTokenSource internalCts,
            CancellationToken cancellationToken, SemaphoreSlim asyncThrottler)
        {
            try
            {
                return await this._s3Client.AbortMultipartUploadAsync(abortRequest, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);
            }
            catch (Exception exception)
            {
                if (!(exception is OperationCanceledException))
                {
                    // Cancel scheduling any more tasks.
                    internalCts.Cancel();
                }
                throw;
            }
            finally
            {
                asyncThrottler.Release();
            }
        }
    }
}
