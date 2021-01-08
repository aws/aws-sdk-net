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
    /// Get Bucket Location Request Marshaller
    /// </summary>       
    public class GetBucketLocationRequestMarshaller : IMarshaller<IRequest, GetBucketLocationRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((GetBucketLocationRequest)input);
		}

        public IRequest Marshall(GetBucketLocationRequest getBucketLocationRequest)
        {
            IRequest request = new DefaultRequest(getBucketLocationRequest, "AmazonS3");

            request.HttpMethod = "GET";

            if (getBucketLocationRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(getBucketLocationRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(getBucketLocationRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "GetBucketLocationRequest.BucketName");

			request.MarshallerVersion = 2;
			request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(getBucketLocationRequest.BucketName));
            request.AddSubResource("location");
            request.UseQueryString = true;
            
            return request;
        }

	    private static GetBucketLocationRequestMarshaller _instance;

	    public static GetBucketLocationRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new GetBucketLocationRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}
    
