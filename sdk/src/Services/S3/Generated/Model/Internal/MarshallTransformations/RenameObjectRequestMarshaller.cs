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
    /// RenameObject Request Marshaller
    /// </summary>       
    public partial class RenameObjectRequestMarshaller : IMarshaller<IRequest, RenameObjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RenameObjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RenameObjectRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "PUT";
            request.AddSubResource("renameObject");
        
            if (publicRequest.IsSetClientToken()) 
            {
                request.Headers["x-amz-client-token"] = publicRequest.ClientToken;
            }
        
            if (publicRequest.IsSetDestinationIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.DestinationIfMatch;
            }
        
            if (publicRequest.IsSetDestinationIfModifiedSince()) 
            {
                request.Headers["If-Modified-Since"] = StringUtils.FromDateTimeToRFC822(publicRequest.DestinationIfModifiedSince);
            }
        
            if (publicRequest.IsSetDestinationIfNoneMatch()) 
            {
                request.Headers["If-None-Match"] = publicRequest.DestinationIfNoneMatch;
            }
        
            if (publicRequest.IsSetDestinationIfUnmodifiedSince()) 
            {
                request.Headers["If-Unmodified-Since"] = StringUtils.FromDateTimeToRFC822(publicRequest.DestinationIfUnmodifiedSince);
            }
        
            if (publicRequest.IsSetRenameSource()) 
            {
                request.Headers["x-amz-rename-source"] = publicRequest.RenameSource;
            }
        
            if (publicRequest.IsSetSourceIfMatch()) 
            {
                request.Headers["x-amz-rename-source-if-match"] = publicRequest.SourceIfMatch;
            }
        
            if (publicRequest.IsSetSourceIfModifiedSince()) 
            {
                request.Headers["x-amz-rename-source-if-modified-since"] = StringUtils.FromDateTimeToRFC822(publicRequest.SourceIfModifiedSince);
            }
        
            if (publicRequest.IsSetSourceIfNoneMatch()) 
            {
                request.Headers["x-amz-rename-source-if-none-match"] = publicRequest.SourceIfNoneMatch;
            }
        
            if (publicRequest.IsSetSourceIfUnmodifiedSince()) 
            {
                request.Headers["x-amz-rename-source-if-unmodified-since"] = StringUtils.FromDateTimeToRFC822(publicRequest.SourceIfUnmodifiedSince);
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "RenameObjectRequest.BucketName");
            if (string.IsNullOrEmpty(publicRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "RenameObjectRequest.Key");
            request.AddPathResource("{Key+}", StringUtils.FromString(publicRequest.Key));
            request.ResourcePath = "/{Key+}";

            PostMarshallCustomization(request, publicRequest);
            return request;
        }
        private static RenameObjectRequestMarshaller _instance = new RenameObjectRequestMarshaller();        

        internal static RenameObjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RenameObjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, RenameObjectRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, RenameObjectRequest publicRequest);
    }    
}