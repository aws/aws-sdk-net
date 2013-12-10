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
    /// Create Multipart Upload Request Marshaller
    /// </summary>       
    public class InitiateMultipartUploadRequestMarshaller : IMarshaller<IRequest, InitiateMultipartUploadRequest>
    {


        public IRequest Marshall(InitiateMultipartUploadRequest initiateMultipartUploadRequest)
        {
            IRequest request = new DefaultRequest(initiateMultipartUploadRequest, "AmazonS3");



            request.HttpMethod = "POST";
            if (initiateMultipartUploadRequest.IsSetCannedACL())
                request.Headers.Add("x-amz-acl", S3Transforms.ToStringValue(initiateMultipartUploadRequest.CannedACL));

            var headers = initiateMultipartUploadRequest.Headers;
            foreach (var key in headers.Keys)
                request.Headers.Add(key, headers[key]);

            HeaderACLRequestMarshaller.Marshall(request, initiateMultipartUploadRequest);



            if (initiateMultipartUploadRequest.IsSetServerSideEncryptionMethod())
                request.Headers.Add("x-amz-server-side-encryption", S3Transforms.ToStringValue(initiateMultipartUploadRequest.ServerSideEncryptionMethod));

            if (initiateMultipartUploadRequest.IsSetStorageClass())
                request.Headers.Add("x-amz-storage-class", S3Transforms.ToStringValue(initiateMultipartUploadRequest.StorageClass));

            if (initiateMultipartUploadRequest.IsSetWebsiteRedirectLocation())
                request.Headers.Add("x-amz-website-redirect-location", S3Transforms.ToStringValue(initiateMultipartUploadRequest.WebsiteRedirectLocation));

            AmazonS3Util.SetMetadataHeaders(request, initiateMultipartUploadRequest.Metadata);

            Dictionary<string, string> queryParameters = new Dictionary<string, string>();
            string uriResourcePath = "/{Bucket}/{Key}?uploads";
            uriResourcePath = uriResourcePath.Replace("{Bucket}", initiateMultipartUploadRequest.IsSetBucketName() ? S3Transforms.ToStringValue(initiateMultipartUploadRequest.BucketName) : "");
            uriResourcePath = uriResourcePath.Replace("{Key}", initiateMultipartUploadRequest.IsSetKey() ? S3Transforms.ToStringValue(initiateMultipartUploadRequest.Key) : "");
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


            request.UseQueryString = true;


            return request;
        }
    }
}

