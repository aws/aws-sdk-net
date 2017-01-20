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
    internal partial class OpenStreamCommand : BaseCommand
    {
        IAmazonS3 _s3Client;
        TransferUtilityOpenStreamRequest _request;
        Stream _responseStream;

        internal OpenStreamCommand(IAmazonS3 s3Client, TransferUtilityOpenStreamRequest request)
        {
            this._s3Client = s3Client;
            this._request = request;
        }

        private GetObjectRequest ConstructRequest()
        {
            if (!this._request.IsSetBucketName())
            {
                throw new InvalidOperationException("The bucketName Specified is null or empty!");
            }
            if (!this._request.IsSetKey())
            {
                throw new InvalidOperationException("The key Specified is null or empty!");
            }

             return ConvertToGetObjectRequest(this._request);
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
