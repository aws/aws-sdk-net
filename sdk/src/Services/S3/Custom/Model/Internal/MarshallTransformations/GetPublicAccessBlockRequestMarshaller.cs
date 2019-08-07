/*
 * Copyright 2010-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetPublicAccessBlockRequestMarshaller
    /// </summary>       
    public class GetPublicAccessBlockRequestMarshaller : IMarshaller<IRequest, GetPublicAccessBlockRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((GetPublicAccessBlockRequest)input);
        }

        public IRequest Marshall(GetPublicAccessBlockRequest getPublicAccessBlockRequest)
        {
            IRequest request = new DefaultRequest(getPublicAccessBlockRequest, "AmazonS3");

            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(getPublicAccessBlockRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "getPublicAccessBlockRequest.BucketName");

			request.MarshallerVersion = 2;
			request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(getPublicAccessBlockRequest.BucketName));
            request.AddSubResource("publicAccessBlock");
            request.UseQueryString = true;
            
            return request;
        }

        private static GetPublicAccessBlockRequestMarshaller _instance;

        public static GetPublicAccessBlockRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetPublicAccessBlockRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
    
