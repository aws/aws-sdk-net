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
using System.Net;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

using Amazon.Util;
using Amazon.S3.Util;
using System.Globalization;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for GetObjectMetadata operation
    /// </summary>
    public partial class GetObjectMetadataResponseUnmarshaller : S3ReponseUnmarshaller
    {
        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, GetObjectMetadataResponse response)
        {
            var responseData = context.ResponseData;
            foreach (var name in responseData.GetHeaderNames())
            {
                if (name.StartsWith("x-amz-meta-", StringComparison.OrdinalIgnoreCase))
                {
                    response.Metadata[name] = AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata
                        ? Uri.UnescapeDataString(responseData.GetHeaderValue(name)) : responseData.GetHeaderValue(name);
                }
            }
            if (responseData.IsHeaderPresent("x-amz-restore"))
            {
                bool restoreInProgress;
                DateTime? restoreExpiration;
                AmazonS3Util.ParseAmzRestoreHeader(responseData.GetHeaderValue("x-amz-restore"), out restoreInProgress, out restoreExpiration);

                response.RestoreInProgress = restoreInProgress;
                response.RestoreExpiration = restoreExpiration;
            }
            if (responseData.IsHeaderPresent("x-amz-expiration"))
                response.Expiration = new Expiration(responseData.GetHeaderValue("x-amz-expiration"));
            if (responseData.IsHeaderPresent("x-amz-delete-marker"))
                response.DeleteMarker = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-delete-marker"));
            if (responseData.IsHeaderPresent("Cache-Control"))
                response.Headers.CacheControl = S3Transforms.ToString(responseData.GetHeaderValue("Cache-Control"));
            if (responseData.IsHeaderPresent("Content-Disposition"))
                response.Headers.ContentDisposition = S3Transforms.ToString(responseData.GetHeaderValue("Content-Disposition"));
            if (responseData.IsHeaderPresent("Content-Encoding"))
                response.Headers.ContentEncoding = S3Transforms.ToString(responseData.GetHeaderValue("Content-Encoding"));
            if (responseData.IsHeaderPresent("Content-Length"))
                response.Headers.ContentLength = long.Parse(responseData.GetHeaderValue("Content-Length"), CultureInfo.InvariantCulture);
            if (responseData.IsHeaderPresent("Content-Type"))
                response.Headers.ContentType = S3Transforms.ToString(responseData.GetHeaderValue("Content-Type"));
            if (responseData.IsHeaderPresent("Expires"))
                response.ExpiresString = S3Transforms.ToString(responseData.GetHeaderValue("Expires"));
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption-customer-algorithm"))
                response.ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.FindValue(responseData.GetHeaderValue("x-amz-server-side-encryption-customer-algorithm"));
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption"))
                response.ServerSideEncryptionMethod = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption"));
        }
    }
}
    
