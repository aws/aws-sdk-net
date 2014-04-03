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
    internal partial class DownloadDirectoryCommand
    {
        public override void Execute()
        {
            ValidateRequest();
            EnsureDirectoryExists(new DirectoryInfo(this._request.LocalDirectory));

            ListObjectsRequest listRequest = ConstructListObjectRequest();

            List<S3Object> objs = new List<S3Object>();
            do
            {
                ListObjectsResponse listResponse = this._s3Client.ListObjects(listRequest);
                foreach (S3Object s3o in listResponse.S3Objects)
                {
                    if (this._request.IsSetModifiedSinceDate() && s3o.LastModified <= this._request.ModifiedSinceDate)
                        continue;
                    if (this._request.IsSetUnmodifiedSinceDate() && s3o.LastModified > this._request.UnmodifiedSinceDate)
                        continue;

                    this._totalBytes += s3o.Size;
					objs.Add(s3o);
                }
                listRequest.Marker = listResponse.NextMarker;
            } while (!string.IsNullOrEmpty(listRequest.Marker));
			
            this._totalNumberOfFilesToDownload = objs.Count;

            foreach (S3Object s3o in objs)
            {
                if (s3o.Key.EndsWith("/", StringComparison.Ordinal))
                    continue;

                this._currentFile = s3o.Key.Substring(listRequest.Prefix.Length);

                var downloadRequest = ConstructTransferUtilityDownloadRequest(s3o, listRequest.Prefix.Length);
                DownloadCommand command = new DownloadCommand(this._s3Client, downloadRequest);
                command.Execute();
        }
        }
    }
}
