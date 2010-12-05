﻿/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

using Amazon.Runtime.Internal.Util;

using Amazon.S3.Model;
using Amazon.S3.Util;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// The command to manage an upload using the S3 multipart API.
    /// </summary>
    internal class MultipartUploadCommand
    {
        readonly object COUNTER_LOCK = new object();
        readonly object QUEUE_ACECSS_LOCK = new object();
        readonly object WAIT_FOR_COMPLETION_LOCK = new object();

        AmazonS3 _s3Client;
        long _partSize;
        int _totalNumberOfParts;
        TransferUtilityConfig _config;
        TransferUtilityUploadRequest _fileTransporterRequest;

        List<UploadPartResponse> _uploadResponses = new List<UploadPartResponse>();
        long _totalTransferredBytes = 0;
        Queue<UploadPartRequest> _partsToUpload = new Queue<UploadPartRequest>();


        long _contentLength;
        Thread[] _executedThreads;
        UploadPartInvoker[] _invokers;

        Logger _logger = new Logger(typeof(TransferUtility));

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadCommand"/> class.
        /// </summary>
        /// <param name="s3Client">The s3 client.</param>
        /// <param name="config">The config object that has the number of threads to use.</param>
        /// <param name="fileTransporterRequest">The file transporter request.</param>
        internal MultipartUploadCommand(AmazonS3 s3Client, TransferUtilityConfig config, TransferUtilityUploadRequest fileTransporterRequest)
        {
            this._config = config;

            if (fileTransporterRequest.IsSetFilePath())
            {
                this._logger.DebugFormat("Beginning upload of file {0}.", fileTransporterRequest.FilePath);
            }
            else
            {
                this._logger.DebugFormat("Beginning upload of stream.");
            }

            this._s3Client = s3Client;
            this._fileTransporterRequest = fileTransporterRequest;
            this._contentLength = this._fileTransporterRequest.ContentLength;



            if (fileTransporterRequest.IsSetPartSize())
                this._partSize = fileTransporterRequest.PartSize;
            else
                this._partSize = calculatePartSize(this._contentLength);

            this._logger.DebugFormat("Upload part size {0}.", this._partSize);
        }

        private static long calculatePartSize(long fileSize)
        {
            long partSize = fileSize / S3Constants.MaxNumberOfParts;
            if (partSize < S3Constants.MinPartSize)
            {
                partSize = S3Constants.MinPartSize;
            }

            return partSize;
        }


        private void startInvokerPool()
        {
            int threadCount;
            if (this._fileTransporterRequest.IsSetFilePath())
            {
                threadCount = this._config.NumberOfUploadThreads;
            }
            else
            {
                threadCount = 1; // When using streams multiple threads can not be used to read from the same stream.
            }

            if (this._totalNumberOfParts < threadCount)
            {
                threadCount = this._totalNumberOfParts;
            }

            this._executedThreads = new Thread[threadCount];
            this._invokers = new UploadPartInvoker[threadCount];

            for (int i = 0; i < threadCount; i++)
            {
                this._invokers[i] = new UploadPartInvoker(this);
                Thread thread = new Thread(new ThreadStart(this._invokers[i].Execute));
                thread.IsBackground = true;
                this._executedThreads[i] = thread;
                thread.Start();
            }
        }

        /// <summary>
        /// Runs the multipart upload.
        /// </summary>
        internal void Execute()
        {
            int timeout = this._config.DefaultTimeout;
            if (this._fileTransporterRequest.Timeout != 0)
                timeout = this._fileTransporterRequest.Timeout;

            InitiateMultipartUploadRequest initRequest = new InitiateMultipartUploadRequest()
                .WithBucketName(this._fileTransporterRequest.BucketName)
                .WithKey(this._fileTransporterRequest.Key)
                .WithCannedACL(this._fileTransporterRequest.CannedACL)
                .WithContentType(this._fileTransporterRequest.ContentType)
                .WithStorageClass(this._fileTransporterRequest.StorageClass);

            if (this._fileTransporterRequest.metadata != null && this._fileTransporterRequest.metadata.Count > 0)
                initRequest.WithMetaData(this._fileTransporterRequest.metadata);
            if (this._fileTransporterRequest.Headers != null && this._fileTransporterRequest.Headers.Count > 0)
                initRequest.AddHeaders(this._fileTransporterRequest.Headers);

            InitiateMultipartUploadResponse initResponse = this._s3Client.InitiateMultipartUpload(initRequest);
            this._logger.DebugFormat("Initiated upload: {0}", initResponse.UploadId);

            try
            {
                this._logger.DebugFormat("Queue up the UploadPartRequests to be executed");
                long filePosition = 0;
                for (int i = 1; filePosition < this._contentLength; i++)
                {
                    UploadPartRequest uploadRequest = new UploadPartRequest()
                        .WithBucketName(this._fileTransporterRequest.BucketName)
                        .WithKey(this._fileTransporterRequest.Key)
                        .WithUploadId(initResponse.UploadId)
                        .WithTimeout(timeout)
                        .WithPartNumber(i)
                        .WithPartSize(this._partSize)
                        .WithSubscriber(new EventHandler<UploadPartProgressArgs>(this.uploadPartProgressEventCallback));

                    if (this._fileTransporterRequest.IsSetFilePath())
                    {
                        uploadRequest
                            .WithFilePosition(filePosition)
                            .WithFilePath(this._fileTransporterRequest.FilePath);
                    }
                    else
                    {
                        uploadRequest.InputStream = this._fileTransporterRequest.InputStream;
                    }

                    this._partsToUpload.Enqueue(uploadRequest);
                    filePosition += this._partSize;
                }

                this._totalNumberOfParts = this._partsToUpload.Count;
                this._logger.DebugFormat("Starting threads to execute the {0} UploadPartRequests in the queue", this._totalNumberOfParts);
                startInvokerPool();

                this._logger.DebugFormat("Waiting for threads to complete. ({0})", initResponse.UploadId);
                waitTillAllThreadsComplete();

                this._logger.DebugFormat("Beginning completing multipart. ({0})", initResponse.UploadId);
                CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest()
                    .WithBucketName(this._fileTransporterRequest.BucketName)
                    .WithKey(this._fileTransporterRequest.Key)
                    .WithUploadId(initResponse.UploadId)
                    .WithPartETags(this._uploadResponses);
                this._s3Client.CompleteMultipartUpload(compRequest);
                this._logger.DebugFormat("Done completing multipart. ({0})", initResponse.UploadId);

            }
            catch (Exception e)
            {
                this._logger.Error(string.Format("Exception while uploading. ({0})", initResponse.UploadId), e);
                shutdown(initResponse.UploadId);
                throw;
            }
            finally
            {
                if (this._fileTransporterRequest.InputStream != null && !this._fileTransporterRequest.IsSetFilePath())
                {
                    this._fileTransporterRequest.InputStream.Close();
                }
            }
        }

        private void waitTillAllThreadsComplete()
        {
            lock (this.WAIT_FOR_COMPLETION_LOCK)
            {
                while (this._uploadResponses.Count != this._totalNumberOfParts)
                {
                    Monitor.Wait(this.WAIT_FOR_COMPLETION_LOCK, 100);

                    // Look for any exceptions from the upload threads.
                    foreach (UploadPartInvoker invoker in this._invokers)
                    {
                        checkForLastException(invoker);
                    }
                }
            }
        }

        private void checkForLastException(UploadPartInvoker invoker)
        {
            if (invoker.LastException != null)
                throw invoker.LastException;
        }

        private void shutdown(string uploadId)
        {
            // To get the AbortMultipartUpload the best chance of actually being able to 
            // abort the upload look through the list of threads multiple times
            // to make sure they have been successfully aborted.
            bool anyAlive = true;
            for (int i = 0; anyAlive && i < 5; i++)
            {
                anyAlive = false;
                foreach (Thread thread in this._executedThreads)
                {
                    try
                    {
                        if (thread.IsAlive)
                        {
                            thread.Abort();
                            anyAlive = true;
                        }
                    }
                    catch { }
                }
            }

            try
            {
                this._s3Client.AbortMultipartUpload(new AbortMultipartUploadRequest()
                    .WithBucketName(this._fileTransporterRequest.BucketName)
                    .WithKey(this._fileTransporterRequest.Key)
                    .WithUploadId(uploadId));
            }
            catch(Exception e)
            {
                this._logger.InfoFormat("Error attempting to about multipart for key {0}: {1}", this._fileTransporterRequest.Key, e.Message);
            }
        }

        private void addResponse(UploadPartResponse response)
        {
            lock (this.WAIT_FOR_COMPLETION_LOCK)
            {
                this._uploadResponses.Add(response);
            }
        }

        private void uploadPartProgressEventCallback(object sender, UploadPartProgressArgs e)
        {
            lock (this.COUNTER_LOCK)
            {
                this._totalTransferredBytes += e.IncrementTransferred;
            }

            this._fileTransporterRequest.OnRaiseProgressEvent(e.IncrementTransferred, this._totalTransferredBytes, this._contentLength);
        }

        /// <summary>
        /// Used as the ThreadStart for the threads doing the upload.
        /// </summary>
        class UploadPartInvoker
        {
            AmazonS3 _s3Client;

            MultipartUploadCommand _uploader;
            Exception _lastException;

            internal UploadPartInvoker(MultipartUploadCommand uploader)
            {
                this._uploader = uploader;
                this._s3Client = this._uploader._s3Client;
            }

            internal Exception LastException
            {
                get { return this._lastException; }
            }

            private UploadPartRequest getNextPartRequest()
            {
                lock (this._uploader.QUEUE_ACECSS_LOCK)
                {
                    if (this._uploader._partsToUpload.Count == 0)
                    {
                        return null;
                    }
                    return this._uploader._partsToUpload.Dequeue();
                }
            }

            internal void Execute()
            {
                UploadPartRequest request;
                while((request = getNextPartRequest()) != null)
                {
                    this._lastException = null;
                    try
                    {
                        this._uploader.addResponse(this._s3Client.UploadPart(request));
                    }
                    catch (ThreadAbortException)
                    {
                        throw;
                    }
                    catch (Exception e)
                    {
                        this._lastException = e;
                        lock (this._uploader.WAIT_FOR_COMPLETION_LOCK)
                        {
                            Monitor.Pulse(this._uploader.WAIT_FOR_COMPLETION_LOCK);
                        }
                        break;
                    }
                }
            }
        }
    }
}
