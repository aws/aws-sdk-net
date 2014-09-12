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

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Head Bucket Request Marshaller
    /// </summary>       
    internal class HeadBucketRequestMarshaller : IMarshaller<IRequest, HeadBucketRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((HeadBucketRequest)input);
        }

        public IRequest Marshall(HeadBucketRequest headBucketRequest)
        {
            IRequest request = new DefaultRequest(headBucketRequest, "AmazonS3");

            request.HttpMethod = "HEAD";

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(headBucketRequest.BucketName));
            request.UseQueryString = true;
            
            return request;
        }
    }
}
    
