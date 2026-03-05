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
    public partial class GetObjectMetadataRequestMarshaller : IMarshaller<IRequest, GetObjectMetadataRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
        partial void PostMarshallCustomization(DefaultRequest defaultRequest, GetObjectMetadataRequest publicRequest)
        {
            // Server-side encryption with customer-provided keys (SSE-C) handling for backward compatibility.
            // When SSE-C key is provided: uses the MD5 digest if supplied, otherwise automatically computes it.
            // https://github.com/aws/aws-sdk-net/blob/7d8f78ce93438cae257b6f8a0b23a03b1a34c894/sdk/src/Services/S3/Custom/Model/Internal/MarshallTransformations/GetObjectMetadataRequestMarshaller.cs#L56-L63
            if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKey())
            {
                defaultRequest.Headers.Add(HeaderKeys.XAmzSSECustomerKeyHeader, publicRequest.ServerSideEncryptionCustomerProvidedKey);
                if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                    defaultRequest.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, publicRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    defaultRequest.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(publicRequest.ServerSideEncryptionCustomerProvidedKey));
            }
        }
    }
}
    
