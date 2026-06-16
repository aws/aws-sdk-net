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
    /// GetObjectAnnotation Request Marshaller
    /// </summary>       
    public partial class GetObjectAnnotationRequestMarshaller : IMarshaller<IRequest, GetObjectAnnotationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetObjectAnnotationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetObjectAnnotationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "GET";
            request.AddSubResource("annotation");
        
            if (publicRequest.IsSetChecksumMode()) 
            {
                request.Headers["x-amz-checksum-mode"] = publicRequest.ChecksumMode;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetRequestPayer()) 
            {
                request.Headers["x-amz-request-payer"] = publicRequest.RequestPayer;
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "GetObjectAnnotationRequest.BucketName");
            if (string.IsNullOrEmpty(publicRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "GetObjectAnnotationRequest.Key");
            request.AddPathResource("{Key+}", StringUtils.FromString(publicRequest.Key));
            if (string.IsNullOrEmpty(publicRequest.AnnotationName))
                throw new AmazonS3Exception("Request object does not have required field AnnotationName set");
            
            if (publicRequest.IsSetAnnotationName())
                request.Parameters.Add("annotationName", StringUtils.FromString(publicRequest.AnnotationName));
            
            if (publicRequest.IsSetVersionId())
                request.Parameters.Add("versionId", StringUtils.FromString(publicRequest.VersionId));
            request.ResourcePath = "/{Key+}";

            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;
            return request;
        }
        private static GetObjectAnnotationRequestMarshaller _instance = new GetObjectAnnotationRequestMarshaller();        

        internal static GetObjectAnnotationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetObjectAnnotationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, GetObjectAnnotationRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, GetObjectAnnotationRequest publicRequest);
    }    
}