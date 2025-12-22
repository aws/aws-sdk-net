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
using System.Globalization;
using Amazon.Util;
using Amazon.S3.Internal;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Copy Object Request Marshaller
    /// </summary>       
    public partial class CopyObjectRequestMarshaller : IMarshaller<IRequest, CopyObjectRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, CopyObjectRequest publicRequest)
        {
            HeaderACLRequestMarshaller.Marshall(defaultRequest, publicRequest);
            AmazonS3Util.SetMetadataHeaders(defaultRequest, publicRequest.Metadata);

            if (string.IsNullOrEmpty(publicRequest.SourceBucket))
                throw new System.ArgumentException("SourceBucket is a required property and must be set before making this call.", "CopyObjectRequest.SourceBucket");
            if (string.IsNullOrEmpty(publicRequest.DestinationKey))
                throw new System.ArgumentException("DestinationKey is a required property and must be set before making this call.", "CopyObjectRequest.DestinationKey");
            if (string.IsNullOrEmpty(publicRequest.SourceKey))
                throw new System.ArgumentException("SourceKey is a required property and must be set before making this call.", "CopyObjectRequest.SourceKey");

            defaultRequest.AddPathResource("{Key+}", S3Transforms.ToStringValue(publicRequest.DestinationKey));

            defaultRequest.UseQueryString = true;
        }

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

        private void CustomServerSideEncryptionCustomerProvidedKeyMarshalling(DefaultRequest request, CopyObjectRequest publicRequest)
        {
            request.Headers.Add(Amazon.Util.HeaderKeys.XAmzSSECustomerKeyHeader, publicRequest.ServerSideEncryptionCustomerProvidedKey);
            if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                request.Headers.Add(Amazon.Util.HeaderKeys.XAmzSSECustomerKeyMD5Header, publicRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
            else
                request.Headers.Add(Amazon.Util.HeaderKeys.XAmzSSECustomerKeyMD5Header, Util.AmazonS3Util.ComputeEncodedMD5FromEncodedString(publicRequest.ServerSideEncryptionCustomerProvidedKey));
        }

        private void CustomTaggingDirectiveMarshalling(DefaultRequest request, CopyObjectRequest publicRequest)
        {
            if (publicRequest.TaggingDirective == TaggingDirective.REPLACE)
            {
                if (publicRequest.IsSetTagSet())
                    request.Headers.Add(Util.S3Constants.AmzHeaderTagging, Util.AmazonS3Util.TagSetToQueryString(publicRequest.TagSet));
                request.Headers.Add(Util.S3Constants.AmzHeaderTaggingDirective, TaggingDirective.REPLACE.Value);
            }
            else if (publicRequest.TaggingDirective == TaggingDirective.COPY)
            {
                request.Headers.Add(Util.S3Constants.AmzHeaderTaggingDirective, TaggingDirective.COPY.Value);
            }
        }

        private void CustomHeadersMarshalling(DefaultRequest request, CopyObjectRequest publicRequest)
        {
            var headers = publicRequest.Headers;
            foreach (var key in headers.Keys)
                request.Headers[key] = headers[key];
        }
    }
}

