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

using Amazon.S3.Model;
using Amazon.Runtime;

namespace Amazon.S3.Transfer.Internal
{
    internal abstract class BaseCommand
    {
        public abstract void Execute();

        public virtual object Return
        {
            get { return null; }
        }

        protected GetObjectRequest ConvertToGetObjectRequest(BaseDownloadRequest request)
        {
            GetObjectRequest getRequest = new GetObjectRequest
            {
                BucketName=request.BucketName,
                Key=request.Key,
                Timeout=request.Timeout,
                VersionId=request.VersionId,
            };
            getRequest.BeforeRequestEvent += RequestEventHandler;

            if (request.IsSetModifiedSinceDate())
            {
                getRequest.ModifiedSinceDate = request.ModifiedSinceDate;
            }
            if (request.IsSetUnmodifiedSinceDate())
            {
                getRequest.UnmodifiedSinceDate = request.UnmodifiedSinceDate;
            }

            return getRequest;
        }

        protected void RequestEventHandler(object sender, RequestEventArgs args)
        {
            S3RequestEventArgs s3args = args as S3RequestEventArgs;
            if (s3args != null)
            {
                string currentUserAgent = s3args.Headers[System.Net.HttpRequestHeader.UserAgent];
                s3args.Headers[System.Net.HttpRequestHeader.UserAgent] =
                    currentUserAgent + " TransferManager/" + this.GetType().Name;
            }
        }
    }
}
