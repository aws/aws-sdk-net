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
using Amazon.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Upload Part Request Marshaller
    /// </summary>       
    public class UploadPartRequestMarshaller : IMarshaller<IRequest, UploadPartRequest>
    {


        public IRequest Marshall(UploadPartRequest uploadPartRequest)
        {
            IRequest request = new DefaultRequest(uploadPartRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (uploadPartRequest.IsSetMD5Digest())
                request.Headers["Content-MD5"] = uploadPartRequest.MD5Digest;

            Dictionary<string, string> queryParameters = new Dictionary<string, string>();
            string uriResourcePath = "/{Bucket}/{Key}?partNumber={PartNumber};uploadId={UploadId}";
            uriResourcePath = uriResourcePath.Replace("{Bucket}", uploadPartRequest.IsSetBucketName() ? S3Transforms.ToStringValue(uploadPartRequest.BucketName) : "");
            uriResourcePath = uriResourcePath.Replace("{Key}", uploadPartRequest.IsSetKey() ? S3Transforms.ToStringValue(uploadPartRequest.Key) : "");
            uriResourcePath = uriResourcePath.Replace("{PartNumber}", uploadPartRequest.IsSetPartNumber() ? S3Transforms.ToStringValue(uploadPartRequest.PartNumber) : "");
            uriResourcePath = uriResourcePath.Replace("{UploadId}", uploadPartRequest.IsSetUploadId() ? S3Transforms.ToStringValue(uploadPartRequest.UploadId) : "");
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
            if (uploadPartRequest.InputStream != null)
            {
                // Wrap input stream in partial wrapper (to upload only part of the stream)
                Stream partialStream = new PartialWrapperStream(uploadPartRequest.InputStream, uploadPartRequest.PartSize);
                // Wrap input stream in MD5Stream
                HashStream hashStream = new MD5Stream(partialStream, null, partialStream.Length);
                uploadPartRequest.InputStream = hashStream;
            }

            request.ContentStream = uploadPartRequest.InputStream;

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
    }
}

