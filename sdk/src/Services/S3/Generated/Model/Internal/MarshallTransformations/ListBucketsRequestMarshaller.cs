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
    /// ListBuckets Request Marshaller
    /// </summary>       
    public partial class ListBucketsRequestMarshaller : IMarshaller<IRequest, ListBucketsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListBucketsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListBucketsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "GET";
            
            if (publicRequest.IsSetBucketRegion())
                request.Parameters.Add("bucket-region", StringUtils.FromString(publicRequest.BucketRegion));
            
            if (publicRequest.IsSetContinuationToken())
                request.Parameters.Add("continuation-token", StringUtils.FromString(publicRequest.ContinuationToken));
            
            if (publicRequest.IsSetMaxBuckets())
                request.Parameters.Add("max-buckets", StringUtils.FromInt(publicRequest.MaxBuckets));
            
            if (publicRequest.IsSetPrefix())
                request.Parameters.Add("prefix", StringUtils.FromString(publicRequest.Prefix));
            request.ResourcePath = "/";

            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;
            return request;
        }
        private static ListBucketsRequestMarshaller _instance = new ListBucketsRequestMarshaller();        

        internal static ListBucketsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListBucketsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, ListBucketsRequest publicRequest);
    }    
}