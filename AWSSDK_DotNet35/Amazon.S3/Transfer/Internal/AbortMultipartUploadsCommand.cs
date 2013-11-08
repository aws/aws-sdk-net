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
using System.Text;

using Amazon.S3;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    internal class AbortMultipartUploadsCommand : BaseCommand
    {
        IAmazonS3 _s3Client;
        string _bucketName; 
        DateTime _initiatedDate;

        internal AbortMultipartUploadsCommand(IAmazonS3 s3Client, string bucketName, DateTime initiateDate)
        {
            this._s3Client = s3Client;
            this._bucketName = bucketName;
            this._initiatedDate = initiateDate;
        }

        public override void Execute()
        {
            if (string.IsNullOrEmpty(this._bucketName))
            {
                throw new InvalidOperationException("The bucketName Specified is null or empty!");
            }

            ListMultipartUploadsResponse listResponse = new ListMultipartUploadsResponse();
            do
            {
                ListMultipartUploadsRequest listRequest = new ListMultipartUploadsRequest()
                {
                    BucketName = this._bucketName,
                    KeyMarker = listResponse.KeyMarker,
                    UploadIdMarker = listResponse.NextUploadIdMarker,
                };
                listRequest.BeforeRequestEvent += this.RequestEventHandler;

                listResponse = this._s3Client.ListMultipartUploads(listRequest);
                foreach (MultipartUpload upload in listResponse.MultipartUploads)
                {
                    if (upload.Initiated < this._initiatedDate)
                    {
                        var abortRequest = new AbortMultipartUploadRequest()
                        {
                            BucketName = this._bucketName,
                            Key = upload.Key,
                            UploadId = upload.UploadId,
                        };
                        abortRequest.BeforeRequestEvent += this.RequestEventHandler;

                        this._s3Client.AbortMultipartUpload(abortRequest);
                    }
                }
            }
            while (listResponse.IsTruncated);
        }
    }
}
