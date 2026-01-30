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
    public partial class GetObjectRequestMarshaller : IMarshaller<IRequest, GetObjectRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
        void ServerSideEncryptionCustomerProvidedKeyCustomMarshall(DefaultRequest request, GetObjectRequest publicRequest)
        {
            request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyHeader, publicRequest.ServerSideEncryptionCustomerProvidedKey);
            if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, publicRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
            else
                request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(publicRequest.ServerSideEncryptionCustomerProvidedKey));
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, GetObjectRequest publicRequest)
        {
            if (publicRequest.IsSetResponseExpires())
            {
                defaultRequest.Parameters.Add("response-expires", S3Transforms.ToStringValue(publicRequest.ResponseExpires.Value));
            }
            else if (publicRequest.ResponseHeaderOverrides.Expires != null)
            {
                defaultRequest.Parameters.Add("response-expires", S3Transforms.ToStringValue(publicRequest.ResponseHeaderOverrides.Expires));
            }
            var headerOverrides = publicRequest.ResponseHeaderOverrides;
            if (headerOverrides.CacheControl != null)
                defaultRequest.Parameters.Add("response-cache-control", S3Transforms.ToStringValue(headerOverrides.CacheControl));
            if (headerOverrides.ContentDisposition != null)
                defaultRequest.Parameters.Add("response-content-disposition", S3Transforms.ToStringValue(headerOverrides.ContentDisposition));
            if (headerOverrides.ContentEncoding != null)
                defaultRequest.Parameters.Add("response-content-encoding", S3Transforms.ToStringValue(headerOverrides.ContentEncoding));
            if (headerOverrides.ContentLanguage != null)
                defaultRequest.Parameters.Add("response-content-language", S3Transforms.ToStringValue(headerOverrides.ContentLanguage));
            if (headerOverrides.ContentType != null)
                defaultRequest.Parameters.Add("response-content-type", S3Transforms.ToStringValue(headerOverrides.ContentType));
        }
    }
}
    
