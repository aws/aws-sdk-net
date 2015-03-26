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
using Amazon.Runtime;
using System.Threading;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// This command files all the files that meets the criteria specified in the TransferUtilityUploadDirectoryRequest request
    /// and uploads them.
    /// </summary>
    internal partial class UploadDirectoryCommand : BaseCommand
    {
        TransferUtilityUploadDirectoryRequest _request;
        TransferUtility _utility;
        TransferUtilityConfig _config;

        int _totalNumberOfFiles;
        int _numberOfFilesUploaded;
        long _totalBytes;
        long _transferredBytes;        

        internal UploadDirectoryCommand(TransferUtility utility, TransferUtilityConfig config, TransferUtilityUploadDirectoryRequest request)
        {
            this._utility = utility;
            this._request = request;
            this._config = config;
        }

        private TransferUtilityUploadRequest ConstructRequest(string basePath, string filepath, string prefix)
        {
            string key = filepath.Substring(basePath.Length);
            key = key.Replace(@"\", "/");
            if (key.StartsWith("/", StringComparison.Ordinal))
                key = key.Substring(1);
            key = prefix + key;

            var uploadRequest = new TransferUtilityUploadRequest()
            {
                BucketName = this._request.BucketName,
                Key = key,
                FilePath = filepath,
                CannedACL = this._request.CannedACL,
                Metadata = this._request.Metadata,
                StorageClass = this._request.StorageClass,
                ServerSideEncryptionMethod = this._request.ServerSideEncryptionMethod,
                ServerSideEncryptionKeyManagementServiceKeyId = this._request.ServerSideEncryptionKeyManagementServiceKeyId,
#if (BCL && !BCL45)
                Timeout = ClientConfig.GetTimeoutValue(this._config.DefaultTimeout, this._request.Timeout)
#endif
            };
            uploadRequest.UploadProgressEvent += new EventHandler<UploadProgressArgs>(UploadProgressEventCallback);

            // Raise event to allow subscribers to modify request
            _request.RaiseUploadDirectoryFileRequestEvent(uploadRequest);

            return uploadRequest;
        }

        private string GetKeyPrefix()
        {
            var prefix = string.Empty;
            if (this._request.IsSetKeyPrefix())
            {
                prefix = this._request.KeyPrefix;
                prefix = prefix.Replace(@"\", "/");
                if (prefix.StartsWith("/", StringComparison.Ordinal))
                    prefix = prefix.Substring(1);

                if (!prefix.EndsWith("/", StringComparison.Ordinal))
                {
                    prefix += "/";
                }
            }
            return prefix;
        }

        private void UploadProgressEventCallback(object sender, UploadProgressArgs e)
        {
            
            var totalTransferredBytes = Interlocked.Add(ref _transferredBytes, e.IncrementTransferred - e.CompensationForRetry);

            int numberOfFilesUploaded = _numberOfFilesUploaded;
            if (e.TransferredBytes == e.TotalBytes)
            {
                numberOfFilesUploaded = Interlocked.Increment(ref _numberOfFilesUploaded);
            }

            UploadDirectoryProgressArgs uploadDirectoryProgressArgs = null;
            if (_request.UploadFilesConcurrently)
            {
                // If concurrent upload is enabled, values for current file, 
                // transferred and total bytes for current file are not set.
                uploadDirectoryProgressArgs = new UploadDirectoryProgressArgs(numberOfFilesUploaded, _totalNumberOfFiles,
                   totalTransferredBytes, _totalBytes,
                   null, 0, 0);
            }
            else
            {
                uploadDirectoryProgressArgs = new UploadDirectoryProgressArgs(numberOfFilesUploaded, _totalNumberOfFiles,
                  totalTransferredBytes, _totalBytes,
                  e.FilePath, e.TransferredBytes, e.TotalBytes);
            }
            _request.OnRaiseProgressEvent(uploadDirectoryProgressArgs);
        }
    }
}
