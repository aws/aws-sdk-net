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
    /// GetBucketPolicyStatusRequestMarshaller
    /// </summary>       
    public class GetBucketPolicyStatusRequestMarshaller : IMarshaller<IRequest, GetBucketPolicyStatusRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((GetBucketPolicyStatusRequest)input);
        }

        public IRequest Marshall(GetBucketPolicyStatusRequest getBucketPolicyStatusRequest)
        {
            IRequest request = new DefaultRequest(getBucketPolicyStatusRequest, "AmazonS3");

            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(getBucketPolicyStatusRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "getBucketPolicyStatusRequest.BucketName");

			request.MarshallerVersion = 2;
			request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(getBucketPolicyStatusRequest.BucketName));
            request.AddSubResource("policyStatus");
            request.UseQueryString = true;
            
            return request;
        }

        private static GetBucketPolicyStatusRequestMarshaller _instance;

        public static GetBucketPolicyStatusRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetBucketPolicyStatusRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
    
