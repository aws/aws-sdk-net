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
    /// GetObject Request Marshaller
    /// </summary>       
    public partial class GetObjectRequestMarshaller : IMarshaller<IRequest, GetObjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetObjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetObjectRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "GET";
        
            if (publicRequest.IsSetByteRange()) 
            {
                request.Headers["Range"] = publicRequest.ByteRange.FormattedByteRange;
            }
        
            if (publicRequest.IsSetChecksumMode()) 
            {
                request.Headers["x-amz-checksum-mode"] = publicRequest.ChecksumMode;
            }
        
            if (publicRequest.IsSetEtagToMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.EtagToMatch;
            }
        
            if (publicRequest.IsSetEtagToNotMatch()) 
            {
                request.Headers["If-None-Match"] = publicRequest.EtagToNotMatch;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetModifiedSinceDate()) 
            {
                request.Headers["If-Modified-Since"] = StringUtils.FromDateTimeToRFC822(publicRequest.ModifiedSinceDate);
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
        
            if (publicRequest.IsSetUnmodifiedSinceDate()) 
            {
                request.Headers["If-Unmodified-Since"] = StringUtils.FromDateTimeToRFC822(publicRequest.UnmodifiedSinceDate);
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "GetObjectRequest.BucketName");
            if (string.IsNullOrEmpty(publicRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "GetObjectRequest.Key");
            request.AddPathResource("{Key+}", StringUtils.FromString(publicRequest.Key));
            
            if (publicRequest.IsSetPartNumber())
                request.Parameters.Add("partNumber", StringUtils.FromInt(publicRequest.PartNumber));
            
            if (publicRequest.IsSetVersionId())
                request.Parameters.Add("versionId", StringUtils.FromString(publicRequest.VersionId));
            request.ResourcePath = "/{Key+}";

            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;
            return request;
        }
        private static GetObjectRequestMarshaller _instance = new GetObjectRequestMarshaller();        

        internal static GetObjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetObjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, GetObjectRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, GetObjectRequest publicRequest);
    }    
}