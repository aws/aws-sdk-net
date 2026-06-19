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
    /// PutObjectAnnotation Request Marshaller
    /// </summary>       
    public partial class PutObjectAnnotationRequestMarshaller : IMarshaller<IRequest, PutObjectAnnotationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutObjectAnnotationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutObjectAnnotationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "PUT";
            request.AddSubResource("annotation");
        
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
        
            if (publicRequest.IsSetChecksumMD5()) 
            {
                request.Headers["x-amz-checksum-md5"] = publicRequest.ChecksumMD5;
            }
        
            if (publicRequest.IsSetChecksumSHA1()) 
            {
                request.Headers["x-amz-checksum-sha1"] = publicRequest.ChecksumSHA1;
            }
        
            if (publicRequest.IsSetChecksumSHA256()) 
            {
                request.Headers["x-amz-checksum-sha256"] = publicRequest.ChecksumSHA256;
            }
        
            if (publicRequest.IsSetChecksumSHA512()) 
            {
                request.Headers["x-amz-checksum-sha512"] = publicRequest.ChecksumSHA512;
            }
        
            if (publicRequest.IsSetChecksumXXHASH128()) 
            {
                request.Headers["x-amz-checksum-xxhash128"] = publicRequest.ChecksumXXHASH128;
            }
        
            if (publicRequest.IsSetChecksumXXHASH3()) 
            {
                request.Headers["x-amz-checksum-xxhash3"] = publicRequest.ChecksumXXHASH3;
            }
        
            if (publicRequest.IsSetChecksumXXHASH64()) 
            {
                request.Headers["x-amz-checksum-xxhash64"] = publicRequest.ChecksumXXHASH64;
            }
        
            if (publicRequest.IsSetContentMD5()) 
            {
                request.Headers["Content-MD5"] = publicRequest.ContentMD5;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetObjectIfMatch()) 
            {
                request.Headers["x-amz-object-if-match"] = publicRequest.ObjectIfMatch;
            }
        
            if (publicRequest.IsSetRequestPayer()) 
            {
                request.Headers["x-amz-request-payer"] = publicRequest.RequestPayer;
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutObjectAnnotationRequest.BucketName");
            if (string.IsNullOrEmpty(publicRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "PutObjectAnnotationRequest.Key");
            request.AddPathResource("{Key+}", StringUtils.FromString(publicRequest.Key));
            if (string.IsNullOrEmpty(publicRequest.AnnotationName))
                throw new AmazonS3Exception("Request object does not have required field AnnotationName set");
            
            if (publicRequest.IsSetAnnotationName())
                request.Parameters.Add("annotationName", StringUtils.FromString(publicRequest.AnnotationName));
            
            if (publicRequest.IsSetVersionId())
                request.Parameters.Add("versionId", StringUtils.FromString(publicRequest.VersionId));
            request.ResourcePath = "/{Key+}";
            request.ContentStream = publicRequest.AnnotationPayload;
            request.Headers["Content-Type"] = "application/octet-stream";
            PostMarshallCustomization(request, publicRequest);
                ChecksumUtils.SetChecksumData(
                    request,
                    publicRequest.ChecksumAlgorithm,
                    fallbackToMD5: false,
                    isRequestChecksumRequired: false,
                    headerName: "x-amz-sdk-checksum-algorithm"
                );
            request.UseQueryString = true;
            return request;
        }
        private static PutObjectAnnotationRequestMarshaller _instance = new PutObjectAnnotationRequestMarshaller();        

        internal static PutObjectAnnotationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutObjectAnnotationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutObjectAnnotationRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, PutObjectAnnotationRequest publicRequest);
    }    
}