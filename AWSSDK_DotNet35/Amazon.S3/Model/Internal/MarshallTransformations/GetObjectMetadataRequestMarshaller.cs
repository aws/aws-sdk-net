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
using Amazon.S3.Util;
using System.Globalization;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetObjectMetadata Marshaller
    /// </summary>       
    public class GetObjectMetadataRequestMarshaller : IMarshaller<IRequest, GetObjectMetadataRequest>
    {
        public IRequest Marshall(GetObjectMetadataRequest headObjectRequest)
        {
            IRequest request = new DefaultRequest(headObjectRequest, "AmazonS3");

            request.HttpMethod = "HEAD";

            if(headObjectRequest.IsSetEtagToMatch())
                request.Headers.Add("If-Match", S3Transforms.ToStringValue(headObjectRequest.EtagToMatch));
            
            if(headObjectRequest.IsSetModifiedSinceDate())
                request.Headers.Add("If-Modified-Since", S3Transforms.ToStringValue(headObjectRequest.ModifiedSinceDate));
            
            if(headObjectRequest.IsSetEtagToNotMatch())
                request.Headers.Add("If-None-Match", S3Transforms.ToStringValue(headObjectRequest.EtagToNotMatch));
            
            if(headObjectRequest.IsSetUnmodifiedSinceDate())
                request.Headers.Add("If-Unmodified-Since", S3Transforms.ToStringValue(headObjectRequest.UnmodifiedSinceDate));

            if (headObjectRequest.IsSetServerSideEncryptionCustomerMethod())
                request.Headers.Add("x-amz-server-side-encryption-customer-algorithm", headObjectRequest.ServerSideEncryptionCustomerMethod);
            if (headObjectRequest.IsSetServerSideEncryptionCustomerProvidedKey())
            {
                request.Headers.Add("x-amz-server-side-encryption-customer-key", headObjectRequest.ServerSideEncryptionCustomerProvidedKey);
                if (headObjectRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                    request.Headers.Add("x-amz-server-side-encryption-customer-key-MD5", headObjectRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    request.Headers.Add("x-amz-server-side-encryption-customer-key-MD5", AmazonS3Util.ComputeEncodedMD5FromEncodedString(headObjectRequest.ServerSideEncryptionCustomerProvidedKey));
            }


            var uriResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}/{1}",
                                                S3Transforms.ToStringValue(headObjectRequest.BucketName),
                                                S3Transforms.ToStringValue(headObjectRequest.Key));

            if (headObjectRequest.IsSetVersionId())
                request.Parameters.Add("versionId", S3Transforms.ToStringValue(headObjectRequest.VersionId));

            request.CanonicalResource = S3Transforms.GetCanonicalResource(uriResourcePath, request.Parameters);
            request.ResourcePath = S3Transforms.FormatResourcePath(uriResourcePath, request.Parameters);
            request.UseQueryString = true;
            
            return request;
        }
    }
}
    
