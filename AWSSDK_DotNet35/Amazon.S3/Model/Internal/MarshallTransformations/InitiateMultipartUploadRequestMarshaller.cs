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

            var uriResourcePath = string.Format("/{0}/{1}",
                                                S3Transforms.ToStringValue(initiateMultipartUploadRequest.BucketName),
                                                S3Transforms.ToStringValue(initiateMultipartUploadRequest.Key));

            request.Parameters.Add("uploads", null);

            request.CanonicalResource = S3Transforms.GetCanonicalResource(uriResourcePath, request.Parameters);
            request.ResourcePath = S3Transforms.FormatResourcePath(uriResourcePath, request.Parameters);
            request.UseQueryString = true;

            return request;
        }
    }
}

