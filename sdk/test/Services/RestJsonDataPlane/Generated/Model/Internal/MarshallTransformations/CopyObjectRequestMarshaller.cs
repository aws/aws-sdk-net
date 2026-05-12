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
 * Do not modify this file. This file is generated from the restjsondataplane-1999-12-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonDataPlane.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.RestJsonDataPlane.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CopyObject Request Marshaller
    /// </summary>       
    public class CopyObjectRequestMarshaller : IMarshaller<IRequest, CopyObjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonDataPlane");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "1999-12-31";
            request.HttpMethod = "PUT";

            request.AddSubResource("x-id", "CopyObject");
            if (!publicRequest.IsSetBucket())
                throw new AmazonRestJsonDataPlaneException("Request object does not have required field Bucket set");
            request.AddPathResource("{Bucket}", StringUtils.FromString(publicRequest.Bucket));
            if (!publicRequest.IsSetKey())
                throw new AmazonRestJsonDataPlaneException("Request object does not have required field Key set");
            request.AddPathResource("{Key+}", StringUtils.FromString(publicRequest.Key.TrimStart('/')));
            request.ResourcePath = "/{Bucket}/{Key+}";
        
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
                request.Headers["x-amz-checksum-algorithm"] = publicRequest.ChecksumAlgorithm;
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
        
            if (publicRequest.IsSetContentType()) 
            {
                request.Headers["Content-Type"] = publicRequest.ContentType;
            }
        
            if (publicRequest.IsSetCopySource()) 
            {
                request.Headers["x-amz-copy-source"] = publicRequest.CopySource;
            }
        
            if (publicRequest.IsSetCopySourceIfMatch()) 
            {
                request.Headers["x-amz-copy-source-if-match"] = publicRequest.CopySourceIfMatch;
            }
        
            if (publicRequest.IsSetCopySourceIfModifiedSince()) 
            {
                request.Headers["x-amz-copy-source-if-modified-since"] = StringUtils.FromDateTimeToRFC822(publicRequest.CopySourceIfModifiedSince);
            }
        
            if (publicRequest.IsSetCopySourceIfNoneMatch()) 
            {
                request.Headers["x-amz-copy-source-if-none-match"] = publicRequest.CopySourceIfNoneMatch;
            }
        
            if (publicRequest.IsSetCopySourceIfUnmodifiedSince()) 
            {
                request.Headers["x-amz-copy-source-if-unmodified-since"] = StringUtils.FromDateTimeToRFC822(publicRequest.CopySourceIfUnmodifiedSince);
            }
        
            if (publicRequest.IsSetCopySourceSSECustomerAlgorithm()) 
            {
                request.Headers["x-amz-copy-source-server-side-encryption-customer-algorithm"] = publicRequest.CopySourceSSECustomerAlgorithm;
            }
        
            if (publicRequest.IsSetCopySourceSSECustomerKey()) 
            {
                request.Headers["x-amz-copy-source-server-side-encryption-customer-key"] = publicRequest.CopySourceSSECustomerKey;
            }
        
            if (publicRequest.IsSetCopySourceSSECustomerKeyMD5()) 
            {
                request.Headers["x-amz-copy-source-server-side-encryption-customer-key-MD5"] = publicRequest.CopySourceSSECustomerKeyMD5;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetExpectedSourceBucketOwner()) 
            {
                request.Headers["x-amz-source-expected-bucket-owner"] = publicRequest.ExpectedSourceBucketOwner;
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
        
            if (publicRequest.IsSetMetadataDirective()) 
            {
                request.Headers["x-amz-metadata-directive"] = publicRequest.MetadataDirective;
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
                request.Headers["x-amz-object-lock-retain-until-date"] = StringUtils.FromDateTimeToRFC822(publicRequest.ObjectLockRetainUntilDate);
            }
        
            if (publicRequest.IsSetRequestPayer()) 
            {
                request.Headers["x-amz-request-payer"] = publicRequest.RequestPayer;
            }
        
            if (publicRequest.IsSetServerSideEncryption()) 
            {
                request.Headers["x-amz-server-side-encryption"] = publicRequest.ServerSideEncryption;
            }
        
            if (publicRequest.IsSetSSECustomerAlgorithm()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-algorithm"] = publicRequest.SSECustomerAlgorithm;
            }
        
            if (publicRequest.IsSetSSECustomerKey()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-key"] = publicRequest.SSECustomerKey;
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
        
            if (publicRequest.IsSetTaggingDirective()) 
            {
                request.Headers["x-amz-tagging-directive"] = publicRequest.TaggingDirective;
            }
        
            if (publicRequest.IsSetWebsiteRedirectLocation()) 
            {
                request.Headers["x-amz-website-redirect-location"] = publicRequest.WebsiteRedirectLocation;
            }

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

    }
}