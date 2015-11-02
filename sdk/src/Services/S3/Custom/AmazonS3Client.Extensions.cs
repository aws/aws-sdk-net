/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

#if AWS_ASYNC_API
using System.Threading.Tasks;
#endif

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.Util;
using Amazon.Util.Internal;
using Amazon.S3.Internal;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3.Util;
using Map = System.Collections.Generic.Dictionary<Amazon.S3.S3QueryParameter, string>;

namespace Amazon.S3
{
    public partial class AmazonS3Client : AmazonServiceClient, IAmazonS3
    {
		internal static void CleanupRequest(IRequest request)
        {
            var putObjectRequest = request.OriginalRequest as PutObjectRequest;
            if (putObjectRequest != null)
            {
                if (putObjectRequest.InputStream != null
                    && (!string.IsNullOrEmpty(putObjectRequest.FilePath) || putObjectRequest.AutoCloseStream))
                {
                    putObjectRequest.InputStream.Dispose();
                }

                // Set the input stream to null since it was created during the request to represent the filepath or content body
                if (!string.IsNullOrEmpty(putObjectRequest.FilePath) || !string.IsNullOrEmpty(putObjectRequest.ContentBody))
                {
                    putObjectRequest.InputStream = null;
                }
            }

            var uploadPartRequest = request.OriginalRequest as UploadPartRequest;
            if (uploadPartRequest != null)
            {
                // FilePath was set, so we created the underlying stream, so we must close it
                if (uploadPartRequest.IsSetFilePath() && uploadPartRequest.InputStream != null)
                {
                    uploadPartRequest.InputStream.Dispose();
                }

                if (uploadPartRequest.IsSetFilePath())
                    uploadPartRequest.InputStream = null;
            }
        }
    }
}

