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

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WriteGetObjectResponse Request Marshaller
    /// </summary>       
    public partial class WriteGetObjectResponseRequestMarshaller : IMarshaller<IRequest, WriteGetObjectResponseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((WriteGetObjectResponseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(WriteGetObjectResponseRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";
        
            if (publicRequest.IsSetAcceptRanges()) 
            {
                request.Headers["x-amz-fwd-header-accept-ranges"] = publicRequest.AcceptRanges;
            }
        
            if (publicRequest.IsSetBucketKeyEnabled()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-server-side-encryption-bucket-key-enabled"] = StringUtils.FromBool(publicRequest.BucketKeyEnabled);
            }
        
            if (publicRequest.IsSetCacheControl()) 
            {
                request.Headers["x-amz-fwd-header-Cache-Control"] = publicRequest.CacheControl;
            }
        
            if (publicRequest.IsSetChecksumCRC32()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-checksum-crc32"] = publicRequest.ChecksumCRC32;
            }
        
            if (publicRequest.IsSetChecksumCRC32C()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-checksum-crc32c"] = publicRequest.ChecksumCRC32C;
            }
        
            if (publicRequest.IsSetChecksumCRC64NVME()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-checksum-crc64nvme"] = publicRequest.ChecksumCRC64NVME;
            }
        
            if (publicRequest.IsSetChecksumSHA1()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-checksum-sha1"] = publicRequest.ChecksumSHA1;
            }
        
            if (publicRequest.IsSetChecksumSHA256()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-checksum-sha256"] = publicRequest.ChecksumSHA256;
            }
        
            if (publicRequest.IsSetContentDisposition()) 
            {
                request.Headers["x-amz-fwd-header-Content-Disposition"] = publicRequest.ContentDisposition;
            }
        
            if (publicRequest.IsSetContentEncoding()) 
            {
                request.Headers["x-amz-fwd-header-Content-Encoding"] = publicRequest.ContentEncoding;
            }
        
            if (publicRequest.IsSetContentLanguage()) 
            {
                request.Headers["x-amz-fwd-header-Content-Language"] = publicRequest.ContentLanguage;
            }
        
            if (publicRequest.IsSetContentLength()) 
            {
                request.Headers["Content-Length"] = StringUtils.FromLong(publicRequest.ContentLength);
            }
        
            if (publicRequest.IsSetContentRange()) 
            {
                request.Headers["x-amz-fwd-header-Content-Range"] = publicRequest.ContentRange;
            }
        
            if (publicRequest.IsSetContentType()) 
            {
                request.Headers["x-amz-fwd-header-Content-Type"] = publicRequest.ContentType;
            }
        
            if (publicRequest.IsSetDeleteMarker()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-delete-marker"] = StringUtils.FromBool(publicRequest.DeleteMarker);
            }
        
            if (publicRequest.IsSetErrorCode()) 
            {
                request.Headers["x-amz-fwd-error-code"] = publicRequest.ErrorCode;
            }
        
            if (publicRequest.IsSetErrorMessage()) 
            {
                request.Headers["x-amz-fwd-error-message"] = publicRequest.ErrorMessage;
            }
        
            if (publicRequest.IsSetETag()) 
            {
                request.Headers["x-amz-fwd-header-ETag"] = publicRequest.ETag;
            }
        
            if (publicRequest.IsSetExpiration()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-expiration"] = publicRequest.Expiration;
            }
        
            if (publicRequest.IsSetExpires()) 
            {
                request.Headers["x-amz-fwd-header-Expires"] = StringUtils.FromDateTimeToRFC822(publicRequest.Expires);
            }
        
            if (publicRequest.IsSetLastModified()) 
            {
                request.Headers["x-amz-fwd-header-Last-Modified"] = StringUtils.FromDateTimeToRFC822(publicRequest.LastModified);
            }
        
            if (publicRequest.IsSetMissingMeta()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-missing-meta"] = StringUtils.FromInt(publicRequest.MissingMeta);
            }
        
            if (publicRequest.IsSetObjectLockLegalHoldStatus()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-object-lock-legal-hold"] = publicRequest.ObjectLockLegalHoldStatus;
            }
        
            if (publicRequest.IsSetObjectLockMode()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-object-lock-mode"] = publicRequest.ObjectLockMode;
            }
        
            if (publicRequest.IsSetObjectLockRetainUntilDate()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-object-lock-retain-until-date"] = StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ObjectLockRetainUntilDate);
            }
        
            if (publicRequest.IsSetPartsCount()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-mp-parts-count"] = StringUtils.FromInt(publicRequest.PartsCount);
            }
        
            if (publicRequest.IsSetReplicationStatus()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-replication-status"] = publicRequest.ReplicationStatus;
            }
        
            if (publicRequest.IsSetRequestCharged()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-request-charged"] = publicRequest.RequestCharged;
            }
        
            if (publicRequest.IsSetRequestRoute()) 
            {
                request.Headers["x-amz-request-route"] = publicRequest.RequestRoute;
            }
        
            if (publicRequest.IsSetRequestToken()) 
            {
                request.Headers["x-amz-request-token"] = publicRequest.RequestToken;
            }
        
            if (publicRequest.IsSetRestore()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-restore"] = publicRequest.Restore;
            }
        
            if (publicRequest.IsSetServerSideEncryptionMethod()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-server-side-encryption"] = StringUtils.FromString(publicRequest.ServerSideEncryptionMethod);
            }
        
            if (publicRequest.IsSetSSECustomerAlgorithm()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-server-side-encryption-customer-algorithm"] = StringUtils.FromString(publicRequest.SSECustomerAlgorithm);
            }
        
            if (publicRequest.IsSetSSECustomerKeyMD5()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-server-side-encryption-customer-key-MD5"] = publicRequest.SSECustomerKeyMD5;
            }
        
            if (publicRequest.IsSetSSEKMSKeyId()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-server-side-encryption-aws-kms-key-id"] = publicRequest.SSEKMSKeyId;
            }
        
            if (publicRequest.IsSetStatusCode()) 
            {
                request.Headers["x-amz-fwd-status"] = StringUtils.FromInt(publicRequest.StatusCode);
            }
        
            if (publicRequest.IsSetStorageClass()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-storage-class"] = publicRequest.StorageClass;
            }
        
            if (publicRequest.IsSetTagCount()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-tagging-count"] = StringUtils.FromInt(publicRequest.TagCount);
            }
        
            if (publicRequest.IsSetVersionId()) 
            {
                request.Headers["x-amz-fwd-header-x-amz-version-id"] = publicRequest.VersionId;
            }
            request.ResourcePath = "/WriteGetObjectResponse";
            PostMarshallCustomization(request, publicRequest);
            request.DisablePayloadSigning = true;
            return request;
        }
        private static WriteGetObjectResponseRequestMarshaller _instance = new WriteGetObjectResponseRequestMarshaller();        

        internal static WriteGetObjectResponseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WriteGetObjectResponseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, WriteGetObjectResponseRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, WriteGetObjectResponseRequest publicRequest);
    }    
}