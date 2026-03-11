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
    /// ListMultipartUploads Request Marshaller
    /// </summary>       
    public partial class ListMultipartUploadsRequestMarshaller : IMarshaller<IRequest, ListMultipartUploadsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListMultipartUploadsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListMultipartUploadsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "GET";
            request.AddSubResource("uploads");
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetRequestPayer()) 
            {
                request.Headers["x-amz-request-payer"] = publicRequest.RequestPayer;
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "ListMultipartUploadsRequest.BucketName");
            
            if (publicRequest.IsSetDelimiter())
                request.Parameters.Add("delimiter", StringUtils.FromString(publicRequest.Delimiter));
            
            if (publicRequest.IsSetEncoding())
                request.Parameters.Add("encoding-type", StringUtils.FromString(publicRequest.Encoding));
            
            if (publicRequest.IsSetKeyMarker())
                request.Parameters.Add("key-marker", StringUtils.FromString(publicRequest.KeyMarker));
            
            if (publicRequest.IsSetMaxUploads())
                request.Parameters.Add("max-uploads", StringUtils.FromInt(publicRequest.MaxUploads));
            
            if (publicRequest.IsSetPrefix())
                request.Parameters.Add("prefix", StringUtils.FromString(publicRequest.Prefix));
            
            if (publicRequest.IsSetUploadIdMarker())
                request.Parameters.Add("upload-id-marker", StringUtils.FromString(publicRequest.UploadIdMarker));
            request.ResourcePath = "/";

            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;
            return request;
        }
        private static ListMultipartUploadsRequestMarshaller _instance = new ListMultipartUploadsRequestMarshaller();        

        internal static ListMultipartUploadsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListMultipartUploadsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, ListMultipartUploadsRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, ListMultipartUploadsRequest publicRequest);
    }    
}