/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.S3.Encryption;
using Amazon.Runtime;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// The command to manage an upload using the S3 multipart API.
    /// </summary>
    internal partial class MultipartUploadCommand : BaseCommand
    {

        readonly object WAIT_FOR_COMPLETION_LOCK = new object();
        readonly object QUEUE_ACCESS_LOCK = new object();
        Thread[] _executedThreads;
        UploadPartInvoker[] _invokers;

        /// <summary>
        /// Runs the multipart upload.
        /// </summary>
        public override void Execute()
        {
            var initRequest = ConstructInitiateMultipartUploadRequest();
            var initResponse = this._s3Client.InitiateMultipartUpload(initRequest);
            Logger.DebugFormat("Initiated upload: {0}", initResponse.UploadId);

            try
            {
                Logger.DebugFormat("Queue up the UploadPartRequests to be executed");
                long filePosition = 0;
                for (int partNumber = 1; filePosition < this._contentLength; partNumber++)
                {
                    var uploadRequest = ConstructUploadPartRequest(partNumber, filePosition, initResponse);
                    this._partsToUpload.Enqueue(uploadRequest);
                    filePosition += this._partSize;
                }

                this._totalNumberOfParts = this._partsToUpload.Count;
                Logger.DebugFormat("Starting threads to execute the {0} UploadPartRequests in the queue", this._totalNumberOfParts);
                startInvokerPool();

                Logger.DebugFormat("Waiting for threads to complete. ({0})", initResponse.UploadId);
                waitTillAllThreadsComplete();

                Logger.DebugFormat("Beginning completing multipart. ({0})", initResponse.UploadId);

                var compRequest = ConstructCompleteMultipartUploadRequest(initResponse);
                this._s3Client.CompleteMultipartUpload(compRequest);
                Logger.DebugFormat("Done completing multipart. ({0})", initResponse.UploadId);

            }
            catch (Exception e)
            {
                Logger.Error(e, "Exception while uploading. ({0})", initResponse.UploadId);
                shutdown(initResponse.UploadId);
                throw;
            }
            finally
            {
                if (this._fileTransporterRequest.InputStream != null && !this._fileTransporterRequest.IsSetFilePath() && this._fileTransporterRequest.AutoCloseStream)
                {
                    this._fileTransporterRequest.InputStream.Close();
                }
                if (Logger != null)
                {
                    Logger.Flush();
                }
            }
        }

        private void AbortMultipartUpload(string uploadId)
        {
            try
            {
                this._s3Client.AbortMultipartUpload(new AbortMultipartUploadRequest()
                {
                    BucketName = this._fileTransporterRequest.BucketName,
                    Key = this._fileTransporterRequest.Key,
                    UploadId = uploadId
                });
            }
            catch (Exception e)
            {
                Logger.InfoFormat("Error attempting to abort multipart for key {0}: {1}", this._fileTransporterRequest.Key, e.Message);
            }
        }

        private void startInvokerPool()
        {
            int threadCount = CalculateConcurrentServiceRequests();

            this._executedThreads = new Thread[threadCount];
            this._invokers = new UploadPartInvoker[threadCount];

            for (int i = 0; i < threadCount; i++)
            {
                this._invokers[i] = new UploadPartInvoker(this);
                Thread thread = new Thread(new ThreadStart(this._invokers[i].Execute));
                thread.Name = "Uploader " + i;
                thread.IsBackground = true;
                this._executedThreads[i] = thread;
                thread.Start();
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

        private static void checkForLastException(UploadPartInvoker invoker)
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

            AbortMultipartUpload(uploadId);
        }

        private void addResponse(UploadPartResponse response)
        {
            lock (this.WAIT_FOR_COMPLETION_LOCK)
            {
                this._uploadResponses.Add(response);
            }
        }

        /// <summary>
        /// Used as the ThreadStart for the threads doing the upload.
        /// </summary>
        partial class UploadPartInvoker
        {
            IAmazonS3 _s3Client;

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
                lock (this._uploader.QUEUE_ACCESS_LOCK)
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
                UploadPartRequest request = null;
                while ((request = getNextPartRequest()) != null)
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
