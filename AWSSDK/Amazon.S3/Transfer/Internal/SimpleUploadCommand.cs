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

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// This command is for doing regular PutObject requests.
    /// </summary>
    internal class SimpleUploadCommand : BaseCommand
    {
        AmazonS3 _s3Client;
        TransferUtilityConfig _config;
        TransferUtilityUploadRequest _fileTransporterRequest;

        internal SimpleUploadCommand(AmazonS3 s3Client, TransferUtilityConfig config, TransferUtilityUploadRequest fileTransporterRequest)
        {
            this._s3Client = s3Client;
            this._config = config;
            this._fileTransporterRequest = fileTransporterRequest;
        }

        public override void Execute()
        {
            int timeout = this._config.DefaultTimeout;
            if (this._fileTransporterRequest.Timeout != 0)
                timeout = this._fileTransporterRequest.Timeout;

            PutObjectRequest putRequest = new PutObjectRequest()
                .WithBucketName(this._fileTransporterRequest.BucketName)
                .WithKey(this._fileTransporterRequest.Key)
                .WithCannedACL(this._fileTransporterRequest.CannedACL)
                .WithContentType(this._fileTransporterRequest.ContentType)
                .WithFilePath(this._fileTransporterRequest.FilePath)
                .WithTimeout(timeout)
                .WithStorageClass(this._fileTransporterRequest.StorageClass)
                .WithAutoCloseStream(this._fileTransporterRequest.AutoCloseStream)
                    .WithServerSideEncryptionMethod(this._fileTransporterRequest.ServerSideEncryptionMethod)
                .WithSubscriber(new EventHandler<PutObjectProgressArgs>(this.putObjectProgressEventCallback));

            putRequest.InputStream = this._fileTransporterRequest.InputStream;

            if (this._fileTransporterRequest.metadata != null && this._fileTransporterRequest.metadata.Count > 0)
                putRequest.WithMetaData(this._fileTransporterRequest.metadata);
            if (this._fileTransporterRequest.Headers != null && this._fileTransporterRequest.Headers.Count > 0)
                putRequest.AddHeaders(this._fileTransporterRequest.Headers);

            this._s3Client.PutObject(putRequest);
        }

        private void putObjectProgressEventCallback(object sender, PutObjectProgressArgs e)
        {
            this._fileTransporterRequest.OnRaiseProgressEvent(e.IncrementTransferred, e.TransferredBytes, e.TotalBytes);
        }
    }
}
