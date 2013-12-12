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
    internal class MultipartUploadCommand : BaseCommand
    {
        readonly object COUNTER_LOCK = new object();
        readonly object QUEUE_ACECSS_LOCK = new object();
        readonly object WAIT_FOR_COMPLETION_LOCK = new object();

        IAmazonS3 _s3Client;
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

        static Logger _logger = Logger.GetLogger(typeof(TransferUtility));

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadCommand"/> class.
        /// </summary>
        /// <param name="s3Client">The s3 client.</param>
        /// <param name="config">The config object that has the number of threads to use.</param>
        /// <param name="fileTransporterRequest">The file transporter request.</param>
        internal MultipartUploadCommand(IAmazonS3 s3Client, TransferUtilityConfig config, TransferUtilityUploadRequest fileTransporterRequest)
        {
            this._config = config;

            if (fileTransporterRequest.IsSetFilePath())
            {
                _logger.DebugFormat("Beginning upload of file {0}.", fileTransporterRequest.FilePath);
            }
            else
            {
                _logger.DebugFormat("Beginning upload of stream.");
            }

            this._s3Client = s3Client;
            this._fileTransporterRequest = fileTransporterRequest;
            this._contentLength = this._fileTransporterRequest.ContentLength;



            if (fileTransporterRequest.IsSetPartSize())
                this._partSize = fileTransporterRequest.PartSize;
            else
                this._partSize = calculatePartSize(this._contentLength);

            _logger.DebugFormat("Upload part size {0}.", this._partSize);
        }

        private static long calculatePartSize(long fileSize)
        {
            double partSize = Math.Ceiling((double)fileSize / S3Constants.MaxNumberOfParts);
            if (partSize < S3Constants.MinPartSize)
            {
                partSize = S3Constants.MinPartSize;
            }

            return (long)partSize;
        }

        private string determineContentType()
        {
            if (this._fileTransporterRequest.IsSetContentType())
                return this._fileTransporterRequest.ContentType;

            if (this._fileTransporterRequest.IsSetFilePath() ||
                this._fileTransporterRequest.IsSetKey())
            {
                // Get the extension of the file from the path.
                // Try the key as well.
                string ext = Path.GetExtension(this._fileTransporterRequest.FilePath);
                if (String.IsNullOrEmpty(ext) &&
                    this._fileTransporterRequest.IsSetKey())
                {
                    ext = Path.GetExtension(this._fileTransporterRequest.Key);
                }

                string type = AmazonS3Util.MimeTypeFromExtension(ext);
                return type;
            }

            return null;
        }


        private void startInvokerPool()
        {
            int threadCount;
            if (this._fileTransporterRequest.IsSetFilePath() && !(_s3Client is AmazonS3EncryptionClient))
            {
                threadCount = this._config.NumberOfUploadThreads;
            }
            else
            {
                threadCount = 1; // When using streams or encryption, multiple threads can not be used to read from the same stream.
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
                thread.Name = "Uploader " + i;
                thread.IsBackground = true;
                this._executedThreads[i] = thread;
                thread.Start();
            }
        }

        /// <summary>
        /// Runs the multipart upload.
        /// </summary>
        public override void Execute()
        {

            InitiateMultipartUploadRequest initRequest = new InitiateMultipartUploadRequest()
            {
                BucketName = this._fileTransporterRequest.BucketName,
                Key = this._fileTransporterRequest.Key,
                CannedACL = this._fileTransporterRequest.CannedACL,
                ContentType = determineContentType(),
                StorageClass = this._fileTransporterRequest.StorageClass,
                ServerSideEncryptionMethod = this._fileTransporterRequest.ServerSideEncryptionMethod
            };
            initRequest.BeforeRequestEvent += this.RequestEventHandler;

            if (this._fileTransporterRequest.Metadata != null && this._fileTransporterRequest.Metadata.Count > 0)
                initRequest.Metadata = this._fileTransporterRequest.Metadata;
            if (this._fileTransporterRequest.Headers != null && this._fileTransporterRequest.Headers.Count > 0)
                initRequest.Headers = this._fileTransporterRequest.Headers;

            InitiateMultipartUploadResponse initResponse = this._s3Client.InitiateMultipartUpload(initRequest);
            _logger.DebugFormat("Initiated upload: {0}", initResponse.UploadId);

            try
            {
                _logger.DebugFormat("Queue up the UploadPartRequests to be executed");

                
                long filePosition = 0;
                for (int i = 1; filePosition < this._contentLength; i++)
                {
                    UploadPartRequest uploadRequest = new UploadPartRequest()
                    {
                        BucketName = this._fileTransporterRequest.BucketName,
                        Key = this._fileTransporterRequest.Key,
                        UploadId = initResponse.UploadId,
                        PartNumber = i,
                        PartSize = this._partSize,
#if (BCL && !BCL45)
                        Timeout = ClientConfig.GetTimeoutValue(this._config.DefaultTimeout,this._fileTransporterRequest.Timeout)
#endif
                    };

                    if ((filePosition + this._partSize >= this._contentLength) && _s3Client is AmazonS3EncryptionClient)
                    {
                        uploadRequest.IsLastPart = true;
                        uploadRequest.PartSize = 0;
                    }

                    uploadRequest.StreamUploadProgressCallback += this.uploadPartProgressEventCallback;
                    uploadRequest.BeforeRequestEvent += this.RequestEventHandler;

                    if (this._fileTransporterRequest.IsSetFilePath())
                    {
                        uploadRequest.FilePosition = filePosition;
                        uploadRequest.FilePath = this._fileTransporterRequest.FilePath;
                    }
                    else
                    {
                        uploadRequest.InputStream = this._fileTransporterRequest.InputStream;
                    }

                    this._partsToUpload.Enqueue(uploadRequest);
                    filePosition += this._partSize;
                }

                this._totalNumberOfParts = this._partsToUpload.Count;
                _logger.DebugFormat("Starting threads to execute the {0} UploadPartRequests in the queue", this._totalNumberOfParts);
                startInvokerPool();

                _logger.DebugFormat("Waiting for threads to complete. ({0})", initResponse.UploadId);
                waitTillAllThreadsComplete();

                _logger.DebugFormat("Beginning completing multipart. ({0})", initResponse.UploadId);

                CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest()
                {
                    BucketName = this._fileTransporterRequest.BucketName,
                    Key = this._fileTransporterRequest.Key,
                    UploadId = initResponse.UploadId
                };
                compRequest.AddPartETags(this._uploadResponses);
                compRequest.BeforeRequestEvent += this.RequestEventHandler;

                this._s3Client.CompleteMultipartUpload(compRequest);
                _logger.DebugFormat("Done completing multipart. ({0})", initResponse.UploadId);

            }
            catch (Exception e)
            {
                _logger.Error(e, "Exception while uploading. ({0})", initResponse.UploadId);
                shutdown(initResponse.UploadId);
                throw;
            }
            finally
            {
                if (this._fileTransporterRequest.InputStream != null && !this._fileTransporterRequest.IsSetFilePath() && this._fileTransporterRequest.AutoCloseStream)
                {
                    this._fileTransporterRequest.InputStream.Close();
                }
                if (_logger != null)
                {
                    _logger.Flush();
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
                _logger.InfoFormat("Error attempting to about multipart for key {0}: {1}", this._fileTransporterRequest.Key, e.Message);
            }
        }

        private void addResponse(UploadPartResponse response)
        {
            lock (this.WAIT_FOR_COMPLETION_LOCK)
            {
                this._uploadResponses.Add(response);
            }
        }

        private void uploadPartProgressEventCallback(object sender, Amazon.Runtime.StreamTransferProgressArgs e)
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
