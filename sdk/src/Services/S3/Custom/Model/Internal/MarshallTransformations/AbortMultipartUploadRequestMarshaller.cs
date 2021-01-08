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
using System.Globalization;
using Amazon.S3.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Abort Multipart Upload Request Marshaller
    /// </summary>       
    public class AbortMultipartUploadRequestMarshaller : IMarshaller<IRequest, AbortMultipartUploadRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((AbortMultipartUploadRequest)input);
		}

        public IRequest Marshall(AbortMultipartUploadRequest abortMultipartUploadRequest)
        {
            IRequest request = new DefaultRequest(abortMultipartUploadRequest, "AmazonS3");

            request.HttpMethod = "DELETE";

            if (abortMultipartUploadRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(abortMultipartUploadRequest.RequestPayer.ToString()));

            if (abortMultipartUploadRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(abortMultipartUploadRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(abortMultipartUploadRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "AbortMultipartUploadRequest.BucketName");
            if (string.IsNullOrEmpty(abortMultipartUploadRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "AbortMultipartUploadRequest.Key");

			request.MarshallerVersion = 2;
			request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}/{1}", 
                                                 S3Transforms.ToStringValue(abortMultipartUploadRequest.BucketName),
                                                 S3Transforms.ToStringValue(abortMultipartUploadRequest.Key));

            request.AddSubResource("uploadId", S3Transforms.ToStringValue(abortMultipartUploadRequest.UploadId));
            request.UseQueryString = true;
            
            return request;
        }

	    private static AbortMultipartUploadRequestMarshaller _instance;

	    public static AbortMultipartUploadRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new AbortMultipartUploadRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}
    
