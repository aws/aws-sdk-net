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
using System.Threading;

namespace Amazon.S3.Transfer.Internal
{
    internal partial class DownloadCommand : BaseCommand
    {
        IAmazonS3 _s3Client;
        TransferUtilityDownloadRequest _request;

        internal DownloadCommand(IAmazonS3 s3Client, TransferUtilityDownloadRequest request)
        {
            this._s3Client = s3Client;
            this._request = request;
        }

        private void ValidateRequest()
        {
            if (!this._request.IsSetBucketName())
            {
                throw new InvalidOperationException("The BucketName specified is null or empty!");
            }
#if BCL
            if (!this._request.IsSetFilePath())
            {
                throw new InvalidOperationException("The filepath specified is null or empty!");
            }
#elif WIN_RT || WINDOWS_PHONE
            if (!this._request.IsSetStorageFile())
            {
                throw new InvalidOperationException("The StorageFile specified is null or empty!");
            }
#endif
            if (!this._request.IsSetKey())
            {
                throw new InvalidOperationException("The Key specified is null or empty!");
            }
            }

        void OnWriteObjectProgressEvent(object sender, WriteObjectProgressArgs e)
            {
            this._request.OnRaiseProgressEvent(e);
        }
    }
}

