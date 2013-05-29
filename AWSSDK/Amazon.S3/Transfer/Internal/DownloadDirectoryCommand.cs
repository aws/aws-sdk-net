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

using Amazon.S3;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    internal class DownloadDirectoryCommand : BaseCommand
    {
        AmazonS3 _s3Client;
        TransferUtilityDownloadDirectoryRequest _request;
        int _totalNumberOfFilesToDownload;
        int _numberOfFilesDownloaded;
        string _currentFile;

        internal DownloadDirectoryCommand(AmazonS3 s3Client, TransferUtilityDownloadDirectoryRequest request)
        {
            this._s3Client = s3Client;
            this._request = request;
        }

        public override void Execute()
        {
            if (!this._request.IsSetBucketName())
            {
                throw new ArgumentNullException("BucketName", "The bucketName Specified is null or empty!");
            }
            if (!this._request.IsSetS3Directory())
            {
                throw new ArgumentNullException("S3Directory", "The S3Directory Specified is null or empty!");
            }
            if (!this._request.IsSetLocalDirectory())
            {
                throw new ArgumentNullException("LocalDirectory", "The LocalDirectory Specified is null or empty!");
            }

            if (File.Exists(this._request.S3Directory))
            {
                throw new ArgumentNullException("LocalDirectory", "A file already exists with the same name indicated by LocalDirectory!");
            }

            EnsureDirectoryExists(new DirectoryInfo(this._request.LocalDirectory));

            ListObjectsRequest listRequest = new ListObjectsRequest();
            listRequest.BucketName = this._request.BucketName;
            listRequest.Prefix = this._request.S3Directory;

            listRequest.Prefix = listRequest.Prefix.Replace('\\', '/');
            if (!listRequest.Prefix.EndsWith("/"))
                listRequest.Prefix += "/";

            if (listRequest.Prefix.StartsWith("/"))
            {
                if (listRequest.Prefix.Length == 1)
                    listRequest.Prefix = "";
                else
                    listRequest.Prefix = listRequest.Prefix.Substring(1);
            }

            List<S3Object> objs = new List<S3Object>();
            do
            {
                ListObjectsResponse listResponse = this._s3Client.ListObjects(listRequest);
                foreach (S3Object s3o in listResponse.S3Objects)
                {
                    DateTime lastModified = DateTime.Parse(s3o.LastModified);
                    if (this._request.IsSetModifiedSinceDate() && this._request.ModifiedSinceDate < lastModified)
                        continue;
                    if (this._request.IsSetUnmodifiedSinceDate() && lastModified < this._request.UnmodifiedSinceDate)
                        continue;

                    objs.Add(s3o);
                }
                listRequest.Marker = listResponse.NextMarker;
            } while (!string.IsNullOrEmpty(listRequest.Marker));

            this._totalNumberOfFilesToDownload = objs.Count;

            foreach (S3Object s3o in objs)
            {
                if (s3o.Key.EndsWith("/"))
                    continue;

                this._currentFile = s3o.Key.Substring(listRequest.Prefix.Length);

                TransferUtilityDownloadRequest downloadRequest = new TransferUtilityDownloadRequest();
                downloadRequest.BucketName = this._request.BucketName;
                downloadRequest.Key = s3o.Key;
                downloadRequest.FilePath = Path.Combine(this._request.LocalDirectory, this._currentFile);
                downloadRequest.Timeout = this._request.Timeout;
                downloadRequest.WithSubscriber(new EventHandler<WriteObjectProgressArgs>(downloadedProgressEventCallback));


                DownloadCommand command = new DownloadCommand(this._s3Client, downloadRequest);
                command.Execute();

                this._numberOfFilesDownloaded++;
            }
        }

        private void downloadedProgressEventCallback(object sender, WriteObjectProgressArgs e)
        {
            int numberOfFilesDownloaded = this._numberOfFilesDownloaded;
            if (e.TransferredBytes == e.TotalBytes)
                numberOfFilesDownloaded++;

            this._request.OnRaiseProgressEvent(numberOfFilesDownloaded, this._totalNumberOfFilesToDownload,
                this._currentFile, e.TransferredBytes, e.TotalBytes);
        }

        private void EnsureDirectoryExists(DirectoryInfo directory)
        {
            if (directory.Exists)
                return;

            EnsureDirectoryExists(directory.Parent);
            directory.Create();
        }
    }
}
