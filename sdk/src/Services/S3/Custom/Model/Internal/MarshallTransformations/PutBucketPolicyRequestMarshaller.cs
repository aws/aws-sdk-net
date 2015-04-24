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
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Bucket Policy Request Marshaller
    /// </summary>       
    public class PutBucketPolicyRequestMarshaller : IMarshaller<IRequest, PutBucketPolicyRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((PutBucketPolicyRequest)input);
		}

        public IRequest Marshall(PutBucketPolicyRequest putBucketPolicyRequest)
        {
            IRequest request = new DefaultRequest(putBucketPolicyRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (putBucketPolicyRequest.IsSetContentMD5())
                request.Headers.Add(HeaderKeys.ContentMD5Header, S3Transforms.ToStringValue(putBucketPolicyRequest.ContentMD5));
            if (!request.Headers.ContainsKey(HeaderKeys.ContentTypeHeader))
                request.Headers.Add(HeaderKeys.ContentTypeHeader, "text/plain");

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(putBucketPolicyRequest.BucketName));

            request.AddSubResource("policy");

            request.ContentStream = new MemoryStream(Encoding.UTF8.GetBytes(putBucketPolicyRequest.Policy));

            return request;
        }
    }
}

