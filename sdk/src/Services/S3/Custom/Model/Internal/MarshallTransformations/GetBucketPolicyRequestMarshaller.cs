/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.S3.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Get BucketName Policy Request Marshaller
    /// </summary>       
    public class GetBucketPolicyRequestMarshaller : IMarshaller<IRequest, GetBucketPolicyRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((GetBucketPolicyRequest)input);
		}

        public IRequest Marshall(GetBucketPolicyRequest getBucketPolicyRequest)
        {
            IRequest request = new DefaultRequest(getBucketPolicyRequest, "AmazonS3");

            request.Suppress404Exceptions = true;
            request.HttpMethod = "GET";

            if (getBucketPolicyRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(getBucketPolicyRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(getBucketPolicyRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "GetBucketPolicyRequest.BucketName");

            request.ResourcePath = "/";
            request.AddSubResource("policy");
            request.UseQueryString = true;
            
            return request;
        }

	    private static GetBucketPolicyRequestMarshaller _instance;

	    public static GetBucketPolicyRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new GetBucketPolicyRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}
    
