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
    public class WriteGetObjectResponseRequestMarshaller : IMarshaller<IRequest, WriteGetObjectResponseRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((WriteGetObjectResponseRequest)input);
        }

        public IRequest Marshall(WriteGetObjectResponseRequest writeGetObjectResponseRequest)
        {
            IRequest request = new DefaultRequest(writeGetObjectResponseRequest, "AmazonS3");

            request.HttpMethod = "POST";

            if (!writeGetObjectResponseRequest.IsSetRequestRoute())
                throw new System.ArgumentException("RequestRoute is a required property and must be set before making this call.", "WriteGetObjectResponseRequest.RequestRoute");
            if (!writeGetObjectResponseRequest.IsSetRequestToken())
                throw new System.ArgumentException("RequestToken is a required property and must be set before making this call.", "WriteGetObjectResponseRequest.RequestToken");

            if (writeGetObjectResponseRequest.IsSetRequestRoute())
                request.Headers["x-amz-request-route"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.RequestRoute);

            if (writeGetObjectResponseRequest.IsSetRequestToken())
                request.Headers["x-amz-request-token"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.RequestToken);

            if (writeGetObjectResponseRequest.IsSetStatusCode())
                request.Headers["x-amz-fwd-status"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.StatusCode.Value);

            if (writeGetObjectResponseRequest.IsSetErrorCode())
                request.Headers["x-amz-fwd-error-code"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ErrorCode);

            if (writeGetObjectResponseRequest.IsSetErrorMessage())
                request.Headers["x-amz-fwd-error-message"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ErrorMessage);

            if (writeGetObjectResponseRequest.IsSetAcceptRanges())
                request.Headers["x-amz-fwd-header-accept-ranges"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.AcceptRanges);

            if (writeGetObjectResponseRequest.IsSetCacheControl())
                request.Headers["x-amz-fwd-header-Cache-Control"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.CacheControl);

            if (writeGetObjectResponseRequest.IsSetChecksumCRC32())
                request.Headers["x-amz-fwd-header-x-amz-checksum-crc32"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ChecksumCRC32);

            if (writeGetObjectResponseRequest.IsSetChecksumCRC32C())
                request.Headers["x-amz-fwd-header-x-amz-checksum-crc32c"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ChecksumCRC32C);

            if (writeGetObjectResponseRequest.IsSetChecksumCRC64NVME())
                request.Headers["x-amz-fwd-header-x-amz-checksum-crc64nvme"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ChecksumCRC64NVME);

            if (writeGetObjectResponseRequest.IsSetChecksumSHA1())
                request.Headers["x-amz-fwd-header-x-amz-checksum-sha1"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ChecksumSHA1);

            if (writeGetObjectResponseRequest.IsSetChecksumSHA256())
                request.Headers["x-amz-fwd-header-x-amz-checksum-sha256"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ChecksumSHA256);

            if (writeGetObjectResponseRequest.IsSetContentDisposition())
                request.Headers["x-amz-fwd-header-Content-Disposition"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ContentDisposition);

            if (writeGetObjectResponseRequest.IsSetContentEncoding())
                request.Headers["x-amz-fwd-header-Content-Encoding"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ContentEncoding);

            if (writeGetObjectResponseRequest.IsSetContentLanguage())
                request.Headers["x-amz-fwd-header-Content-Language"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ContentLanguage);

            if (writeGetObjectResponseRequest.IsSetContentRange())
                request.Headers["x-amz-fwd-header-Content-Range"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ContentRange);

            if (writeGetObjectResponseRequest.IsSetContentType())
                request.Headers["x-amz-fwd-header-Content-Type"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ContentType);

            if (writeGetObjectResponseRequest.IsSetDeleteMarker())
                request.Headers["x-amz-fwd-header-x-amz-delete-marker"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.DeleteMarker.Value);

            if (writeGetObjectResponseRequest.IsSetETag())
                request.Headers["x-amz-fwd-header-ETag"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ETag);

            if (writeGetObjectResponseRequest.IsSetExpires())
                request.Headers["x-amz-fwd-header-Expires"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.Expires.Value);

            if (writeGetObjectResponseRequest.IsSetExpiration())
                request.Headers["x-amz-fwd-header-x-amz-expiration"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.Expiration);

            if (writeGetObjectResponseRequest.IsSetLastModified())
                request.Headers["x-amz-fwd-header-Last-Modified"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.LastModified.Value);

            if (writeGetObjectResponseRequest.IsSetMissingMeta())
                request.Headers["x-amz-fwd-header-x-amz-missing-meta"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.MissingMeta.Value);

            AmazonS3Util.SetMetadataHeaders(request, writeGetObjectResponseRequest.Metadata);

            if (writeGetObjectResponseRequest.IsSetObjectLockMode())
                request.Headers["x-amz-fwd-header-x-amz-object-lock-mode"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ObjectLockMode);

            if (writeGetObjectResponseRequest.IsSetObjectLockLegalHoldStatus())
                request.Headers["x-amz-fwd-header-x-amz-object-lock-legal-hold"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ObjectLockLegalHoldStatus);

            if (writeGetObjectResponseRequest.IsSetObjectLockRetainUntilDate())
                request.Headers["x-amz-fwd-header-x-amz-object-lock-retain-until-date"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ObjectLockRetainUntilDate.Value);

            if (writeGetObjectResponseRequest.IsSetPartsCount())
                request.Headers["x-amz-fwd-header-x-amz-mp-parts-count"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.PartsCount.Value);

            if (writeGetObjectResponseRequest.IsSetReplicationStatus())
                request.Headers["x-amz-fwd-header-x-amz-replication-status"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ReplicationStatus);

            if (writeGetObjectResponseRequest.IsSetRequestCharged())
                request.Headers["x-amz-fwd-header-x-amz-request-charged"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.RequestCharged);

            if (writeGetObjectResponseRequest.IsSetRestore())
                request.Headers["x-amz-fwd-header-x-amz-restore"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.Restore);

            if (writeGetObjectResponseRequest.IsSetServerSideEncryptionMethod())
                request.Headers["x-amz-fwd-header-x-amz-server-side-encryption"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.ServerSideEncryptionMethod);

            if (writeGetObjectResponseRequest.IsSetSSECustomerAlgorithm())
                request.Headers["x-amz-fwd-header-x-amz-server-side-encryption-customer-algorithm"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.SSECustomerAlgorithm);

            if (writeGetObjectResponseRequest.IsSetSSEKMSKeyId())
                request.Headers["x-amz-fwd-header-x-amz-server-side-encryption-aws-kms-key-id"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.SSEKMSKeyId);

            if (writeGetObjectResponseRequest.IsSetSSECustomerKeyMD5())
                request.Headers["x-amz-fwd-header-x-amz-server-side-encryption-customer-key-MD5"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.SSECustomerKeyMD5);

            if (writeGetObjectResponseRequest.IsSetStorageClass())
                request.Headers["x-amz-fwd-header-x-amz-storage-class"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.StorageClass);

            if (writeGetObjectResponseRequest.IsSetTagCount())
                request.Headers["x-amz-fwd-header-x-amz-tagging-count"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.TagCount.Value);

            if (writeGetObjectResponseRequest.IsSetVersionId())
                request.Headers["x-amz-fwd-header-x-amz-version-id"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.VersionId);

            if (writeGetObjectResponseRequest.IsSetBucketKeyEnabled())
                request.Headers["x-amz-fwd-header-x-amz-server-side-encryption-bucket-key-enabled"] = S3Transforms.ToStringValue(writeGetObjectResponseRequest.BucketKeyEnabled.Value);

            var stream = writeGetObjectResponseRequest.Body ?? new MemoryStream();
            request.ContentStream = stream;
            if (writeGetObjectResponseRequest.IsSetContentLength())
            {
                var length = writeGetObjectResponseRequest.ContentLength.Value;
                request.Headers["Content-Length"] = length.ToString(CultureInfo.InvariantCulture);
            }
            else if (request.ContentStream.CanSeek)
            {
                request.Headers["Content-Length"] = request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                request.Headers[HeaderKeys.TransferEncodingHeader] = "chunked";
            }

            request.DisablePayloadSigning = true;

            if (!writeGetObjectResponseRequest.IsSetContentType())
                request.Headers["x-amz-fwd-header-Content-Type"] = "binary/octet-stream";

            var hostPrefixLabels = new
            {
                RequestRoute = StringUtils.FromString(writeGetObjectResponseRequest.RequestRoute)
            };

            if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.RequestRoute))
                throw new AmazonS3Exception("RequestRoute can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");

            request.HostPrefix = $"{hostPrefixLabels.RequestRoute}.";

            request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}",
                                                 S3Transforms.ToStringValue("WriteGetObjectResponse"));
                                                 
            return request;
        }

        private static WriteGetObjectResponseRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static WriteGetObjectResponseRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WriteGetObjectResponseRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
