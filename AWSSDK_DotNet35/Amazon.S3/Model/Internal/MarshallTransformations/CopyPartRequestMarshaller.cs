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
using System;
using Amazon.S3.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using System.Globalization;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Upload Part Copy Request Marshaller
    /// </summary>       
    public class CopyPartRequestMarshaller : IMarshaller<IRequest, CopyPartRequest>
    {
        public IRequest Marshall(CopyPartRequest copyPartRequest)
        {
            IRequest request = new DefaultRequest(copyPartRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (copyPartRequest.IsSetSourceBucket())
                request.Headers.Add("x-amz-copy-source", ConstructCopySourceHeaderValue(copyPartRequest.SourceBucket, copyPartRequest.SourceKey, copyPartRequest.SourceVersionId));

            if (copyPartRequest.IsSetETagToMatch())
                request.Headers.Add("x-amz-copy-source-if-match", AWSSDKUtils.Join(copyPartRequest.ETagToMatch));

            if (copyPartRequest.IsSetETagToNotMatch())
                request.Headers.Add("x-amz-copy-source-if-none-match", AWSSDKUtils.Join(copyPartRequest.ETagsToNotMatch));

            if (copyPartRequest.IsSetModifiedSinceDate())
                request.Headers.Add("x-amz-copy-source-if-modified-since", copyPartRequest.ModifiedSinceDate.ToUniversalTime().ToString(AWSSDKUtils.GMTDateFormat, CultureInfo.InvariantCulture));

            if (copyPartRequest.IsSetUnmodifiedSinceDate())
                request.Headers.Add("x-amz-copy-source-if-unmodified-since", copyPartRequest.UnmodifiedSinceDate.ToUniversalTime().ToString(AWSSDKUtils.GMTDateFormat, CultureInfo.InvariantCulture));

            request.Headers.Add("x-amz-copy-source-range", ConstructCopySourceRangeHeader(copyPartRequest.FirstByte, copyPartRequest.LastByte));

            var uriResourcePath = string.Format("/{0}/{1}",
                                                S3Transforms.ToStringValue(copyPartRequest.DestinationBucket),
                                                S3Transforms.ToStringValue(copyPartRequest.DestinationKey));

            request.Parameters.Add("partNumber", S3Transforms.ToStringValue(copyPartRequest.PartNumber));
            request.Parameters.Add("uploadId", S3Transforms.ToStringValue(copyPartRequest.UploadId));

            request.CanonicalResource = S3Transforms.GetCanonicalResource(uriResourcePath, request.Parameters);
            request.ResourcePath = S3Transforms.FormatResourcePath(uriResourcePath, request.Parameters);
            request.UseQueryString = true;

            return request;
        }

        static string ConstructCopySourceHeaderValue(string bucket, string key, string version)
        {
            string source;
            if (!String.IsNullOrEmpty(key))
            {
                source = AmazonS3Util.UrlEncode(String.Concat("/", bucket, "/", key), true);
                if (!String.IsNullOrEmpty(version))
                {
                    source = string.Format(CultureInfo.InvariantCulture, "{0}?versionId={1}", source, AmazonS3Util.UrlEncode(version, true));
                }
            }
            else
            {
                source = AmazonS3Util.UrlEncode(bucket, true);
            }

            return source;
        }

        static string ConstructCopySourceRangeHeader(long firstByte, long lastByte)
        {
            return string.Format(CultureInfo.InvariantCulture, "bytes={0}-{1}", firstByte, lastByte);
        }
    }
}

