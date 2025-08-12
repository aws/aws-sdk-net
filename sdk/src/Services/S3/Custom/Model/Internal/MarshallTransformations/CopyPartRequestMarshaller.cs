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
using Amazon.S3.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using System.Globalization;
using Amazon.S3.Internal;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Upload Part Copy Request Marshaller
    /// </summary>       
    public partial class CopyPartRequestMarshaller : IMarshaller<IRequest, CopyPartRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
        static string ConstructCopySourceHeaderValue(string bucket, string key, string version)
        {
            string source;
            if (!String.IsNullOrEmpty(key))
            {
                var isAccessPoint = S3ArnUtils.IsS3AccessPointsArn(bucket) || S3ArnUtils.IsS3OutpostsArn(bucket);
                // 'object/' needed appended to key for copy header with access points
                source = AWSSDKUtils.UrlEncode(String.Concat(bucket, isAccessPoint ? "/object/" : "/", key), false);
                if (!String.IsNullOrEmpty(version))
                {
                    source = string.Format(CultureInfo.InvariantCulture, "{0}?versionId={1}", source, AWSSDKUtils.UrlEncode(version, true));
                }
            }
            else
            {
                source = AWSSDKUtils.UrlEncode(bucket, true);
            }

            return source;
        }

        static string ConstructCopySourceRangeHeader(long firstByte, long lastByte)
        {
            return string.Format(CultureInfo.InvariantCulture, "bytes={0}-{1}", firstByte, lastByte);
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CopyPartRequest publicRequest)
        {
            var sourceKey = publicRequest.SourceKey;
            var destinationKey = publicRequest.DestinationKey;
            if (string.IsNullOrEmpty(destinationKey))
                throw new System.ArgumentException("DestinationKey is a required property and must be set before making this call.", "CopyPartRequest.DestinationKey");
            // since Key is excluded via customization.json entry we set the path resource here.
            defaultRequest.AddPathResource("{Key+}", S3Transforms.ToStringValue(destinationKey));

            if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKey())
            {
                defaultRequest.Headers.Add(HeaderKeys.XAmzSSECustomerKeyHeader, publicRequest.ServerSideEncryptionCustomerProvidedKey);
                if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                    defaultRequest.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, publicRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    defaultRequest.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(publicRequest.ServerSideEncryptionCustomerProvidedKey));
            }

            if (publicRequest.IsSetCopySourceServerSideEncryptionCustomerProvidedKey())
            {
                defaultRequest.Headers.Add(HeaderKeys.XAmzCopySourceSSECustomerKeyHeader, publicRequest.CopySourceServerSideEncryptionCustomerProvidedKey);
                if (publicRequest.IsSetCopySourceServerSideEncryptionCustomerProvidedKeyMD5())
                    defaultRequest.Headers.Add(HeaderKeys.XAmzCopySourceSSECustomerKeyMD5Header, publicRequest.CopySourceServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    defaultRequest.Headers.Add(HeaderKeys.XAmzCopySourceSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(publicRequest.CopySourceServerSideEncryptionCustomerProvidedKey));
            }

            if (publicRequest.IsSetFirstByte() && publicRequest.IsSetLastByte())
                defaultRequest.Headers.Add(HeaderKeys.XAmzCopySourceRangeHeader, ConstructCopySourceRangeHeader(publicRequest.FirstByte.Value, publicRequest.LastByte.Value));
            if (publicRequest.IsSetSourceBucket())
                defaultRequest.Headers.Add(HeaderKeys.XAmzCopySourceHeader, ConstructCopySourceHeaderValue(publicRequest.SourceBucket, sourceKey, publicRequest.SourceVersionId));
        }
    }
}

