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

using System.IO;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Upload Part Request Marshaller
    /// </summary>       
    public class UploadPartRequestMarshaller : IMarshaller<IRequest, UploadPartRequest>
    {
        public IRequest Marshall(UploadPartRequest uploadPartRequest)
        {
            IRequest request = new DefaultRequest(uploadPartRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (uploadPartRequest.IsSetMD5Digest())
                request.Headers["Content-MD5"] = uploadPartRequest.MD5Digest;

            var uriResourcePath = string.Format("/{0}/{1}",
                                                S3Transforms.ToStringValue(uploadPartRequest.BucketName),
                                                S3Transforms.ToStringValue(uploadPartRequest.Key));

            if (uploadPartRequest.IsSetPartNumber())
                request.Parameters.Add("partNumber", S3Transforms.ToStringValue(uploadPartRequest.PartNumber));
            if (uploadPartRequest.IsSetUploadId())
                request.Parameters.Add("uploadId", S3Transforms.ToStringValue(uploadPartRequest.UploadId));

            request.CanonicalResource = S3Transforms.GetCanonicalResource(uriResourcePath, request.Parameters);
            request.ResourcePath = S3Transforms.FormatResourcePath(uriResourcePath, request.Parameters);

            if (uploadPartRequest.InputStream != null)
            {
                // Wrap input stream in partial wrapper (to upload only part of the stream)
                var partialStream = new PartialWrapperStream(uploadPartRequest.InputStream, uploadPartRequest.PartSize);

                // Wrap input stream in MD5Stream; after this we can no longer seek or position the stream
                var hashStream = new MD5Stream(partialStream, null, partialStream.Length);
                uploadPartRequest.InputStream = hashStream;
            }

            request.ContentStream = uploadPartRequest.InputStream;

            if (!request.Headers.ContainsKey("Content-Type"))
                request.Headers.Add("Content-Type", "text/plain");

            if (!request.UseQueryString)
            {
                var queryString = AWSSDKUtils.GetParametersAsString(request.Parameters);
                if (!string.IsNullOrEmpty(queryString))
                {
                    request.ResourcePath = string.Concat(request.ResourcePath, request.ResourcePath.Contains("?") ? "&" : "?", queryString);
                }
            }

            return request;
        }
    }
}

