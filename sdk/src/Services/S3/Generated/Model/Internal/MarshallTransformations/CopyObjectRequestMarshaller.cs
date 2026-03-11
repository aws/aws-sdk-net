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
    /// CopyObject Request Marshaller
    /// </summary>       
    public partial class CopyObjectRequestMarshaller : IMarshaller<IRequest, CopyObjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CopyObjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CopyObjectRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetBucketKeyEnabled()) 
            {
                request.Headers.Add(Util.S3Constants.AmzHeaderBucketKeyEnabled, S3Transforms.ToStringValue(publicRequest.BucketKeyEnabled.Value));
            }
        
            if (publicRequest.IsSetCacheControl()) 
            {
                request.Headers["Cache-Control"] = publicRequest.CacheControl;
            }
        
            if (publicRequest.IsSetCannedACL()) 
            {
                request.Headers["x-amz-acl"] = StringUtils.FromString(publicRequest.CannedACL);
            }
        
            if (publicRequest.IsSetChecksumAlgorithm()) 
            {
                request.Headers["x-amz-checksum-algorithm"] = S3Transforms.ToStringValue(publicRequest.ChecksumAlgorithm);
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
        
            if (publicRequest.IsSetCopySourceServerSideEncryptionCustomerMethod()) 
            {
                request.Headers["x-amz-copy-source-server-side-encryption-customer-algorithm"] = publicRequest.CopySourceServerSideEncryptionCustomerMethod;
            }
        
            if (publicRequest.IsSetCopySourceServerSideEncryptionCustomerProvidedKey()) 
            {
                request.Headers.Add(Amazon.Util.HeaderKeys.XAmzCopySourceSSECustomerKeyHeader, publicRequest.CopySourceServerSideEncryptionCustomerProvidedKey);
                if(publicRequest.IsSetCopySourceServerSideEncryptionCustomerProvidedKeyMD5())
                    request.Headers.Add(Amazon.Util.HeaderKeys.XAmzCopySourceSSECustomerKeyMD5Header, publicRequest.CopySourceServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    request.Headers.Add(Amazon.Util.HeaderKeys.XAmzCopySourceSSECustomerKeyMD5Header, Util.AmazonS3Util.ComputeEncodedMD5FromEncodedString(publicRequest.CopySourceServerSideEncryptionCustomerProvidedKey));
            }
        
            if (publicRequest.IsSetETagToMatch()) 
            {
                request.Headers["x-amz-copy-source-if-match"] = publicRequest.ETagToMatch;
            }
        
            if (publicRequest.IsSetETagToNotMatch()) 
            {
                request.Headers["x-amz-copy-source-if-none-match"] = publicRequest.ETagToNotMatch;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = S3Transforms.ToStringValue(publicRequest.ExpectedBucketOwner);
            }
        
            if (publicRequest.IsSetExpectedSourceBucketOwner()) 
            {
                request.Headers["x-amz-source-expected-bucket-owner"] = S3Transforms.ToStringValue(publicRequest.ExpectedSourceBucketOwner);
            }
        
            if (publicRequest.IsSetExpires()) 
            {
                request.Headers["Expires"] = publicRequest.Expires;
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
                CustomHeadersMarshalling(request, publicRequest);
        
            if (publicRequest.IsSetIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }
        
            if (publicRequest.IsSetIfNoneMatch()) 
            {
                request.Headers["If-None-Match"] = publicRequest.IfNoneMatch;
            }
                request.Headers.Add(Amazon.Util.HeaderKeys.XAmzMetadataDirectiveHeader, S3Transforms.ToStringValue(publicRequest.MetadataDirective.ToString()));
        
            if (publicRequest.IsSetModifiedSinceDate()) 
            {
                request.Headers["x-amz-copy-source-if-modified-since"] = StringUtils.FromDateTimeToRFC822(publicRequest.ModifiedSinceDate);
            }
        
            if (publicRequest.IsSetObjectLockLegalHoldStatus()) 
            {
                request.Headers["x-amz-object-lock-legal-hold"] = S3Transforms.ToStringValue(publicRequest.ObjectLockLegalHoldStatus);
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
                request.Headers["x-amz-request-payer"] = S3Transforms.ToStringValue(publicRequest.RequestPayer);
            }
        
            if (publicRequest.IsSetServerSideEncryptionCustomerMethod()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-algorithm"] = StringUtils.FromString(publicRequest.ServerSideEncryptionCustomerMethod);
            }
        
            if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKey()) 
            {
                CustomServerSideEncryptionCustomerProvidedKeyMarshalling(request, publicRequest);
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
        
            if (publicRequest.IsSetSourceBucket()) 
            {
                request.Headers.Add(Amazon.Util.HeaderKeys.XAmzCopySourceHeader, ConstructCopySourceHeaderValue(publicRequest.SourceBucket, publicRequest.SourceKey, publicRequest.SourceVersionId));
            }
        
            if (publicRequest.IsSetStorageClass()) 
            {
                request.Headers["x-amz-storage-class"] = S3Transforms.ToStringValue(publicRequest.StorageClass);
            }
        
            if (publicRequest.IsSetTaggingDirective()) 
            {
                CustomTaggingDirectiveMarshalling(request, publicRequest);
            }
        
            if (publicRequest.IsSetUnmodifiedSinceDate()) 
            {
                request.Headers["x-amz-copy-source-if-unmodified-since"] = StringUtils.FromDateTimeToRFC822(publicRequest.UnmodifiedSinceDate);
            }
        
            if (publicRequest.IsSetWebsiteRedirectLocation()) 
            {
                request.Headers["x-amz-website-redirect-location"] = S3Transforms.ToStringValue(publicRequest.WebsiteRedirectLocation);
            }
            if (string.IsNullOrEmpty(publicRequest.DestinationBucket))
                throw new System.ArgumentException("DestinationBucket is a required property and must be set before making this call.", "CopyObjectRequest.DestinationBucket");
            request.ResourcePath = "/{Key+}";

            PostMarshallCustomization(request, publicRequest);
            return request;
        }
        private static CopyObjectRequestMarshaller _instance = new CopyObjectRequestMarshaller();        

        internal static CopyObjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CopyObjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CopyObjectRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, CopyObjectRequest publicRequest);
    }    
}