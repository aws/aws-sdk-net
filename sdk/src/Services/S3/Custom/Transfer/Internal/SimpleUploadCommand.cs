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

using Amazon.Runtime.Internal.Util;

using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Util;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// This command is for doing regular PutObject requests.
    /// </summary>
    internal partial class SimpleUploadCommand : BaseCommand<TransferUtilityUploadResponse>
    {
        IAmazonS3 _s3Client;
        TransferUtilityConfig _config;
        TransferUtilityUploadRequest _fileTransporterRequest;
        long _totalTransferredBytes;
        private readonly long _contentLength;

        internal SimpleUploadCommand(IAmazonS3 s3Client, TransferUtilityConfig config, TransferUtilityUploadRequest fileTransporterRequest)
        {
            this._s3Client = s3Client;
            this._config = config;
            this._fileTransporterRequest = fileTransporterRequest;
            
            // Cache content length immediately while stream is accessible to avoid ObjectDisposedException in failure scenarios
            this._contentLength = this._fileTransporterRequest.ContentLength;
            
            var fileName = fileTransporterRequest.FilePath;
        }

        internal PutObjectRequest ConstructRequest()
        {
            PutObjectRequest putRequest = new PutObjectRequest()
            {
                BucketName = this._fileTransporterRequest.BucketName,
                Key = this._fileTransporterRequest.Key,
                CannedACL = this._fileTransporterRequest.CannedACL,
                StorageClass = this._fileTransporterRequest.StorageClass,
                AutoCloseStream = this._fileTransporterRequest.AutoCloseStream,
                AutoResetStreamPosition = this._fileTransporterRequest.AutoResetStreamPosition,
                ServerSideEncryptionMethod = this._fileTransporterRequest.ServerSideEncryptionMethod,
                ServerSideEncryptionCustomerMethod = this._fileTransporterRequest.ServerSideEncryptionCustomerMethod,
                ServerSideEncryptionCustomerProvidedKey = this._fileTransporterRequest.ServerSideEncryptionCustomerProvidedKey,
                ServerSideEncryptionCustomerProvidedKeyMD5 = this._fileTransporterRequest.ServerSideEncryptionCustomerProvidedKeyMD5,
                ServerSideEncryptionKeyManagementServiceKeyId = this._fileTransporterRequest.ServerSideEncryptionKeyManagementServiceKeyId,
                IfNoneMatch = this._fileTransporterRequest.IfNoneMatch,
                IfMatch = this._fileTransporterRequest.IfMatch,
                Metadata = this._fileTransporterRequest.Metadata,
                TagSet = this._fileTransporterRequest.TagSet,
                DisableDefaultChecksumValidation = this._fileTransporterRequest.DisableDefaultChecksumValidation,
                DisablePayloadSigning = this._fileTransporterRequest.DisablePayloadSigning,
                ChecksumAlgorithm = this._fileTransporterRequest.ChecksumAlgorithm,
                ChecksumCRC32 = this._fileTransporterRequest.ChecksumCRC32,
                ChecksumCRC32C = this._fileTransporterRequest.ChecksumCRC32C,
                ChecksumCRC64NVME = this._fileTransporterRequest.ChecksumCRC64NVME,
                ChecksumSHA1 = this._fileTransporterRequest.ChecksumSHA1,
                ChecksumSHA256 = this._fileTransporterRequest.ChecksumSHA256,
                RequestPayer = this._fileTransporterRequest.RequestPayer,
                BucketKeyEnabled = this._fileTransporterRequest.BucketKeyEnabled,
                ExpectedBucketOwner = this._fileTransporterRequest.ExpectedBucketOwner,
                Grants = this._fileTransporterRequest.Grants,
                ServerSideEncryptionKeyManagementServiceEncryptionContext = this._fileTransporterRequest.SSEKMSEncryptionContext,
                WebsiteRedirectLocation = this._fileTransporterRequest.WebsiteRedirectLocation,
                Expires = this._fileTransporterRequest.Expires
            };
            
            // We are iterating over the Headers to avoid setting the Header from the Transfer utility upload request 
            // to the PutObjectRequest since that will cause issues down the line.
            // The AmazonS3PreMarshallHandler modifies the content type on the headers collection 
            // which would impact other requests in a directory upload if the Headers were referenced.
            if (this._fileTransporterRequest.Headers != null && this._fileTransporterRequest.Headers.Count > 0)
            {
                foreach (var headerKey in this._fileTransporterRequest.Headers.Keys)
                {
                    if (string.Equals(headerKey, HeaderKeys.ContentTypeHeader) && this._fileTransporterRequest.IsSetContentType())
                    {
                        continue;
                    }
                    else
                    {
                        putRequest.Headers[headerKey] = this._fileTransporterRequest.Headers[headerKey];
                    }
                }
            }

            // Avoid setting ContentType to null, as that may clear
            // out an existing value in Headers collection
            if (!string.IsNullOrEmpty(this._fileTransporterRequest.ContentType))
                putRequest.ContentType = this._fileTransporterRequest.ContentType;

            putRequest.FilePath = this._fileTransporterRequest.FilePath;
            var progressHandler = new ProgressHandler(this.PutObjectProgressEventCallback);
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)putRequest).StreamUploadProgressCallback += progressHandler.OnTransferProgress;
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)putRequest).AddBeforeRequestHandler(this.RequestEventHandler);

            putRequest.InputStream = this._fileTransporterRequest.InputStream;
            putRequest.ObjectLockLegalHoldStatus = this._fileTransporterRequest.ObjectLockLegalHoldStatus;
            putRequest.ObjectLockMode = this._fileTransporterRequest.ObjectLockMode;

            if (this._fileTransporterRequest.IsSetObjectLockRetainUntilDate())
                putRequest.ObjectLockRetainUntilDate = this._fileTransporterRequest.ObjectLockRetainUntilDate;

            return putRequest;
        }

        private void PutObjectProgressEventCallback(object sender, UploadProgressArgs e)
        {
            // Keep track of the total transferred bytes so that we can also return this value in case of failure
            long transferredBytes = Interlocked.Add(ref _totalTransferredBytes, e.IncrementTransferred - e.CompensationForRetry);
            
            var progressArgs = new UploadProgressArgs(e.IncrementTransferred, transferredBytes, _contentLength, 
                e.CompensationForRetry, _fileTransporterRequest.FilePath, _fileTransporterRequest);
            this._fileTransporterRequest.OnRaiseProgressEvent(progressArgs);
        }

        private void FireTransferInitiatedEvent()
        {
            var initiatedArgs = new UploadInitiatedEventArgs(
                request: _fileTransporterRequest,
                filePath: _fileTransporterRequest.FilePath,
                totalBytes: _contentLength
            );
            
            _fileTransporterRequest.OnRaiseTransferInitiatedEvent(initiatedArgs);
        }

        private void FireTransferCompletedEvent(TransferUtilityUploadResponse response)
        {
            var completedArgs = new UploadCompletedEventArgs(
                request: _fileTransporterRequest,
                response: response,
                filePath: _fileTransporterRequest.FilePath,
                transferredBytes: Interlocked.Read(ref _totalTransferredBytes),
                totalBytes: _contentLength
            );
            
            _fileTransporterRequest.OnRaiseTransferCompletedEvent(completedArgs);
        }

        private void FireTransferFailedEvent()
        {
            var failedArgs = new UploadFailedEventArgs(
                request: _fileTransporterRequest,
                filePath: _fileTransporterRequest.FilePath,
                transferredBytes: Interlocked.Read(ref _totalTransferredBytes),
                totalBytes: _contentLength
            );
            
            _fileTransporterRequest.OnRaiseTransferFailedEvent(failedArgs);
        }
    }
}
