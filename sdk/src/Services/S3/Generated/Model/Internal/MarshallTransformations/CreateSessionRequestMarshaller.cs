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
    /// CreateSession Request Marshaller
    /// </summary>       
    public partial class CreateSessionRequestMarshaller : IMarshaller<IRequest, CreateSessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSessionRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "GET";
            request.AddSubResource("session");
        
            if (publicRequest.IsSetBucketKeyEnabled()) 
            {
                request.Headers["x-amz-server-side-encryption-bucket-key-enabled"] = StringUtils.FromBool(publicRequest.BucketKeyEnabled);
            }
        
            if (publicRequest.IsSetServerSideEncryption()) 
            {
                request.Headers["x-amz-server-side-encryption"] = publicRequest.ServerSideEncryption;
            }
        
            if (publicRequest.IsSetSessionMode()) 
            {
                request.Headers["x-amz-create-session-mode"] = publicRequest.SessionMode;
            }
        
            if (publicRequest.IsSetSSEKMSEncryptionContext()) 
            {
                request.Headers["x-amz-server-side-encryption-context"] = publicRequest.SSEKMSEncryptionContext;
            }
        
            if (publicRequest.IsSetSSEKMSKeyId()) 
            {
                request.Headers["x-amz-server-side-encryption-aws-kms-key-id"] = publicRequest.SSEKMSKeyId;
            }
            if (!publicRequest.IsSetBucketName())
                throw new AmazonS3Exception("Request object does not have required field BucketName set");
            request.ResourcePath = "/";

            PostMarshallCustomization(request, publicRequest);
            return request;
        }
        private static CreateSessionRequestMarshaller _instance = new CreateSessionRequestMarshaller();        

        internal static CreateSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateSessionRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, CreateSessionRequest publicRequest);
    }    
}