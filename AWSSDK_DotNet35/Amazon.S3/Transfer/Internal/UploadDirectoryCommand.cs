using Amazon.Runtime;
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

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// This command files all the files that meets the criteria specified in the TransferUtilityUploadDirectoryRequest request
    /// and uploads them.
    /// </summary>
    internal class UploadDirectoryCommand : BaseCommand
    {
        TransferUtilityUploadDirectoryRequest _request;
        TransferUtility _utility;
        TransferUtilityConfig _config;

        string _currentFile;
        int _totalNumberOfFiles;
        int _numberOfFilesUploaded;


        internal UploadDirectoryCommand(TransferUtility utility,TransferUtilityConfig config, TransferUtilityUploadDirectoryRequest request)
        {
            this._utility = utility;
            this._request = request;
            this._config = config;
        }

        public override void Execute()
        {
            string prefix = string.Empty;
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

            string basePath = new DirectoryInfo(this._request.Directory).FullName;
            string searchPattern = string.IsNullOrEmpty(this._request.SearchPattern) ? "*" : this._request.SearchPattern;
            string[] filePaths = Directory.GetFiles(basePath, searchPattern, this._request.SearchOption);
            this._totalNumberOfFiles = filePaths.Length;

            foreach (string filepath in filePaths)
            {
                this._currentFile = filepath;
                string key = filepath.Substring(basePath.Length);
                key = key.Replace(@"\", "/");
                if(key.StartsWith("/", StringComparison.Ordinal))
                    key = key.Substring(1);

                key = prefix + key;

                TransferUtilityUploadRequest uploadRequest = new TransferUtilityUploadRequest()
                {
                    BucketName = this._request.BucketName,
                    Key = key,
                    FilePath = filepath,
                    CannedACL = this._request.CannedACL,
                    Metadata = this._request.Metadata,
                    StorageClass = this._request.StorageClass,
                    ServerSideEncryptionMethod = this._request.ServerSideEncryptionMethod,
#if (BCL && !BCL45)                    
                    Timeout = ClientConfig.GetTimeoutValue(this._config.DefaultTimeout, this._request.Timeout)                    
#endif
                };
                uploadRequest.UploadProgressEvent += new EventHandler<UploadProgressArgs>(uploadProgressEventCallback);

                this._utility.Upload(uploadRequest);
                this._numberOfFilesUploaded++;
            }
        }

        private void uploadProgressEventCallback(object sender, UploadProgressArgs e)
        {
            int numberOfFilesUploaded = this._numberOfFilesUploaded;
            if (e.TransferredBytes == e.TotalBytes)
                numberOfFilesUploaded++;

            this._request.OnRaiseProgressEvent(numberOfFilesUploaded, this._totalNumberOfFiles,
                this._currentFile, e.TransferredBytes, e.TotalBytes);
        }

    }
}
