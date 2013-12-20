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
using Amazon.Runtime;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// This command is for doing regular PutObject requests.
    /// </summary>
    internal class SimpleUploadCommand : BaseCommand
    {
        IAmazonS3 _s3Client;
        TransferUtilityConfig _config;
        TransferUtilityUploadRequest _fileTransporterRequest;

        internal SimpleUploadCommand(IAmazonS3 s3Client, TransferUtilityConfig config, TransferUtilityUploadRequest fileTransporterRequest)
        {
            this._s3Client = s3Client;
            this._config = config;
            this._fileTransporterRequest = fileTransporterRequest;
        }

        public override void Execute()
        {


            PutObjectRequest putRequest = new PutObjectRequest()
            {
                BucketName = this._fileTransporterRequest.BucketName,
                Key = this._fileTransporterRequest.Key,
                CannedACL = this._fileTransporterRequest.CannedACL,
                ContentType = this._fileTransporterRequest.ContentType,
                FilePath = this._fileTransporterRequest.FilePath,
                StorageClass = this._fileTransporterRequest.StorageClass,
                AutoCloseStream = this._fileTransporterRequest.AutoCloseStream,
                AutoResetStreamPosition = this._fileTransporterRequest.AutoResetStreamPosition,
                ServerSideEncryptionMethod = this._fileTransporterRequest.ServerSideEncryptionMethod,
                Headers = this._fileTransporterRequest.Headers,
                Metadata = this._fileTransporterRequest.Metadata,
#if (BCL && !BCL45)
                Timeout = ClientConfig.GetTimeoutValue(this._config.DefaultTimeout, this._fileTransporterRequest.Timeout)
#endif
            };
            putRequest.StreamUploadProgressCallback += new EventHandler<Runtime.StreamTransferProgressArgs>(this.putObjectProgressEventCallback);

            putRequest.InputStream = this._fileTransporterRequest.InputStream;

            this._s3Client.PutObject(putRequest);
        }

        private void putObjectProgressEventCallback(object sender, Amazon.Runtime.StreamTransferProgressArgs e)
        {
            this._fileTransporterRequest.OnRaiseProgressEvent(e.IncrementTransferred, e.TransferredBytes, e.TotalBytes);
        }
    }
}
