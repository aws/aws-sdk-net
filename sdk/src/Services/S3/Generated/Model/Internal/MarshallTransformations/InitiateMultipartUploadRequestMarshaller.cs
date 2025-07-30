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
    /// InitiateMultipartUpload Request Marshaller
    /// </summary>       
    public partial class InitiateMultipartUploadRequestMarshaller : IMarshaller<IRequest, InitiateMultipartUploadRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InitiateMultipartUploadRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InitiateMultipartUploadRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "POST";
            request.AddSubResource("uploads");
        
            if (publicRequest.IsSetBucketKeyEnabled()) 
            {
                request.Headers["x-amz-server-side-encryption-bucket-key-enabled"] = StringUtils.FromBool(publicRequest.BucketKeyEnabled);
            }
        
            if (publicRequest.IsSetCannedACL()) 
            {
                request.Headers["x-amz-acl"] = StringUtils.FromString(publicRequest.CannedACL);
            }
        
            if (publicRequest.IsSetChecksumAlgorithm()) 
            {
                request.Headers["x-amz-checksum-algorithm"] = publicRequest.ChecksumAlgorithm;
            }
        
            if (publicRequest.IsSetChecksumType()) 
            {
                request.Headers["x-amz-checksum-type"] = publicRequest.ChecksumType;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
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
                request.Headers["x-amz-server-side-encryption-customer-algorithm"] = StringUtils.FromString(publicRequest.ServerSideEncryptionCustomerMethod);
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
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "InitiateMultipartUploadRequest.BucketName");
            if (string.IsNullOrEmpty(publicRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "InitiateMultipartUploadRequest.Key");
            request.AddPathResource("{Key+}", StringUtils.FromString(publicRequest.Key));
            request.ResourcePath = "/{Key+}";

            PostMarshallCustomization(request, publicRequest);
            return request;
        }
        private static InitiateMultipartUploadRequestMarshaller _instance = new InitiateMultipartUploadRequestMarshaller();        

        internal static InitiateMultipartUploadRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InitiateMultipartUploadRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, InitiateMultipartUploadRequest publicRequest);
    }    
}