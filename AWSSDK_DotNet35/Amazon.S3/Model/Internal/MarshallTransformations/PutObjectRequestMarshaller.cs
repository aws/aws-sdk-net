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
    /// Put Object Request Marshaller
    /// </summary>       
    public class PutObjectRequestMarshaller : IMarshaller<IRequest, PutObjectRequest>
    {
        public IRequest Marshall(PutObjectRequest putObjectRequest)
        {
            IRequest request = new DefaultRequest(putObjectRequest, "AmazonS3");

            request.HttpMethod = "PUT";
            if(putObjectRequest.IsSetCannedACL())
                request.Headers.Add("x-amz-acl", S3Transforms.ToStringValue(putObjectRequest.CannedACL));

            var headers = putObjectRequest.Headers;
            foreach (var key in headers.Keys)
                request.Headers[key] = headers[key];

            if(putObjectRequest.IsSetMD5Digest())
                request.Headers["Content-MD5"] = putObjectRequest.MD5Digest;

            HeaderACLRequestMarshaller.Marshall(request, putObjectRequest);

            if(putObjectRequest.IsSetServerSideEncryptionMethod())
                request.Headers.Add("x-amz-server-side-encryption", S3Transforms.ToStringValue(putObjectRequest.ServerSideEncryptionMethod));
            
            if(putObjectRequest.IsSetStorageClass())
                request.Headers.Add("x-amz-storage-class", S3Transforms.ToStringValue(putObjectRequest.StorageClass));
            
            if(putObjectRequest.IsSetWebsiteRedirectLocation())
                request.Headers.Add("x-amz-website-redirect-location", S3Transforms.ToStringValue(putObjectRequest.WebsiteRedirectLocation));

            AmazonS3Util.SetMetadataHeaders(request, putObjectRequest.Metadata);
            
              
            Dictionary<string, string> queryParameters = new Dictionary<string, string>();
            string uriResourcePath = "/{Bucket}/{Key}"; 
            uriResourcePath = uriResourcePath.Replace("{Bucket}", putObjectRequest.IsSetBucket() ? S3Transforms.ToStringValue(putObjectRequest.BucketName) : "" ); 
            uriResourcePath = uriResourcePath.Replace("{Key}", putObjectRequest.IsSetKey() ? S3Transforms.ToStringValue(putObjectRequest.Key) : "" ); 
            string path = uriResourcePath;


            int queryIndex = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
            if (queryIndex != -1)
            {
                string queryString = uriResourcePath.Substring(queryIndex + 1);
                path = uriResourcePath.Substring(0, queryIndex);

                S3Transforms.BuildQueryParameterMap(request, queryParameters, queryString);
            }
            
            request.CanonicalResource = S3Transforms.GetCanonicalResource(path, queryParameters);
            uriResourcePath = S3Transforms.FormatResourcePath(path, queryParameters);
            
            request.ResourcePath = uriResourcePath;

            if (putObjectRequest.InputStream != null)
            {
                // Wrap the stream in a stream that has a length
                Stream streamWithLength = GetStreamWithLength(putObjectRequest.InputStream, putObjectRequest.Headers.ContentLength);

                // Wrap input stream in MD5Stream
                HashStream hashStream = new MD5Stream(streamWithLength, null, streamWithLength.Length);
                putObjectRequest.InputStream = hashStream;
            }
        
            request.ContentStream = putObjectRequest.InputStream;
            if (!request.Headers.ContainsKey("Content-Type"))
                request.Headers.Add("Content-Type", "text/plain");
        
            if (!request.UseQueryString)
            {
                string queryString = Amazon.Util.AWSSDKUtils.GetParametersAsString(request.Parameters);
                if (!string.IsNullOrEmpty(queryString))
                {
                    if (request.ResourcePath.Contains("?"))
                        request.ResourcePath = string.Concat(request.ResourcePath, "&", queryString);
                    else
                        request.ResourcePath = string.Concat(request.ResourcePath, "?", queryString);
                }
            }
                      
            return request;
        }

        // Returns a stream that has a length.
        // If the stream supports seeking, returns stream.
        // Otherwise, uses hintLength to create a read-only, non-seekable stream of given length
        private static Stream GetStreamWithLength(Stream baseStream, long hintLength)
        {
            Stream result = baseStream;
            bool shouldWrapStream = false;
            long length = -1;
            try
            {
                length = baseStream.Length;
            }
            catch (NotSupportedException)
            {
                shouldWrapStream = true;
                length = hintLength;
            }
            if (length < 0)
                throw new AmazonS3Exception("Could not determine content length");

            // Wrap input stream if base stream doesn't have a length property
            if (shouldWrapStream)
                result = new PartialReadOnlyWrapperStream(baseStream, length);

            return result;
        }
    }
}
    
