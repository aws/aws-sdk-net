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
    /// GetBucketIntelligentTieringConfiguration Request Marshaller
    /// </summary>       
    public partial class GetBucketIntelligentTieringConfigurationRequestMarshaller : IMarshaller<IRequest, GetBucketIntelligentTieringConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetBucketIntelligentTieringConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetBucketIntelligentTieringConfigurationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "GET";
            request.AddSubResource("intelligent-tiering");
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "GetBucketIntelligentTieringConfigurationRequest.BucketName");
            if (string.IsNullOrEmpty(publicRequest.IntelligentTieringId))
                throw new System.ArgumentException("IntelligentTieringId is a required property and must be set before making this call.", "GetBucketIntelligentTieringConfigurationRequest.IntelligentTieringId");
            if (publicRequest.IsSetIntelligentTieringId())
                request.AddSubResource("id", StringUtils.FromString(publicRequest.IntelligentTieringId));
            request.ResourcePath = "/";

            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;
            return request;
        }
        private static GetBucketIntelligentTieringConfigurationRequestMarshaller _instance = new GetBucketIntelligentTieringConfigurationRequestMarshaller();        

        internal static GetBucketIntelligentTieringConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetBucketIntelligentTieringConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, GetBucketIntelligentTieringConfigurationRequest publicRequest);
    }    
}