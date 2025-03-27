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
    public class GetObjectRequestMarshaller : IMarshaller<IRequest, GetObjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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
            request.HttpMethod = "GET";
        
            if (publicRequest.IsSetChecksumMode()) 
            {
                request.Headers["x-amz-checksum-mode"] = publicRequest.ChecksumMode;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }
        
            if (publicRequest.IsSetIfModifiedSince()) 
            {
                request.Headers["If-Modified-Since"] = StringUtils.FromDateTimeToRFC822(publicRequest.IfModifiedSince);
            }
        
            if (publicRequest.IsSetIfNoneMatch()) 
            {
                request.Headers["If-None-Match"] = publicRequest.IfNoneMatch;
            }
        
            if (publicRequest.IsSetIfUnmodifiedSince()) 
            {
                request.Headers["If-Unmodified-Since"] = StringUtils.FromDateTimeToRFC822(publicRequest.IfUnmodifiedSince);
            }
        
            if (publicRequest.IsSetRange()) 
            {
                request.Headers["Range"] = publicRequest.Range;
            }
        
            if (publicRequest.IsSetRequestPayer()) 
            {
                request.Headers["x-amz-request-payer"] = publicRequest.RequestPayer;
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
            if (!publicRequest.IsSetBucketName())
                throw new AmazonS3Exception("Request object does not have required field BucketName set");
            request.AddPathResource("{Bucket}", StringUtils.FromString(publicRequest.BucketName));
            if (!publicRequest.IsSetKey())
                throw new AmazonS3Exception("Request object does not have required field Key set");
            request.AddPathResource("{Key+}", StringUtils.FromString(publicRequest.Key.TrimStart('/')));
            
            if (publicRequest.IsSetPartNumber())
                request.Parameters.Add("partNumber", StringUtils.FromInt(publicRequest.PartNumber));
            
            if (publicRequest.IsSetResponseCacheControl())
                request.Parameters.Add("response-cache-control", StringUtils.FromString(publicRequest.ResponseCacheControl));
            
            if (publicRequest.IsSetResponseContentDisposition())
                request.Parameters.Add("response-content-disposition", StringUtils.FromString(publicRequest.ResponseContentDisposition));
            
            if (publicRequest.IsSetResponseContentEncoding())
                request.Parameters.Add("response-content-encoding", StringUtils.FromString(publicRequest.ResponseContentEncoding));
            
            if (publicRequest.IsSetResponseContentLanguage())
                request.Parameters.Add("response-content-language", StringUtils.FromString(publicRequest.ResponseContentLanguage));
            
            if (publicRequest.IsSetResponseContentType())
                request.Parameters.Add("response-content-type", StringUtils.FromString(publicRequest.ResponseContentType));
            
            if (publicRequest.IsSetResponseExpires())
                request.Parameters.Add("response-expires", StringUtils.FromDateTimeToRFC822(publicRequest.ResponseExpires));
            
            if (publicRequest.IsSetVersionId())
                request.Parameters.Add("versionId", StringUtils.FromString(publicRequest.VersionId));
            request.ResourcePath = "/{Bucket}/{Key+}";


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

    }    
}