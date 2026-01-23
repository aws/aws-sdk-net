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
    public partial class PutObjectRequestMarshaller : IMarshaller<IRequest, PutObjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetBucketKeyEnabled()) 
            {
                request.Headers["x-amz-server-side-encryption-bucket-key-enabled"] = StringUtils.FromBool(publicRequest.BucketKeyEnabled);
            }
        
            if (publicRequest.IsSetCannedACL()) 
            {
                request.Headers["x-amz-acl"] = publicRequest.CannedACL;
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
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetExpires()) 
            {
                request.Headers["Expires"] = publicRequest.Expires;
            }
        
            if (publicRequest.IsSetIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }
        
            if (publicRequest.IsSetIfNoneMatch()) 
            {
                request.Headers["If-None-Match"] = publicRequest.IfNoneMatch;
            }
        
            if (publicRequest.IsSetMD5Digest()) 
            {
                request.Headers["Content-MD5"] = publicRequest.MD5Digest;
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
        
            if (publicRequest.IsSetServerSideEncryptionCustomerMethod()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-algorithm"] = publicRequest.ServerSideEncryptionCustomerMethod;
            }
        
            if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKey()) 
            {
                ServerSideEncryptionCustomerProvidedKeyCustomMarshall(request, publicRequest);
            }
        
            if (publicRequest.IsSetServerSideEncryptionKeyManagementServiceEncryptionContext()) 
            {
                request.Headers["x-amz-server-side-encryption-context"] = publicRequest.ServerSideEncryptionKeyManagementServiceEncryptionContext;
            }
        
            if (publicRequest.IsSetServerSideEncryptionKeyManagementServiceKeyId()) 
            {
                request.Headers["x-amz-server-side-encryption-aws-kms-key-id"] = publicRequest.ServerSideEncryptionKeyManagementServiceKeyId;
            }
        
            if (publicRequest.IsSetServerSideEncryptionMethod()) 
            {
                request.Headers["x-amz-server-side-encryption"] = publicRequest.ServerSideEncryptionMethod;
            }
        
            if (publicRequest.IsSetStorageClass()) 
            {
                request.Headers["x-amz-storage-class"] = publicRequest.StorageClass;
            }
        
            if (publicRequest.IsSetTagSet()) 
            {
                request.Headers["x-amz-tagging"] = Amazon.S3.Util.AmazonS3Util.TagSetToQueryString(publicRequest.TagSet);
            }
        
            if (publicRequest.IsSetWebsiteRedirectLocation()) 
            {
                request.Headers["x-amz-website-redirect-location"] = publicRequest.WebsiteRedirectLocation;
            }
        
            if (publicRequest.IsSetWriteOffsetBytes()) 
            {
                request.Headers["x-amz-write-offset-bytes"] = StringUtils.FromLong(publicRequest.WriteOffsetBytes);
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutObjectRequest.BucketName");
            if (string.IsNullOrEmpty(publicRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "PutObjectRequest.Key");
            request.AddPathResource("{Key+}", StringUtils.FromString(publicRequest.Key));
            request.ResourcePath = "/{Key+}";
            PostMarshallCustomization(request, publicRequest);
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

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutObjectRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, PutObjectRequest publicRequest);
    }    
}