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

using Amazon.S3.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using System.Globalization;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Get Object Request Marshaller
    /// </summary>       
    public class GetObjectRequestMarshaller : IMarshaller<IRequest, GetObjectRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((GetObjectRequest)input);
		}

        public IRequest Marshall(GetObjectRequest getObjectRequest)
        {
            if (string.IsNullOrEmpty(getObjectRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "GetObjectRequest.Key");

            IRequest request = new DefaultRequest(getObjectRequest, "AmazonS3");

            request.HttpMethod = "GET";

            if (getObjectRequest.IsSetEtagToMatch())
                request.Headers.Add(HeaderKeys.IfMatchHeader, S3Transforms.ToStringValue(getObjectRequest.EtagToMatch));

            if (getObjectRequest.IsSetModifiedSinceDateUtc())
                request.Headers.Add(HeaderKeys.IfModifiedSinceHeader, S3Transforms.ToStringValue(getObjectRequest.ModifiedSinceDateUtc));

            if (getObjectRequest.IsSetEtagToNotMatch())
                request.Headers.Add(HeaderKeys.IfNoneMatchHeader, S3Transforms.ToStringValue(getObjectRequest.EtagToNotMatch));
            
            if(getObjectRequest.IsSetUnmodifiedSinceDateUtc())
                request.Headers.Add(HeaderKeys.IfUnmodifiedSinceHeader, S3Transforms.ToStringValue(getObjectRequest.UnmodifiedSinceDateUtc));
            
            if(getObjectRequest.IsSetByteRange())
                request.Headers.Add(HeaderKeys.RangeHeader, getObjectRequest.ByteRange.FormattedByteRange);

            if (getObjectRequest.IsSetServerSideEncryptionCustomerMethod())
                request.Headers.Add(HeaderKeys.XAmzSSECustomerAlgorithmHeader, getObjectRequest.ServerSideEncryptionCustomerMethod);
            if (getObjectRequest.IsSetServerSideEncryptionCustomerProvidedKey())
            {
                request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyHeader, getObjectRequest.ServerSideEncryptionCustomerProvidedKey);
                if (getObjectRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, getObjectRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(getObjectRequest.ServerSideEncryptionCustomerProvidedKey));
            }
            if (getObjectRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(getObjectRequest.RequestPayer.ToString()));

            if (getObjectRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(getObjectRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(getObjectRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "GetObjectRequest.BucketName");
            if (string.IsNullOrEmpty(getObjectRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "GetObjectRequest.Key");

			request.MarshallerVersion = 2;
			request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}/{1}",
                                                 S3Transforms.ToStringValue(getObjectRequest.BucketName),
                                                 S3Transforms.ToStringValue(getObjectRequest.Key));

            var headerOverrides = getObjectRequest.ResponseHeaderOverrides;
            if (headerOverrides.CacheControl != null)
                request.Parameters.Add("response-cache-control", S3Transforms.ToStringValue(headerOverrides.CacheControl));
            if (headerOverrides.ContentDisposition != null)
                request.Parameters.Add("response-content-disposition", S3Transforms.ToStringValue(headerOverrides.ContentDisposition));
            if (headerOverrides.ContentEncoding != null)
                request.Parameters.Add("response-content-encoding", S3Transforms.ToStringValue(headerOverrides.ContentEncoding));
            if (headerOverrides.ContentLanguage != null)
                request.Parameters.Add("response-content-language", S3Transforms.ToStringValue(headerOverrides.ContentLanguage));
            if (headerOverrides.ContentType != null)
                request.Parameters.Add("response-content-type", S3Transforms.ToStringValue(headerOverrides.ContentType));
            if (getObjectRequest.IsSetResponseExpiresUtc())
                request.Parameters.Add("response-expires", S3Transforms.ToStringValue(getObjectRequest.ResponseExpiresUtc));
            if (getObjectRequest.IsSetVersionId())
                request.AddSubResource("versionId", S3Transforms.ToStringValue(getObjectRequest.VersionId));
            if (getObjectRequest.IsSetPartNumber())
                request.AddSubResource("partNumber", S3Transforms.ToStringValue(getObjectRequest.PartNumber.Value));

            request.UseQueryString = true;

            return request;
        }

	    private static GetObjectRequestMarshaller _instance;

	    public static GetObjectRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new GetObjectRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}
    
