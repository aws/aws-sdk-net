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
    /// Create Multipart Upload Request Marshaller
    /// </summary>       
    public partial class InitiateMultipartUploadRequestMarshaller : IMarshaller<IRequest, InitiateMultipartUploadRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
        partial void PostMarshallCustomization(DefaultRequest defaultRequest, InitiateMultipartUploadRequest publicRequest)
        {
            var headers = publicRequest.Headers;
            foreach (var key in headers.Keys)
            {
                if (!string.IsNullOrEmpty(key))
                    defaultRequest.Headers.Add(key, headers[key]);
            }


            HeaderACLRequestMarshaller.Marshall(defaultRequest, publicRequest);
            AmazonS3Util.SetMetadataHeaders(defaultRequest, publicRequest.Metadata);

            // Server-side encryption with customer-provided keys (SSE-C) handling for backward compatibility.
            // When SSE-C key is provided: uses the MD5 digest if supplied, otherwise automatically computes it.
            // https://github.com/aws/aws-sdk-net/blob/ba5eca31bd2d734dfeb7512a02cb9caecdf730c2/sdk/src/Services/S3/Custom/Model/Internal/MarshallTransformations/InitiateMultipartUploadRequestMarshaller.cs#L58-L65
            if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKey())
            {
                defaultRequest.Headers[HeaderKeys.XAmzSSECustomerKeyHeader] =  publicRequest.ServerSideEncryptionCustomerProvidedKey;
                if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                    defaultRequest.Headers[HeaderKeys.XAmzSSECustomerKeyMD5Header] = publicRequest.ServerSideEncryptionCustomerProvidedKeyMD5;
                else
                    defaultRequest.Headers[HeaderKeys.XAmzSSECustomerKeyMD5Header] = AmazonS3Util.ComputeEncodedMD5FromEncodedString(publicRequest.ServerSideEncryptionCustomerProvidedKey);
            }

        }
    }
}

