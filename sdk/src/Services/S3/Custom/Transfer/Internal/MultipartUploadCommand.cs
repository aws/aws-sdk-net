/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
                && !(_s3Client is Amazon.S3.Internal.IAmazonS3Encryption))
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
            return ConstructCompleteMultipartUploadRequest(initResponse, false, null);
        }

        private CompleteMultipartUploadRequest ConstructCompleteMultipartUploadRequest(InitiateMultipartUploadResponse initResponse, bool skipPartValidation, RequestEventHandler requestEventHandler)
        {
            if (!skipPartValidation)
            {
                if (this._uploadResponses.Count != this._totalNumberOfParts)
                {
                    throw new InvalidOperationException($"Cannot complete multipart upload request. The total number of completed parts ({this._uploadResponses.Count}) " +
                        $"does not equal the total number of parts created ({this._totalNumberOfParts}).");
                }
            }

            var compRequest = new CompleteMultipartUploadRequest()
            {
                BucketName = this._fileTransporterRequest.BucketName,
                Key = this._fileTransporterRequest.Key,
                UploadId = initResponse.UploadId,
                IfNoneMatch = this._fileTransporterRequest.IfNoneMatch,
                IfMatch = this._fileTransporterRequest.IfMatch,
                RequestPayer = this._fileTransporterRequest.RequestPayer,
                ChecksumType = initResponse.ChecksumType,
                ChecksumCRC32 = this._fileTransporterRequest.ChecksumCRC32,
                ChecksumCRC32C = this._fileTransporterRequest.ChecksumCRC32C,
                ChecksumCRC64NVME = this._fileTransporterRequest.ChecksumCRC64NVME,
                ChecksumSHA1 = this._fileTransporterRequest.ChecksumSHA1,
                ChecksumSHA256 = this._fileTransporterRequest.ChecksumSHA256,
            };

            if(this._fileTransporterRequest.ServerSideEncryptionCustomerMethod != null 
                && this._fileTransporterRequest.ServerSideEncryptionCustomerMethod != ServerSideEncryptionCustomerMethod.None)
            {
                compRequest.SSECustomerAlgorithm = this._fileTransporterRequest.ServerSideEncryptionCustomerMethod.ToString();
                compRequest.SSECustomerKey = this._fileTransporterRequest.ServerSideEncryptionCustomerProvidedKey;

                // If the MD5 of the customer encryption key was not provided use the value from the initiate response.
                compRequest.SSECustomerKeyMD5 =
                    this._fileTransporterRequest.ServerSideEncryptionCustomerProvidedKeyMD5 ??
                    initResponse.ServerSideEncryptionCustomerProvidedKeyMD5;
            }

            compRequest.AddPartETagsAndChecksums(this._uploadResponses);

            if (this._fileTransporterRequest.IsSetMpuObjectSize())
            {
                compRequest.MpuObjectSize = this._fileTransporterRequest.MpuObjectSize;
            }

            if (requestEventHandler != null)
            {
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)compRequest).AddBeforeRequestHandler(requestEventHandler);
            }
            else
            {
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)compRequest).AddBeforeRequestHandler(this.RequestEventHandler);
            }

            return compRequest;
        }

        private UploadPartRequest ConstructUploadPartRequest(int partNumber, long filePosition, InitiateMultipartUploadResponse initiateResponse)
        {
            UploadPartRequest uploadPartRequest = ConstructGenericUploadPartRequest(initiateResponse);

            uploadPartRequest.PartNumber = partNumber;
            uploadPartRequest.PartSize = this._partSize;

            if ((filePosition + this._partSize >= this._contentLength)
                && _s3Client is Amazon.S3.Internal.IAmazonS3Encryption)
            {
                uploadPartRequest.IsLastPart = true;
                uploadPartRequest.PartSize = 0;
            }

            var progressHandler = new ProgressHandler(this.UploadPartProgressEventCallback);
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)uploadPartRequest).StreamUploadProgressCallback += progressHandler.OnTransferProgress;
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)uploadPartRequest).AddBeforeRequestHandler(this.RequestEventHandler);

            if (this._fileTransporterRequest.IsSetFilePath())
            {
                uploadPartRequest.FilePosition = filePosition;
                uploadPartRequest.FilePath = this._fileTransporterRequest.FilePath;
            }
            else
            {
                uploadPartRequest.InputStream = this._fileTransporterRequest.InputStream;
            }

            return uploadPartRequest;
        }

        private UploadPartRequest ConstructGenericUploadPartRequest(InitiateMultipartUploadResponse initiateResponse)
        {
            UploadPartRequest uploadPartRequest = new UploadPartRequest()
            {
                BucketName = this._fileTransporterRequest.BucketName,
                Key = this._fileTransporterRequest.Key,
                UploadId = initiateResponse.UploadId,
                ServerSideEncryptionCustomerMethod = this._fileTransporterRequest.ServerSideEncryptionCustomerMethod,
                ServerSideEncryptionCustomerProvidedKey = this._fileTransporterRequest.ServerSideEncryptionCustomerProvidedKey,
                ServerSideEncryptionCustomerProvidedKeyMD5 = this._fileTransporterRequest.ServerSideEncryptionCustomerProvidedKeyMD5,
                DisableDefaultChecksumValidation = this._fileTransporterRequest.DisableDefaultChecksumValidation,
                DisablePayloadSigning = this._fileTransporterRequest.DisablePayloadSigning,
                ChecksumAlgorithm = this._fileTransporterRequest.ChecksumAlgorithm,
                RequestPayer = this._fileTransporterRequest.RequestPayer
            };

            // If the InitiateMultipartUploadResponse indicates that this upload is using KMS, force SigV4 for each UploadPart request
            bool useSigV4 = initiateResponse.ServerSideEncryptionMethod == ServerSideEncryptionMethod.AWSKMS || initiateResponse.ServerSideEncryptionMethod == ServerSideEncryptionMethod.AWSKMSDSSE;
            if (useSigV4)
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)uploadPartRequest).SignatureVersion = SignatureVersion.SigV4;

            return uploadPartRequest;
        }

        private UploadPartRequest ConstructUploadPartRequestForNonSeekableStream(Stream inputStream, int partNumber, long partSize, bool isLastPart, InitiateMultipartUploadResponse initiateResponse)
        {
            UploadPartRequest uploadPartRequest = ConstructGenericUploadPartRequest(initiateResponse);
            
            uploadPartRequest.InputStream = inputStream;
            uploadPartRequest.PartNumber = partNumber;
            uploadPartRequest.PartSize = partSize;
            uploadPartRequest.IsLastPart = isLastPart;
            // we can only determine the percentage uploaded if content length is known. For an unseekable stream with unknown length we will not
            // report on the transfer progress. The part numbers uploaded can still be looked at through verbose logging.
            if (this._fileTransporterRequest.ContentLength != -1)
            {
                var progressHandler = new ProgressHandler(this.UploadPartProgressEventCallback);
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)uploadPartRequest).StreamUploadProgressCallback += progressHandler.OnTransferProgress;
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)uploadPartRequest).AddBeforeRequestHandler(this.RequestEventHandler);
            }

            return uploadPartRequest;
        }

        private InitiateMultipartUploadRequest ConstructInitiateMultipartUploadRequest()
        {
            return this.ConstructInitiateMultipartUploadRequest(null);
        }

        private InitiateMultipartUploadRequest ConstructInitiateMultipartUploadRequest(RequestEventHandler requestEventHandler)
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
                ServerSideEncryptionCustomerProvidedKeyMD5 = this._fileTransporterRequest.ServerSideEncryptionCustomerProvidedKeyMD5,
                TagSet = this._fileTransporterRequest.TagSet,
                ChecksumAlgorithm = this._fileTransporterRequest.ChecksumAlgorithm,
                ObjectLockLegalHoldStatus = this._fileTransporterRequest.ObjectLockLegalHoldStatus,
                ObjectLockMode = this._fileTransporterRequest.ObjectLockMode,
                RequestPayer = this._fileTransporterRequest.RequestPayer
            };

            if (this._fileTransporterRequest.IsSetObjectLockRetainUntilDate())
                initRequest.ObjectLockRetainUntilDate = this._fileTransporterRequest.ObjectLockRetainUntilDate;

            if (HasPrecalculatedChecksum(out ChecksumAlgorithm algorithmToUse))
            {
                initRequest.ChecksumType = ChecksumType.FULL_OBJECT;

                // For full object checksums, the corresponding algorithm of the precalculated value must be used for all individual part uploads.
                if (!initRequest.IsSetChecksumAlgorithm())
                {
                    initRequest.ChecksumAlgorithm = algorithmToUse;
                    _fileTransporterRequest.ChecksumAlgorithm = algorithmToUse;
                }
            }
            else if (ShouldSetDefaultAlgorithm(initRequest))
            {
                initRequest.ChecksumAlgorithm = ChecksumUtils.DefaultAlgorithm.ToString();
                initRequest.ChecksumType = ChecksumType.FULL_OBJECT;
            }

            if (requestEventHandler != null)
            {
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)initRequest).AddBeforeRequestHandler(requestEventHandler);
            }
            else
            {
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)initRequest).AddBeforeRequestHandler(this.RequestEventHandler);
            }

            if (this._fileTransporterRequest.Metadata != null && this._fileTransporterRequest.Metadata.Count > 0)
                initRequest.Metadata = this._fileTransporterRequest.Metadata;
            if (this._fileTransporterRequest.Headers != null && this._fileTransporterRequest.Headers.Count > 0)
            {
                foreach (var headerKey in this._fileTransporterRequest.Headers.Keys)
                {
                    // InitiateMultipartUploadRequest already has its content-type header set.
                    // don't copy the Content-Type if it's set already as to not overwrite the original content-type
                    if (string.Equals(headerKey, HeaderKeys.ContentTypeHeader) && this._fileTransporterRequest.IsSetContentType())
                    {
                        continue;
                    }
                    else
                    {
                        initRequest.Headers[headerKey] = this._fileTransporterRequest.Headers[headerKey];
                    }
                }
            }
                
            return initRequest;
        }

        private void UploadPartProgressEventCallback(object sender, UploadProgressArgs e)
        {
            long transferredBytes = Interlocked.Add(ref _totalTransferredBytes, e.IncrementTransferred - e.CompensationForRetry);

            var progressArgs = new UploadProgressArgs(e.IncrementTransferred, transferredBytes, this._contentLength,
                e.CompensationForRetry, this._fileTransporterRequest.FilePath);
            this._fileTransporterRequest.OnRaiseProgressEvent(progressArgs);
        }

        /// <summary>
        /// <para>
        /// If a checksum algorithm was not specified, we MUST add the default value used by the SDK (as the individual part 
        /// uploads will calculate a checksum as specified by the S3 model).
        /// </para>
        /// 
        /// <para>
        /// We also need to check if the default validation was disabled (either via the global S3 configuration or in the 
        /// upload request). The newer <c>RequestChecksumCalculation</c> option is also validated since the UploadPart
        /// operation is modeled with <c>"requestChecksumRequired":false</c>
        /// </para>
        /// </summary>
        private bool ShouldSetDefaultAlgorithm(InitiateMultipartUploadRequest initRequest)
        {
            return 
                !initRequest.IsSetChecksumAlgorithm() &&
                !AWSConfigsS3.DisableDefaultChecksumValidation &&
                !this._fileTransporterRequest.DisableDefaultChecksumValidation.GetValueOrDefault() &&
                (_s3Client.Config.RequestChecksumCalculation == RequestChecksumCalculation.WHEN_SUPPORTED);
        }

        /// <summary>
        /// If a pre-calculated value was specified, we MUST set the checksum type to <c>FULL_OBJECT</c>.
        /// </summary>
        /// <param name="chosenAlgorithm">
        /// The corresponding checksum algorithm for the precalculated value (if one was provided).
        /// </param>
        private bool HasPrecalculatedChecksum(out ChecksumAlgorithm chosenAlgorithm)
        {
            chosenAlgorithm = null;

            if (this._fileTransporterRequest.IsSetChecksumCRC64NVME())
            {
                chosenAlgorithm = ChecksumAlgorithm.CRC64NVME;
                return true;
            }

            if (this._fileTransporterRequest.IsSetChecksumCRC32())
            {
                chosenAlgorithm = ChecksumAlgorithm.CRC32;
                return true;
            }

            if (this._fileTransporterRequest.IsSetChecksumCRC32C())
            {
                chosenAlgorithm = ChecksumAlgorithm.CRC32C;
                return true;
            }

            if (this._fileTransporterRequest.IsSetChecksumSHA1())
            {
                chosenAlgorithm = ChecksumAlgorithm.SHA1;
                return true;
            }

            if (this._fileTransporterRequest.IsSetChecksumSHA256())
            {
                chosenAlgorithm = ChecksumAlgorithm.SHA256;
                return true;
            }

            return false;
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
