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
using System.Globalization;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Multipart Upload Request Marshaller
    /// </summary>       
    public class InitiateMultipartUploadRequestMarshaller : IMarshaller<IRequest, InitiateMultipartUploadRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((InitiateMultipartUploadRequest)input);
		}

        public IRequest Marshall(InitiateMultipartUploadRequest initiateMultipartUploadRequest)
        {
            IRequest request = new DefaultRequest(initiateMultipartUploadRequest, "AmazonS3");

            request.HttpMethod = "POST";

            if (initiateMultipartUploadRequest.IsSetCannedACL())
                request.Headers.Add(HeaderKeys.XAmzAclHeader, S3Transforms.ToStringValue(initiateMultipartUploadRequest.CannedACL));

            var headers = initiateMultipartUploadRequest.Headers;
            foreach (var key in headers.Keys)
                request.Headers.Add(key, headers[key]);

            HeaderACLRequestMarshaller.Marshall(request, initiateMultipartUploadRequest);

            if (initiateMultipartUploadRequest.IsSetServerSideEncryptionMethod())
                request.Headers.Add(HeaderKeys.XAmzServerSideEncryptionHeader, S3Transforms.ToStringValue(initiateMultipartUploadRequest.ServerSideEncryptionMethod));
            if (initiateMultipartUploadRequest.IsSetServerSideEncryptionCustomerMethod())
                request.Headers.Add(HeaderKeys.XAmzSSECustomerAlgorithmHeader, initiateMultipartUploadRequest.ServerSideEncryptionCustomerMethod);
            if (initiateMultipartUploadRequest.IsSetServerSideEncryptionCustomerProvidedKey())
            {
                request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyHeader, initiateMultipartUploadRequest.ServerSideEncryptionCustomerProvidedKey);
                if (initiateMultipartUploadRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, initiateMultipartUploadRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(initiateMultipartUploadRequest.ServerSideEncryptionCustomerProvidedKey));
            }

            if (initiateMultipartUploadRequest.IsSetServerSideEncryptionKeyManagementServiceKeyId())
                request.Headers.Add(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader, initiateMultipartUploadRequest.ServerSideEncryptionKeyManagementServiceKeyId);

            if (initiateMultipartUploadRequest.IsSetStorageClass())
                request.Headers.Add(HeaderKeys.XAmzStorageClassHeader, S3Transforms.ToStringValue(initiateMultipartUploadRequest.StorageClass));

            if (initiateMultipartUploadRequest.IsSetWebsiteRedirectLocation())
                request.Headers.Add(HeaderKeys.XAmzWebsiteRedirectLocationHeader, S3Transforms.ToStringValue(initiateMultipartUploadRequest.WebsiteRedirectLocation));

            AmazonS3Util.SetMetadataHeaders(request, initiateMultipartUploadRequest.Metadata);

            request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}/{1}",
                                                 S3Transforms.ToStringValue(initiateMultipartUploadRequest.BucketName),
                                                 S3Transforms.ToStringValue(initiateMultipartUploadRequest.Key));

            request.AddSubResource("uploads");

            request.UseQueryString = true;

            return request;
        }
    }
}

