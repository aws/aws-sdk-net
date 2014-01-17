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
using System.Text;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Bucket Policy Request Marshaller
    /// </summary>       
    public class PutBucketPolicyRequestMarshaller : IMarshaller<IRequest, PutBucketPolicyRequest>
    {
        public IRequest Marshall(PutBucketPolicyRequest putBucketPolicyRequest)
        {
            IRequest request = new DefaultRequest(putBucketPolicyRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (putBucketPolicyRequest.IsSetContentMD5())
                request.Headers.Add("Content-MD5", S3Transforms.ToStringValue(putBucketPolicyRequest.ContentMD5));
            if (!request.Headers.ContainsKey("Content-Type"))
                request.Headers.Add("Content-Type", "text/plain");

            var uriResourcePath = string.Concat("/", S3Transforms.ToStringValue(putBucketPolicyRequest.BucketName));

            request.Parameters.Add("policy", null);

            request.CanonicalResource = S3Transforms.GetCanonicalResource(uriResourcePath, request.Parameters);
            request.ResourcePath = S3Transforms.FormatResourcePath(uriResourcePath, request.Parameters);

            request.ContentStream = new MemoryStream(Encoding.UTF8.GetBytes(putBucketPolicyRequest.Policy));

            if (!request.UseQueryString)
            {
                var queryString = Amazon.Util.AWSSDKUtils.GetParametersAsString(request.Parameters);
                if (!string.IsNullOrEmpty(queryString))
                {
                    request.ResourcePath = string.Concat(request.ResourcePath, request.ResourcePath.Contains("?") ? "&" : "?", queryString);
                }
            }

            return request;
        }
    }
}

