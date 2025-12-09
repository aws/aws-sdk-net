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
    /// DeleteObject Request Marshaller
    /// </summary>       
    public partial class DeleteObjectRequestMarshaller : IMarshaller<IRequest, DeleteObjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteObjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteObjectRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "DELETE";
        
            if (publicRequest.IsSetBypassGovernanceRetention()) 
            {
                request.Headers["x-amz-bypass-governance-retention"] = StringUtils.FromBool(publicRequest.BypassGovernanceRetention);
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }
        
            if (publicRequest.IsSetIfMatchLastModifiedTime()) 
            {
                request.Headers["x-amz-if-match-last-modified-time"] = StringUtils.FromDateTimeToRFC822(publicRequest.IfMatchLastModifiedTime);
            }
        
            if (publicRequest.IsSetIfMatchSize()) 
            {
                request.Headers["x-amz-if-match-size"] = StringUtils.FromLong(publicRequest.IfMatchSize);
            }
                MfaCodesCustomMarshall(request, publicRequest);
        
            if (publicRequest.IsSetRequestPayer()) 
            {
                request.Headers["x-amz-request-payer"] = publicRequest.RequestPayer;
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "DeleteObjectRequest.BucketName");
            if (string.IsNullOrEmpty(publicRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "DeleteObjectRequest.Key");
            request.AddPathResource("{Key+}", StringUtils.FromString(publicRequest.Key));
            
            if (publicRequest.IsSetVersionId())
                request.Parameters.Add("versionId", StringUtils.FromString(publicRequest.VersionId));
            request.ResourcePath = "/{Key+}";

            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;
            return request;
        }
        private static DeleteObjectRequestMarshaller _instance = new DeleteObjectRequestMarshaller();        

        internal static DeleteObjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteObjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, DeleteObjectRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, DeleteObjectRequest publicRequest);
    }    
}