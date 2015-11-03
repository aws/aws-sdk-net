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
using System.Globalization;
using Amazon.S3.Util;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetObjectMetadata Marshaller
    /// </summary>       
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
                request.Headers.Add(HeaderKeys.IfModifiedSinceHeader, S3Transforms.ToStringValue(headObjectRequest.ModifiedSinceDate));
            
            if(headObjectRequest.IsSetEtagToNotMatch())
                request.Headers.Add(HeaderKeys.IfNoneMatchHeader, S3Transforms.ToStringValue(headObjectRequest.EtagToNotMatch));
            
            if(headObjectRequest.IsSetUnmodifiedSinceDate())
                request.Headers.Add(HeaderKeys.IfUnmodifiedSinceHeader, S3Transforms.ToStringValue(headObjectRequest.UnmodifiedSinceDate));

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

            request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}/{1}",
                                                 S3Transforms.ToStringValue(headObjectRequest.BucketName),
                                                 S3Transforms.ToStringValue(headObjectRequest.Key));

            if (headObjectRequest.IsSetVersionId())
                request.AddSubResource("versionId", S3Transforms.ToStringValue(headObjectRequest.VersionId));

            request.UseQueryString = true;
            
            return request;
        }
    }
}
    
