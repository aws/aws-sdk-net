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

using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

using Amazon.S3.Model;
using Amazon.S3.Util;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// The command to manage an upload using the S3 multipart API.
    /// </summary>
    internal partial class MultipartUploadCommand : BaseCommand
    {
        IAmazonS3 _s3Client;
        long _partSize;
        int _totalNumberOfParts;
        TransferUtilityConfig _config;
        TransferUtilityUploadRequest _fileTransporterRequest;

        List<UploadPartResponse> _uploadResponses = new List<UploadPartResponse>();
        long _totalTransferredBytes;
        Queue<UploadPartRequest> _partsToUpload = new Queue<UploadPartRequest>();


        long _contentLength;
        private static Logger Logger
        {
            get
            {
                return Logger.GetLogger(typeof(TransferUtility));
            }
        }

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
                Logger.DebugFormat("Beginning upload of file {0}.", fileTransporterRequest.FilePath);
            }
            else
            {
                Logger.DebugFormat("Beginning upload of stream.");
            }

            this._s3Client = s3Client;
            this._fileTransporterRequest = fileTransporterRequest;
            this._contentLength = this._fileTransporterRequest.ContentLength;

            if (fileTransporterRequest.IsSetPartSize())
                this._partSize = fileTransporterRequest.PartSize;
            else
                this._partSize = calculatePartSize(this._contentLength);

            if (fileTransporterRequest.InputStream != null)
            {
                if (fileTransporterRequest.AutoResetStreamPosition && fileTransporterRequest.InputStream.CanSeek)
                {
                    fileTransporterRequest.InputStream.Seek(0, SeekOrigin.Begin);
                }
            }

            Logger.DebugFormat("Upload part size {0}.", this._partSize);
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
                string ext = AWSSDKUtils.GetExtension(this._fileTransporterRequest.FilePath);
                if (String.IsNullOrEmpty(ext) &&
                    this._fileTransporterRequest.IsSetKey())
                {
                    ext = AWSSDKUtils.GetExtension(this._fileTransporterRequest.Key);
                }

                string type = AmazonS3Util.MimeTypeFromExtension(ext);
                return type;
            }
            return null;
        }

        private int CalculateConcurrentServiceRequests()
        {
            int threadCount;
            if (this._fileTransporterRequest.IsSetFilePath()
#if BCL
 && !(_s3Client is Amazon.S3.Encryption.AmazonS3EncryptionClient)
#endif
)
            {
                threadCount = this._config.ConcurrentServiceRequests;
            }
            else
            {
                threadCount = 1; // When using streams or encryption, multiple threads can not be used to read from the same stream.
            }

            if (this._totalNumberOfParts < threadCount)
            {
                threadCount = this._totalNumberOfParts;
            }
            return threadCount;
        }

        private CompleteMultipartUploadRequest ConstructCompleteMultipartUploadRequest(InitiateMultipartUploadResponse initResponse)
        {
            var compRequest = new CompleteMultipartUploadRequest()
            {
                BucketName = this._fileTransporterRequest.BucketName,
                Key = this._fileTransporterRequest.Key,
                UploadId = initResponse.UploadId
            };
            compRequest.AddPartETags(this._uploadResponses);
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)compRequest).AddBeforeRequestHandler(this.RequestEventHandler);
            return compRequest;
        }

        private UploadPartRequest ConstructUploadPartRequest(int partNumber, long filePosition, InitiateMultipartUploadResponse initResponse)
        {
            var uploadRequest = new UploadPartRequest()
            {
                BucketName = this._fileTransporterRequest.BucketName,
                Key = this._fileTransporterRequest.Key,
                UploadId = initResponse.UploadId,
                PartNumber = partNumber,
                PartSize = this._partSize,
                ServerSideEncryptionCustomerMethod = this._fileTransporterRequest.ServerSideEncryptionCustomerMethod,
                ServerSideEncryptionCustomerProvidedKey = this._fileTransporterRequest.ServerSideEncryptionCustomerProvidedKey,
                ServerSideEncryptionCustomerProvidedKeyMD5 = this._fileTransporterRequest.ServerSideEncryptionCustomerProvidedKeyMD5,
#if (BCL && !BCL45)
                Timeout = ClientConfig.GetTimeoutValue(this._config.DefaultTimeout, this._fileTransporterRequest.Timeout)
#endif
            };

#if BCL
            if ((filePosition + this._partSize >= this._contentLength)
                && _s3Client is Amazon.S3.Encryption.AmazonS3EncryptionClient

                )
            {
                uploadRequest.IsLastPart = true;
                uploadRequest.PartSize = 0;
            }
#endif

            var progressHandler = new ProgressHandler(this.UploadPartProgressEventCallback);
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)uploadRequest).StreamUploadProgressCallback += progressHandler.OnTransferProgress;
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)uploadRequest).AddBeforeRequestHandler(this.RequestEventHandler);

            if (this._fileTransporterRequest.IsSetFilePath())
            {
                uploadRequest.FilePosition = filePosition;
                uploadRequest.FilePath = this._fileTransporterRequest.FilePath;
            }
            else
            {
                uploadRequest.InputStream = this._fileTransporterRequest.InputStream;
            }

            // If the InitiateMultipartUploadResponse indicates that this upload is
            // using KMS, force SigV4 for each UploadPart request
            bool useSigV4 = initResponse.ServerSideEncryptionMethod == ServerSideEncryptionMethod.AWSKMS;
            if (useSigV4)
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)uploadRequest).UseSigV4 = true;

            return uploadRequest;
        }

        private InitiateMultipartUploadRequest ConstructInitiateMultipartUploadRequest()
        {
            var initRequest = new InitiateMultipartUploadRequest()
            {
                BucketName = this._fileTransporterRequest.BucketName,
                Key = this._fileTransporterRequest.Key,
                CannedACL = this._fileTransporterRequest.CannedACL,
                ContentType = determineContentType(),
                StorageClass = this._fileTransporterRequest.StorageClass,
                ServerSideEncryptionMethod = this._fileTransporterRequest.ServerSideEncryptionMethod,
                ServerSideEncryptionKeyManagementServiceKeyId = this._fileTransporterRequest.ServerSideEncryptionKeyManagementServiceKeyId,
                ServerSideEncryptionCustomerMethod = this._fileTransporterRequest.ServerSideEncryptionCustomerMethod,
                ServerSideEncryptionCustomerProvidedKey = this._fileTransporterRequest.ServerSideEncryptionCustomerProvidedKey,
                ServerSideEncryptionCustomerProvidedKeyMD5 = this._fileTransporterRequest.ServerSideEncryptionCustomerProvidedKeyMD5
            };
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)initRequest).AddBeforeRequestHandler(this.RequestEventHandler);

            if (this._fileTransporterRequest.Metadata != null && this._fileTransporterRequest.Metadata.Count > 0)
                initRequest.Metadata = this._fileTransporterRequest.Metadata;
            if (this._fileTransporterRequest.Headers != null && this._fileTransporterRequest.Headers.Count > 0)
                initRequest.Headers = this._fileTransporterRequest.Headers;

            return initRequest;
        }

        private void UploadPartProgressEventCallback(object sender, UploadProgressArgs e)
        {
            long transferredBytes = Interlocked.Add(ref _totalTransferredBytes, e.IncrementTransferred - e.CompensationForRetry);

            var progressArgs = new UploadProgressArgs(e.IncrementTransferred, transferredBytes, this._contentLength,
                e.CompensationForRetry, this._fileTransporterRequest.FilePath);
            this._fileTransporterRequest.OnRaiseProgressEvent(progressArgs);
        }
    }

    internal class ProgressHandler
    {
        private StreamTransferProgressArgs _lastProgressArgs;
        private EventHandler<UploadProgressArgs> _callback;

        public ProgressHandler(EventHandler<UploadProgressArgs> callback)
        {
            if (callback == null)
                throw new ArgumentNullException("callback");

            _callback = callback;
        }

        public void OnTransferProgress(object sender, StreamTransferProgressArgs e)
        {
            var compensationForRetry = 0L;

            if (_lastProgressArgs != null)
            {
                if (_lastProgressArgs.TransferredBytes >= e.TransferredBytes)
                {
                    // The request was retried
                    compensationForRetry = _lastProgressArgs.TransferredBytes;
                }
            }

            var progressArgs = new UploadProgressArgs(e.IncrementTransferred, e.TransferredBytes, e.TotalBytes,
            compensationForRetry, null);
            _callback(this, progressArgs);

            _lastProgressArgs = e;
        }
    }
}
