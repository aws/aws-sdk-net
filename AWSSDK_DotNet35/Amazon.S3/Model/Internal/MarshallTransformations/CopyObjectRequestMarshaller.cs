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
using System.Globalization;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Copy Object Request Marshaller
    /// </summary>       
    public class CopyObjectRequestMarshaller : IMarshaller<IRequest, CopyObjectRequest>
    {
        public IRequest Marshall(CopyObjectRequest copyObjectRequest)
        {
            IRequest request = new DefaultRequest(copyObjectRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (copyObjectRequest.IsSetCannedACL())
                request.Headers.Add("x-amz-acl", S3Transforms.ToStringValue(copyObjectRequest.CannedACL));

            var headers = copyObjectRequest.Headers;
            foreach (var key in headers.Keys)
                request.Headers[key] = headers[key];

            HeaderACLRequestMarshaller.Marshall(request, copyObjectRequest);

            if (copyObjectRequest.IsSetSourceBucket())
                request.Headers.Add("x-amz-copy-source", ConstructCopySourceHeaderValue(copyObjectRequest.SourceBucket, copyObjectRequest.SourceKey, copyObjectRequest.SourceVersionId));

            if (copyObjectRequest.IsSetETagToMatch())
                request.Headers.Add("x-amz-copy-source-if-match", S3Transforms.ToStringValue(copyObjectRequest.ETagToMatch));

            if (copyObjectRequest.IsSetModifiedSinceDate())
                request.Headers.Add("x-amz-copy-source-if-modified-since", S3Transforms.ToStringValue(copyObjectRequest.ModifiedSinceDate));

            if (copyObjectRequest.IsSetETagToNotMatch())
                request.Headers.Add("x-amz-copy-source-if-none-match", S3Transforms.ToStringValue(copyObjectRequest.ETagToNotMatch));

            if (copyObjectRequest.IsSetUnmodifiedSinceDate())
                request.Headers.Add("x-amz-copy-source-if-unmodified-since", S3Transforms.ToStringValue(copyObjectRequest.UnmodifiedSinceDate));

            request.Headers.Add("x-amz-metadata-directive", S3Transforms.ToStringValue(copyObjectRequest.MetadataDirective.ToString()));

            if (copyObjectRequest.IsSetServerSideEncryptionMethod())
                request.Headers.Add("x-amz-server-side-encryption", S3Transforms.ToStringValue(copyObjectRequest.ServerSideEncryptionMethod));

            if (copyObjectRequest.IsSetStorageClass())
                request.Headers.Add("x-amz-storage-class", S3Transforms.ToStringValue(copyObjectRequest.StorageClass));

            if (copyObjectRequest.IsSetWebsiteRedirectLocation())
                request.Headers.Add("x-amz-website-redirect-location", S3Transforms.ToStringValue(copyObjectRequest.WebsiteRedirectLocation));

            AmazonS3Util.SetMetadataHeaders(request, copyObjectRequest.Metadata);

            var uriResourcePath = string.Format("/{0}/{1}",
                                                S3Transforms.ToStringValue(copyObjectRequest.DestinationBucket),
                                                S3Transforms.ToStringValue(copyObjectRequest.DestinationKey));


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
    }
}

