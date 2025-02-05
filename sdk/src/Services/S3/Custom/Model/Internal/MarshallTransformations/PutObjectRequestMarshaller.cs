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
using System.Globalization;
using System.IO;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Amazon.Runtime;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Object Request Marshaller
    /// </summary>       
    public class PutObjectRequestMarshaller : IMarshaller<IRequest, PutObjectRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((PutObjectRequest)input);
        }

        public IRequest Marshall(PutObjectRequest putObjectRequest)
        {
            IRequest request = new DefaultRequest(putObjectRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if(putObjectRequest.IsSetCannedACL())
                request.Headers.Add(HeaderKeys.XAmzAclHeader, S3Transforms.ToStringValue(putObjectRequest.CannedACL));

            var headers = putObjectRequest.Headers;
            foreach (var key in headers.Keys)
                request.Headers[key] = headers[key];

            if(putObjectRequest.IsSetMD5Digest())
                request.Headers[HeaderKeys.ContentMD5Header] = putObjectRequest.MD5Digest;

            HeaderACLRequestMarshaller.Marshall(request, putObjectRequest);

            if(putObjectRequest.IsSetServerSideEncryptionMethod())
                request.Headers.Add(HeaderKeys.XAmzServerSideEncryptionHeader, S3Transforms.ToStringValue(putObjectRequest.ServerSideEncryptionMethod));

            if(putObjectRequest.IsSetStorageClass())
                request.Headers.Add(HeaderKeys.XAmzStorageClassHeader, S3Transforms.ToStringValue(putObjectRequest.StorageClass));

            if(putObjectRequest.IsSetWebsiteRedirectLocation())
                request.Headers.Add(HeaderKeys.XAmzWebsiteRedirectLocationHeader, S3Transforms.ToStringValue(putObjectRequest.WebsiteRedirectLocation));

            if (putObjectRequest.IsSetServerSideEncryptionCustomerMethod())
                request.Headers.Add(HeaderKeys.XAmzSSECustomerAlgorithmHeader, putObjectRequest.ServerSideEncryptionCustomerMethod);
            if (putObjectRequest.IsSetServerSideEncryptionCustomerProvidedKey())
            {
                request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyHeader, putObjectRequest.ServerSideEncryptionCustomerProvidedKey);
                if (putObjectRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, putObjectRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    request.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(putObjectRequest.ServerSideEncryptionCustomerProvidedKey));
            }

            if (putObjectRequest.IsSetServerSideEncryptionKeyManagementServiceKeyId())
                request.Headers.Add(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader, putObjectRequest.ServerSideEncryptionKeyManagementServiceKeyId);

            if (putObjectRequest.IsSetServerSideEncryptionKeyManagementServiceEncryptionContext())
                request.Headers.Add("x-amz-server-side-encryption-context", putObjectRequest.ServerSideEncryptionKeyManagementServiceEncryptionContext);

            if (putObjectRequest.IsSetObjectLockLegalHoldStatus())
                request.Headers.Add("x-amz-object-lock-legal-hold", S3Transforms.ToStringValue(putObjectRequest.ObjectLockLegalHoldStatus));

            if (putObjectRequest.IsSetObjectLockMode())
                request.Headers.Add("x-amz-object-lock-mode", S3Transforms.ToStringValue(putObjectRequest.ObjectLockMode));

            if (putObjectRequest.IsSetObjectLockRetainUntilDate())
                request.Headers.Add("x-amz-object-lock-retain-until-date", S3Transforms.ToStringValue(putObjectRequest.ObjectLockRetainUntilDate.Value, AWSSDKUtils.ISO8601DateFormat));

            if (putObjectRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(putObjectRequest.RequestPayer.ToString()));

            if (putObjectRequest.IsSetTagSet())
                request.Headers.Add(S3Constants.AmzHeaderTagging, AmazonS3Util.TagSetToQueryString(putObjectRequest.TagSet));

            if (putObjectRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(putObjectRequest.ExpectedBucketOwner));

            if (putObjectRequest.IsSetBucketKeyEnabled())
                request.Headers.Add(S3Constants.AmzHeaderBucketKeyEnabled, S3Transforms.ToStringValue(putObjectRequest.BucketKeyEnabled.Value));

            if (putObjectRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(putObjectRequest.ChecksumAlgorithm));

            if (putObjectRequest.IsSetChecksumCRC32())
                request.Headers.Add("x-amz-checksum-crc32", S3Transforms.ToStringValue(putObjectRequest.ChecksumCRC32));

            if (putObjectRequest.IsSetChecksumCRC32C())
                request.Headers.Add("x-amz-checksum-crc32c", S3Transforms.ToStringValue(putObjectRequest.ChecksumCRC32C));

            if (putObjectRequest.IsSetChecksumCRC64NVME())
                request.Headers.Add("x-amz-checksum-crc64nvme", S3Transforms.ToStringValue(putObjectRequest.ChecksumCRC64NVME));

            if (putObjectRequest.IsSetChecksumSHA1())
                request.Headers.Add("x-amz-checksum-sha1", S3Transforms.ToStringValue(putObjectRequest.ChecksumSHA1));

            if (putObjectRequest.IsSetChecksumSHA256())
                request.Headers.Add("x-amz-checksum-sha256", S3Transforms.ToStringValue(putObjectRequest.ChecksumSHA256));

            if (putObjectRequest.IsSetIfNoneMatch())
                request.Headers["If-None-Match"] = putObjectRequest.IfNoneMatch;

            if (putObjectRequest.IsSetIfMatch())
                request.Headers.Add(HeaderKeys.IfMatchHeader, S3Transforms.ToStringValue(putObjectRequest.IfMatch));

                
            if (putObjectRequest.IsSetWriteOffsetBytes())
                request.Headers.Add("x-amz-write-offset-bytes", S3Transforms.ToStringValue(putObjectRequest.WriteOffsetBytes));

            AmazonS3Util.SetMetadataHeaders(request, putObjectRequest.Metadata);

            if (string.IsNullOrEmpty(putObjectRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutObjectRequest.BucketName");
            if (string.IsNullOrEmpty(putObjectRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "PutObjectRequest.Key");
            request.ResourcePath = "/{Key+}";
            request.AddPathResource("{Key+}",S3Transforms.ToStringValue(putObjectRequest.Key));
            if (!request.Headers.ContainsKey(HeaderKeys.ContentTypeHeader))
                request.Headers.Add(HeaderKeys.ContentTypeHeader, "text/plain");

            // Handling of checksums, chunked encoding, wrapper streams, and content length now occurs in AmazonS3PostMarshallHandler.
            // Endpoint rules are required to execute first to determine if the request is using S3 Express, which influences which checksum to use.

            return request;
        }

        private static PutObjectRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static PutObjectRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PutObjectRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}

