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
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

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


            Dictionary<string, string> queryParameters = new Dictionary<string, string>();
            string uriResourcePath = "/{Bucket}/{Key}?versionId={VersionId};response-content-type={ResponseContentType};response-content-language={ResponseContentLanguage};response-expires={ResponseExpires};response-cache-control={ResponseCacheControl};response-content-disposition={ResponseContentDisposition};response-content-encoding={ResponseContentEncoding}"; 
            uriResourcePath = uriResourcePath.Replace("{Bucket}", getObjectRequest.IsSetBucketName() ? S3Transforms.ToStringValue(getObjectRequest.BucketName) : "" ); 
            uriResourcePath = uriResourcePath.Replace("{Key}", getObjectRequest.IsSetKey() ? S3Transforms.ToStringValue(getObjectRequest.Key) : "" ); 
            uriResourcePath = uriResourcePath.Replace("{ResponseCacheControl}", S3Transforms.ToStringValue(getObjectRequest.ResponseHeaderOverrides.CacheControl));
            uriResourcePath = uriResourcePath.Replace("{ResponseContentDisposition}", S3Transforms.ToStringValue(getObjectRequest.ResponseHeaderOverrides.ContentDisposition));
            uriResourcePath = uriResourcePath.Replace("{ResponseContentEncoding}", S3Transforms.ToStringValue(getObjectRequest.ResponseHeaderOverrides.ContentEncoding));
            uriResourcePath = uriResourcePath.Replace("{ResponseContentLanguage}", S3Transforms.ToStringValue(getObjectRequest.ResponseHeaderOverrides.ContentLanguage));
            uriResourcePath = uriResourcePath.Replace("{ResponseContentType}", S3Transforms.ToStringValue(getObjectRequest.ResponseHeaderOverrides.ContentType)); 
            uriResourcePath = uriResourcePath.Replace("{ResponseExpires}", getObjectRequest.IsSetResponseExpires() ? S3Transforms.ToStringValue(getObjectRequest.ResponseExpires) : "" ); 
            uriResourcePath = uriResourcePath.Replace("{VersionId}", getObjectRequest.IsSetVersionId() ? S3Transforms.ToStringValue(getObjectRequest.VersionId) : "" ); 
            string path = uriResourcePath;


            int queryIndex = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
            if (queryIndex != -1) 
            {
                string queryString = uriResourcePath.Substring(queryIndex + 1);
                path = uriResourcePath.Substring(0, queryIndex);

                S3Transforms.BuildQueryParameterMap(request, queryParameters, queryString);
            }
            
            request.CanonicalResource = S3Transforms.GetCanonicalResource(path, queryParameters, S3Constants.GetObjectExtraSubResources);
            uriResourcePath = S3Transforms.FormatResourcePath(path, queryParameters);
            
            request.ResourcePath = uriResourcePath;
            
            request.UseQueryString = true;

            return request;
        }
    }
}
    
