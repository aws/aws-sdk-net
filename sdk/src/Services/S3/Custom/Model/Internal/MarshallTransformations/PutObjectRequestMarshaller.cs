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
using System;
using System.Globalization;
using System.IO;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Amazon.Runtime;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Object Request Marshaller
    /// </summary>       
    public partial class PutObjectRequestMarshaller : IMarshaller<IRequest, PutObjectRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
    {
        void ServerSideEncryptionCustomerProvidedKeyCustomMarshall(DefaultRequest request, PutObjectRequest publicRequest)
        {
            request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyHeader, publicRequest.ServerSideEncryptionCustomerProvidedKey);
            if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, publicRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
            else
                request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(publicRequest.ServerSideEncryptionCustomerProvidedKey));
        }

        // Handling of checksums, chunked encoding, wrapper streams, and content length occurs in AmazonS3PostMarshallHandler.
        // Endpoint rules are required to execute first to determine if the request is using S3 Express, which influences which checksum to use.

        partial void PreMarshallCustomization(DefaultRequest defaultRequest, PutObjectRequest publicRequest)
        {
            var headers = publicRequest.Headers;
            foreach (var key in headers.Keys)
                defaultRequest.Headers[key] = headers[key];
            HeaderACLRequestMarshaller.Marshall(defaultRequest, publicRequest);
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutObjectRequest publicRequest)
        {
            if (!defaultRequest.Headers.ContainsKey(HeaderKeys.ContentTypeHeader))
                defaultRequest.Headers.Add(HeaderKeys.ContentTypeHeader, "text/plain");
            AmazonS3Util.SetMetadataHeaders(defaultRequest, publicRequest.Metadata);
        }

        
    }
}

