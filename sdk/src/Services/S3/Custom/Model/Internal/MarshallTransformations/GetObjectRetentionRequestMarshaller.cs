/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.S3.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetObjectRetention Request Marshaller
    /// </summary>       
    public class GetObjectRetentionRequestMarshaller : IMarshaller<IRequest, GetObjectRetentionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetObjectRetentionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetObjectRetentionRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "AmazonS3");
            request.HttpMethod = "GET";
            string uriResourcePath = "/{Bucket}/{Key+}";
            request.AddSubResource("retention");
        
            if(publicRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(publicRequest.RequestPayer.ToString()));
            if (!publicRequest.IsSetBucketName())
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "publicRequest.BucketName");
            uriResourcePath = uriResourcePath.Replace("{Bucket}", StringUtils.FromString(publicRequest.BucketName));
            if (!publicRequest.IsSetKey())
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "publicRequest.Key");
            uriResourcePath = uriResourcePath.Replace("{Key+}", StringUtils.FromString(publicRequest.Key));
            
            if (publicRequest.IsSetVersionId())
                request.Parameters.Add("versionId", StringUtils.FromString(publicRequest.VersionId));
			request.MarshallerVersion = 2;
			request.ResourcePath = uriResourcePath;


            request.UseQueryString = true;
            return request;
        }
        
        private static GetObjectRetentionRequestMarshaller _instance;
        
        public static GetObjectRetentionRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetObjectRetentionRequestMarshaller();
                }
                return _instance;
            }
        }

    }    
}