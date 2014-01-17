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

using Amazon.S3.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Get Object Request Marshaller
    /// </summary>       
    public class GetObjectRequestMarshaller : IMarshaller<IRequest, GetObjectRequest>
    {
        public IRequest Marshall(GetObjectRequest getObjectRequest)
        {
            IRequest request = new DefaultRequest(getObjectRequest, "AmazonS3");

            request.HttpMethod = "GET";

            if (getObjectRequest.IsSetEtagToMatch())
                request.Headers.Add("If-Match", S3Transforms.ToStringValue(getObjectRequest.EtagToMatch));

            if (getObjectRequest.IsSetModifiedSinceDate())
                request.Headers.Add("If-Modified-Since", S3Transforms.ToStringValue(getObjectRequest.ModifiedSinceDate));

            if (getObjectRequest.IsSetEtagToNotMatch())
                request.Headers.Add("If-None-Match", S3Transforms.ToStringValue(getObjectRequest.EtagToNotMatch));
            
            if(getObjectRequest.IsSetUnmodifiedSinceDate())
                request.Headers.Add("If-Unmodified-Since", S3Transforms.ToStringValue(getObjectRequest.UnmodifiedSinceDate));
            
            if(getObjectRequest.IsSetByteRange())
                request.Headers.Add("Range", getObjectRequest.ByteRange.FormattedByteRange);

            var uriResourcePath = string.Format("/{0}/{1}",
                                                S3Transforms.ToStringValue(getObjectRequest.BucketName),
                                                S3Transforms.ToStringValue(getObjectRequest.Key));

            var headerOverrides = getObjectRequest.ResponseHeaderOverrides;
            if (headerOverrides.CacheControl != null)
                request.Parameters.Add("response-cache-control", S3Transforms.ToStringValue(headerOverrides.CacheControl));
            if (headerOverrides.ContentDisposition != null)
                request.Parameters.Add("response-content-disposition", S3Transforms.ToStringValue(headerOverrides.ContentDisposition));
            if (headerOverrides.ContentEncoding != null)
                request.Parameters.Add("response-content-encoding", S3Transforms.ToStringValue(headerOverrides.ContentEncoding));
            if (headerOverrides.ContentLanguage != null)
                request.Parameters.Add("response-content-language", S3Transforms.ToStringValue(headerOverrides.ContentLanguage));
            if (headerOverrides.ContentType != null)
                request.Parameters.Add("response-content-type", S3Transforms.ToStringValue(headerOverrides.ContentType));
            if (getObjectRequest.IsSetResponseExpires())
                request.Parameters.Add("response-expires", S3Transforms.ToStringValue(getObjectRequest.ResponseExpires));
            if (getObjectRequest.IsSetVersionId())
                request.Parameters.Add("versionId", S3Transforms.ToStringValue(getObjectRequest.VersionId));

            request.CanonicalResource = S3Transforms.GetCanonicalResource(uriResourcePath, request.Parameters, S3Constants.GetObjectExtraSubResources);
            request.ResourcePath = S3Transforms.FormatResourcePath(uriResourcePath, request.Parameters);
            request.UseQueryString = true;

            return request;
        }
    }
}
    
