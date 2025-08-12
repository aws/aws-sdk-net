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
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public class GetObjectMetadataRequestMarshaller : IMarshaller<IRequest, GetObjectMetadataRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((GetObjectMetadataRequest)input);
		}

        public IRequest Marshall(GetObjectMetadataRequest headObjectRequest)
        {
            if (string.IsNullOrEmpty(headObjectRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "GetObjectMetadataRequest.Key");

            IRequest request = new DefaultRequest(headObjectRequest, "AmazonS3");

            request.HttpMethod = "HEAD";

            if(headObjectRequest.IsSetEtagToMatch())
                request.Headers.Add(HeaderKeys.IfMatchHeader, S3Transforms.ToStringValue(headObjectRequest.EtagToMatch));
            
            if(headObjectRequest.IsSetModifiedSinceDate())
                request.Headers.Add(HeaderKeys.IfModifiedSinceHeader, S3Transforms.ToStringValue(headObjectRequest.ModifiedSinceDate.Value));
            
            if(headObjectRequest.IsSetEtagToNotMatch())
                request.Headers.Add(HeaderKeys.IfNoneMatchHeader, S3Transforms.ToStringValue(headObjectRequest.EtagToNotMatch));
            
            if(headObjectRequest.IsSetUnmodifiedSinceDate())
                request.Headers.Add(HeaderKeys.IfUnmodifiedSinceHeader, S3Transforms.ToStringValue(headObjectRequest.UnmodifiedSinceDate.Value));

            if (headObjectRequest.IsSetServerSideEncryptionCustomerMethod())
                request.Headers.Add(HeaderKeys.XAmzSSECustomerAlgorithmHeader, headObjectRequest.ServerSideEncryptionCustomerMethod);
            if (headObjectRequest.IsSetServerSideEncryptionCustomerProvidedKey())
            {
                request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyHeader, headObjectRequest.ServerSideEncryptionCustomerProvidedKey);
                if (headObjectRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, headObjectRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(headObjectRequest.ServerSideEncryptionCustomerProvidedKey));
            }
            if (headObjectRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(headObjectRequest.RequestPayer.ToString()));

            if (headObjectRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(headObjectRequest.ExpectedBucketOwner));

            if (headObjectRequest.IsSetChecksumMode())
                request.Headers.Add(S3Constants.AmzHeaderChecksumMode, S3Transforms.ToStringValue(headObjectRequest.ChecksumMode));
            if (headObjectRequest.IsSetResponseCacheControl())
                request.Parameters.Add("response-cache-control", S3Transforms.ToStringValue(headObjectRequest.ResponseCacheControl));

            if (headObjectRequest.IsSetResponseContentDisposition())
                request.Parameters.Add("response-content-disposition", S3Transforms.ToStringValue(headObjectRequest.ResponseContentDisposition));

            if (headObjectRequest.IsSetResponseContentEncoding())
                request.Parameters.Add("response-content-encoding", S3Transforms.ToStringValue(headObjectRequest.ResponseContentEncoding));

            if (headObjectRequest.IsSetResponseContentLanguage())
                request.Parameters.Add("response-content-language", S3Transforms.ToStringValue(headObjectRequest.ResponseContentLanguage));

            if (headObjectRequest.IsSetResponseContentType())
                request.Parameters.Add("response-content-type", S3Transforms.ToStringValue(headObjectRequest.ResponseContentType));

            if (headObjectRequest.IsSetResponseExpires())
                request.Parameters.Add("response-expires", S3Transforms.ToStringValue(headObjectRequest.ResponseExpires.Value));

            if (string.IsNullOrEmpty(headObjectRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "GetObjectMetadataRequest.BucketName");
            if (string.IsNullOrEmpty(headObjectRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "GetObjectMetadataRequest.Key");

            request.AddPathResource("{Key+}", S3Transforms.ToStringValue(headObjectRequest.Key));
            request.ResourcePath = "/{Key+}";

            if (headObjectRequest.IsSetVersionId())
                request.AddSubResource("versionId", S3Transforms.ToStringValue(headObjectRequest.VersionId));
            if (headObjectRequest.IsSetPartNumber())
                request.AddSubResource("partNumber", S3Transforms.ToStringValue(headObjectRequest.PartNumber.Value));

            request.UseQueryString = true;
            
            return request;
        }

	    private static GetObjectMetadataRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static GetObjectMetadataRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new GetObjectMetadataRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}
    
