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

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;
using Amazon.Util;
using Amazon.S3.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UploadPart Request Marshaller
    /// </summary>       
    public partial class UploadPartRequestMarshaller : IMarshaller<IRequest, UploadPartRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        partial void PostMarshallCustomization(DefaultRequest defaultRequest, UploadPartRequest publicRequest)
        {
            // Server-side encryption with customer-provided keys (SSE-C) handling for backward compatibility.
            // https://github.com/aws/aws-sdk-net/blob/9ee87d97cfa1150403e84432d79e41d23abbadb7/sdk/src/Services/S3/Custom/Model/Internal/MarshallTransformations/UploadPartRequestMarshaller.cs#L68
            // When SSE-C key is provided: uses the MD5 digest if supplied, otherwise automatically computes it.
            if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKey())
            {
                defaultRequest.Headers.Add(HeaderKeys.XAmzSSECustomerKeyHeader, publicRequest.ServerSideEncryptionCustomerProvidedKey);
                if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                    defaultRequest.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, publicRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    // Automatically compute MD5 digest of the customer key if not provided
                    // This is an S3-specific convenience feature to preserve backward compatibility.
                    defaultRequest.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(publicRequest.ServerSideEncryptionCustomerProvidedKey));
            }

            // Use AddSubResource to add partNumber and uploadId to maintain consistency with the original S3 custom code.
            // The generated marshaller would add these to the defaultRequest.Parameters, so we added this custom code to
            // to preserve the exact URL structure and parameter ordering from the original implementation.
            // https://github.com/aws/aws-sdk-net/blob/9ee87d97cfa1150403e84432d79e41d23abbadb7/sdk/src/Services/S3/Custom/Model/Internal/MarshallTransformations/UploadPartRequestMarshaller.cs#L90C40-L90C50
            if (publicRequest.IsSetPartNumber())
                defaultRequest.AddSubResource("partNumber", S3Transforms.ToStringValue(publicRequest.PartNumber.Value));
            if (publicRequest.IsSetUploadId())
                defaultRequest.AddSubResource("uploadId", S3Transforms.ToStringValue(publicRequest.UploadId));

            if (!defaultRequest.Headers.ContainsKey(HeaderKeys.ContentTypeHeader))
                defaultRequest.Headers.Add(HeaderKeys.ContentTypeHeader, "text/plain");
        }
    }
}
