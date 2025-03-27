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
    /// PutObject Request Marshaller
    /// </summary>       
    public class PutObjectRequestMarshaller : IMarshaller<IRequest, PutObjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutObjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutObjectRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetACL()) 
            {
                request.Headers["x-amz-acl"] = publicRequest.ACL;
            }
        
            if (publicRequest.IsSetBucketKeyEnabled()) 
            {
                request.Headers["x-amz-server-side-encryption-bucket-key-enabled"] = StringUtils.FromBool(publicRequest.BucketKeyEnabled);
            }
        
            if (publicRequest.IsSetCacheControl()) 
            {
                request.Headers["Cache-Control"] = publicRequest.CacheControl;
            }
        
            if (publicRequest.IsSetChecksumAlgorithm()) 
            {
                request.Headers["x-amz-sdk-checksum-algorithm"] = publicRequest.ChecksumAlgorithm;
            }
        
            if (publicRequest.IsSetChecksumCRC32()) 
            {
                request.Headers["x-amz-checksum-crc32"] = publicRequest.ChecksumCRC32;
            }
        
            if (publicRequest.IsSetChecksumCRC32C()) 
            {
                request.Headers["x-amz-checksum-crc32c"] = publicRequest.ChecksumCRC32C;
            }
        
            if (publicRequest.IsSetChecksumCRC64NVME()) 
            {
                request.Headers["x-amz-checksum-crc64nvme"] = publicRequest.ChecksumCRC64NVME;
            }
        
            if (publicRequest.IsSetChecksumSHA1()) 
            {
                request.Headers["x-amz-checksum-sha1"] = publicRequest.ChecksumSHA1;
            }
        
            if (publicRequest.IsSetChecksumSHA256()) 
            {
                request.Headers["x-amz-checksum-sha256"] = publicRequest.ChecksumSHA256;
            }
        
            if (publicRequest.IsSetContentDisposition()) 
            {
                request.Headers["Content-Disposition"] = publicRequest.ContentDisposition;
            }
        
            if (publicRequest.IsSetContentEncoding()) 
            {
                request.Headers["Content-Encoding"] = publicRequest.ContentEncoding;
            }
        
            if (publicRequest.IsSetContentLanguage()) 
            {
                request.Headers["Content-Language"] = publicRequest.ContentLanguage;
            }
        
            if (publicRequest.IsSetContentLength()) 
            {
                request.Headers["Content-Length"] = StringUtils.FromLong(publicRequest.ContentLength);
            }
        
            if (publicRequest.IsSetContentMD5()) 
            {
                request.Headers["Content-MD5"] = publicRequest.ContentMD5;
            }
        
            if (publicRequest.IsSetContentType()) 
            {
                request.Headers["Content-Type"] = publicRequest.ContentType;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetExpires()) 
            {
                request.Headers["Expires"] = StringUtils.FromDateTimeToRFC822(publicRequest.Expires);
            }
        
            if (publicRequest.IsSetGrantFullControl()) 
            {
                request.Headers["x-amz-grant-full-control"] = publicRequest.GrantFullControl;
            }
        
            if (publicRequest.IsSetGrantRead()) 
            {
                request.Headers["x-amz-grant-read"] = publicRequest.GrantRead;
            }
        
            if (publicRequest.IsSetGrantReadACP()) 
            {
                request.Headers["x-amz-grant-read-acp"] = publicRequest.GrantReadACP;
            }
        
            if (publicRequest.IsSetGrantWriteACP()) 
            {
                request.Headers["x-amz-grant-write-acp"] = publicRequest.GrantWriteACP;
            }
        
            if (publicRequest.IsSetIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }
        
            if (publicRequest.IsSetIfNoneMatch()) 
            {
                request.Headers["If-None-Match"] = publicRequest.IfNoneMatch;
            }
        
            if (publicRequest.IsSetMetadata()) 
            {
                //Map of headers with prefix "x-amz-meta-".
                foreach (var kvpMetadata in publicRequest.Metadata)
                {
                     request.Headers[$"x-amz-meta-{kvpMetadata.Key}"] = kvpMetadata.Value;
                }
            }
        
            if (publicRequest.IsSetObjectLockLegalHoldStatus()) 
            {
                request.Headers["x-amz-object-lock-legal-hold"] = publicRequest.ObjectLockLegalHoldStatus;
            }
        
            if (publicRequest.IsSetObjectLockMode()) 
            {
                request.Headers["x-amz-object-lock-mode"] = publicRequest.ObjectLockMode;
            }
        
            if (publicRequest.IsSetObjectLockRetainUntilDate()) 
            {
                request.Headers["x-amz-object-lock-retain-until-date"] = StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ObjectLockRetainUntilDate);
            }
        
            if (publicRequest.IsSetRequestPayer()) 
            {
                request.Headers["x-amz-request-payer"] = publicRequest.RequestPayer;
            }
        
            if (publicRequest.IsSetServerSideEncryption()) 
            {
                request.Headers["x-amz-server-side-encryption"] = publicRequest.ServerSideEncryption;
            }
        
            if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKey()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-key"] = publicRequest.ServerSideEncryptionCustomerProvidedKey;
            }
        
            if (publicRequest.IsSetSSECustomerAlgorithm()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-algorithm"] = publicRequest.SSECustomerAlgorithm;
            }
        
            if (publicRequest.IsSetSSECustomerKeyMD5()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-key-MD5"] = publicRequest.SSECustomerKeyMD5;
            }
        
            if (publicRequest.IsSetSSEKMSEncryptionContext()) 
            {
                request.Headers["x-amz-server-side-encryption-context"] = publicRequest.SSEKMSEncryptionContext;
            }
        
            if (publicRequest.IsSetSSEKMSKeyId()) 
            {
                request.Headers["x-amz-server-side-encryption-aws-kms-key-id"] = publicRequest.SSEKMSKeyId;
            }
        
            if (publicRequest.IsSetStorageClass()) 
            {
                request.Headers["x-amz-storage-class"] = publicRequest.StorageClass;
            }
        
            if (publicRequest.IsSetTagging()) 
            {
                request.Headers["x-amz-tagging"] = publicRequest.Tagging;
            }
        
            if (publicRequest.IsSetWebsiteRedirectLocation()) 
            {
                request.Headers["x-amz-website-redirect-location"] = publicRequest.WebsiteRedirectLocation;
            }
        
            if (publicRequest.IsSetWriteOffsetBytes()) 
            {
                request.Headers["x-amz-write-offset-bytes"] = StringUtils.FromLong(publicRequest.WriteOffsetBytes);
            }
            if (!publicRequest.IsSetBucketName())
                throw new AmazonS3Exception("Request object does not have required field BucketName set");
            request.AddPathResource("{Bucket}", StringUtils.FromString(publicRequest.BucketName));
            if (!publicRequest.IsSetKey())
                throw new AmazonS3Exception("Request object does not have required field Key set");
            request.AddPathResource("{Key+}", StringUtils.FromString(publicRequest.Key.TrimStart('/')));
            request.ResourcePath = "/{Bucket}/{Key+}";

            request.ContentStream = publicRequest.Body;
            request.Headers["Content-Type"] = "application/octet-stream";

            return request;
        }
        private static PutObjectRequestMarshaller _instance = new PutObjectRequestMarshaller();        

        internal static PutObjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutObjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}