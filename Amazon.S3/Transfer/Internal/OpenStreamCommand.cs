﻿/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    internal class OpenStreamCommand : BaseCommand
    {
        AmazonS3 _s3Client;
        TransferUtilityOpenStreamRequest _request;
        Stream _responseStream;

        internal OpenStreamCommand(AmazonS3 s3Client, TransferUtilityOpenStreamRequest request)
        {
            this._s3Client = s3Client;
            this._request = request;
        }

        public override void Execute()
        {
            if (!this._request.IsSetBucketName())
            {
                throw new ArgumentNullException("bucketName", "The bucketName Specified is null or empty!");
            }
            if (!this._request.IsSetKey())
            {
                throw new ArgumentNullException("key", "The key Specified is null or empty!");
            }

            GetObjectRequest getRequest = ConvertToGetObjectRequest(this._request);
            GetObjectResponse response = this._s3Client.GetObject(getRequest);
            this._responseStream = response.ResponseStream;
        }

        internal Stream ResponseStream
        {
            get { return this._responseStream; }
        }

        public override object  Return
        {
            get { return this.ResponseStream; }
        }
    }
}
