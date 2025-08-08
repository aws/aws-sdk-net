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
    /// CopyPart Request Marshaller
    /// </summary>       
    public partial class CopyPartRequestMarshaller : IMarshaller<IRequest, CopyPartRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CopyPartRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CopyPartRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetCopySourceServerSideEncryptionCustomerMethod()) 
            {
                request.Headers["x-amz-copy-source-server-side-encryption-customer-algorithm"] = StringUtils.FromString(publicRequest.CopySourceServerSideEncryptionCustomerMethod);
            }
        
            if (publicRequest.IsSetETagsToNotMatch()) 
            {
                request.Headers["x-amz-copy-source-if-none-match"] = Amazon.Util.AWSSDKUtils.Join(publicRequest.ETagsToNotMatch);
            }
        
            if (publicRequest.IsSetETagToMatch()) 
            {
                request.Headers["x-amz-copy-source-if-match"] = Amazon.Util.AWSSDKUtils.Join(publicRequest.ETagToMatch);
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetExpectedSourceBucketOwner()) 
            {
                request.Headers["x-amz-source-expected-bucket-owner"] = publicRequest.ExpectedSourceBucketOwner;
            }
        
            if (publicRequest.IsSetModifiedSinceDate()) 
            {
                request.Headers["x-amz-copy-source-if-modified-since"] = StringUtils.FromDateTimeToRFC822(publicRequest.ModifiedSinceDate);
            }
        
            if (publicRequest.IsSetRequestPayer()) 
            {
                request.Headers["x-amz-request-payer"] = publicRequest.RequestPayer;
            }
        
            if (publicRequest.IsSetServerSideEncryptionCustomerMethod()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-algorithm"] = StringUtils.FromString(publicRequest.ServerSideEncryptionCustomerMethod);
            }
        
            if (publicRequest.IsSetUnmodifiedSinceDate()) 
            {
                request.Headers["x-amz-copy-source-if-unmodified-since"] = StringUtils.FromDateTimeToRFC822(publicRequest.UnmodifiedSinceDate);
            }
            if (string.IsNullOrEmpty(publicRequest.DestinationBucket))
                throw new System.ArgumentException("DestinationBucket is a required property and must be set before making this call.", "CopyPartRequest.DestinationBucket");
            
            if (publicRequest.IsSetPartNumber())
                request.AddSubResource("partNumber", StringUtils.FromInt(publicRequest.PartNumber));
            
            if (publicRequest.IsSetUploadId())
                request.AddSubResource("uploadId", StringUtils.FromString(publicRequest.UploadId));
            request.ResourcePath = "/{Key+}";

            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;
            return request;
        }
        private static CopyPartRequestMarshaller _instance = new CopyPartRequestMarshaller();        

        internal static CopyPartRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CopyPartRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CopyPartRequest publicRequest);
    }    
}