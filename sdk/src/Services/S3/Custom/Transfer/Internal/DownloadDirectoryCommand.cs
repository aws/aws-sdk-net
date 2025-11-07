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

using Amazon.S3;
using Amazon.S3.Model;
using System.Threading;
using Amazon.S3.Util;
using Amazon.Util.Internal;
using Amazon.Runtime;

namespace Amazon.S3.Transfer.Internal
{
    internal partial class DownloadDirectoryCommand : BaseCommand
    {
        private readonly IAmazonS3 _s3Client;
        private readonly TransferUtilityDownloadDirectoryRequest _request;
        private readonly bool _skipEncryptionInstructionFiles;
        int _totalNumberOfFilesToDownload;
        int _numberOfFilesDownloaded;
        long _totalBytes;
        long _transferredBytes;        
        string _currentFile;

        internal DownloadDirectoryCommand(IAmazonS3 s3Client, TransferUtilityDownloadDirectoryRequest request)
        {
            if (s3Client == null)
                throw new ArgumentNullException("s3Client");

            this._s3Client = s3Client;
            this._request = request;
            this._skipEncryptionInstructionFiles = s3Client is Amazon.S3.Internal.IAmazonS3Encryption;
        }

        private void downloadedProgressEventCallback(object sender, WriteObjectProgressArgs e)
        {
            var transferredBytes = Interlocked.Add(ref _transferredBytes, e.IncrementTransferred);

            int numberOfFilesDownloaded = _numberOfFilesDownloaded;
            if (e.IsCompleted)
            {
                numberOfFilesDownloaded = Interlocked.Increment(ref _numberOfFilesDownloaded);
            }

            DownloadDirectoryProgressArgs downloadDirectoryProgress = null;
            if (_request.DownloadFilesConcurrently)
            {
                // If concurrent download is enabled, values for current file, 
                // transferred and total bytes for current file are not set.
                downloadDirectoryProgress = new DownloadDirectoryProgressArgs(numberOfFilesDownloaded, _totalNumberOfFilesToDownload,
                           transferredBytes, _totalBytes,
                           null, 0, 0);
            }
            else
            {
                downloadDirectoryProgress = new DownloadDirectoryProgressArgs(numberOfFilesDownloaded, _totalNumberOfFilesToDownload,
                    transferredBytes, _totalBytes,
                    _currentFile, e.TransferredBytes, e.TotalBytes);
            }
            _request.OnRaiseProgressEvent(downloadDirectoryProgress);
        }

        private void EnsureDirectoryExists(DirectoryInfo directory)
        {
            if (directory.Exists)
                return;

            EnsureDirectoryExists(directory.Parent);
            directory.Create();
        }

        private TransferUtilityDownloadRequest ConstructTransferUtilityDownloadRequest(S3Object s3Object, int prefixLength)
        {
            var downloadRequest = new TransferUtilityDownloadRequest();
            downloadRequest.BucketName = this._request.BucketName;
            downloadRequest.Key = s3Object.Key;
            var file = s3Object.Key.Substring(prefixLength).Replace('/', Path.DirectorySeparatorChar);
            downloadRequest.FilePath = Path.Combine(this._request.LocalDirectory, file);
            downloadRequest.ServerSideEncryptionCustomerMethod = this._request.ServerSideEncryptionCustomerMethod;
            downloadRequest.ServerSideEncryptionCustomerProvidedKey = this._request.ServerSideEncryptionCustomerProvidedKey;
            downloadRequest.ServerSideEncryptionCustomerProvidedKeyMD5 = this._request.ServerSideEncryptionCustomerProvidedKeyMD5;
            downloadRequest.RequestPayer = this._request.RequestPayer;

            //Ensure the target file is a rooted within LocalDirectory. Otherwise error.
            if(!InternalSDKUtils.IsFilePathRootedWithDirectoryPath(downloadRequest.FilePath, _request.LocalDirectory))
            {
                throw new AmazonClientException($"The file {downloadRequest.FilePath} is not allowed outside of the target directory {_request.LocalDirectory}.");
            }

            downloadRequest.WriteObjectProgressEvent += downloadedProgressEventCallback;

            return downloadRequest;
        }

        private ListObjectsV2Request ConstructListObjectRequestV2()
        {
            ListObjectsV2Request listRequestV2 = new ListObjectsV2Request();
            listRequestV2.BucketName = this._request.BucketName;
            listRequestV2.Prefix = this._request.S3Directory;

            listRequestV2.Prefix = listRequestV2.Prefix.Replace('\\', '/');

            if (!this._request.DisableSlashCorrection)
            {
                if (!listRequestV2.Prefix.EndsWith("/", StringComparison.Ordinal))
                    listRequestV2.Prefix += "/";
            }

            if (listRequestV2.Prefix.StartsWith("/", StringComparison.Ordinal))
            {
                if (listRequestV2.Prefix.Length == 1)
                    listRequestV2.Prefix = "";
                else
                    listRequestV2.Prefix = listRequestV2.Prefix.Substring(1);
            }

            listRequestV2.RequestPayer = this._request.RequestPayer;

            return listRequestV2;
        }

        private ListObjectsRequest ConstructListObjectRequest()
        {
            ListObjectsRequest listRequest = new ListObjectsRequest();
            listRequest.BucketName = this._request.BucketName;
            listRequest.Prefix = this._request.S3Directory;

            listRequest.Prefix = listRequest.Prefix.Replace('\\', '/');

            if (!this._request.DisableSlashCorrection)
            {
                if (!listRequest.Prefix.EndsWith("/", StringComparison.Ordinal))
                    listRequest.Prefix += "/";
            }

            if (listRequest.Prefix.StartsWith("/", StringComparison.Ordinal))
            {
                if (listRequest.Prefix.Length == 1)
                    listRequest.Prefix = "";
                else
                    listRequest.Prefix = listRequest.Prefix.Substring(1);
            }

            listRequest.RequestPayer = this._request.RequestPayer;

            return listRequest;
        }

        private void ValidateRequest()
        {
            if (!this._request.IsSetBucketName())
            {
                throw new InvalidOperationException("The bucketName Specified is null or empty!");
            }
            if (!this._request.IsSetS3Directory())
            {
                throw new InvalidOperationException("The S3Directory Specified is null or empty!");
            }
            if (!this._request.IsSetLocalDirectory())
            {
                throw new InvalidOperationException("The LocalDirectory Specified is null or empty!");
            }

            if (File.Exists(this._request.S3Directory))
            {
                throw new InvalidOperationException("A file already exists with the same name indicated by LocalDirectory!");
            }
        }

        private bool IsInstructionFile(string key)
        {
            return (this._skipEncryptionInstructionFiles && AmazonS3Util.IsInstructionFile(key));
        }

        private bool ShouldDownload(S3Object s3o)
        {
            // skip objects based on ModifiedSinceDate
            if (this._request.IsSetModifiedSinceDate() && s3o.LastModified.GetValueOrDefault() <= this._request.ModifiedSinceDate.ToUniversalTime())
                return false;
            // skip objects based on UnmodifiedSinceDate
            if (this._request.IsSetUnmodifiedSinceDate() && s3o.LastModified.GetValueOrDefault() > this._request.UnmodifiedSinceDate.ToUniversalTime())
                return false;
            // skip objects which are instruction files and we're using encryption client
            if (IsInstructionFile(s3o.Key))
                return false;

            return true;
        }
    }
}
