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

using System.IO;
using System.Text;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Util;
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

            if (putBucketPolicyRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(putBucketPolicyRequest.ChecksumAlgorithm));
            if (putBucketPolicyRequest.IsSetContentMD5())
                request.Headers.Add(HeaderKeys.ContentMD5Header, S3Transforms.ToStringValue(putBucketPolicyRequest.ContentMD5));
            if (!request.Headers.ContainsKey(HeaderKeys.ContentTypeHeader))
                request.Headers.Add(HeaderKeys.ContentTypeHeader, "text/plain");
            if (putBucketPolicyRequest.IsSetConfirmRemoveSelfBucketAccess())
                request.Headers.Add(HeaderKeys.ConfirmSelfBucketAccess, S3Transforms.ToStringValue(putBucketPolicyRequest.ConfirmRemoveSelfBucketAccess.Value));
            if (putBucketPolicyRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(putBucketPolicyRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(putBucketPolicyRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketPolicyRequest.BucketName");

            request.ResourcePath = "/";

            request.AddSubResource("policy");

            request.ContentStream = new MemoryStream(Encoding.UTF8.GetBytes(putBucketPolicyRequest.Policy));

            ChecksumUtils.SetChecksumData(
                request, 
                putBucketPolicyRequest.ChecksumAlgorithm, 
                fallbackToMD5: false, 
                isRequestChecksumRequired: true,
                headerName: S3Constants.AmzHeaderSdkChecksumAlgorithm
            );

            return request;
        }

	    private static PutBucketPolicyRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static PutBucketPolicyRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new PutBucketPolicyRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}

