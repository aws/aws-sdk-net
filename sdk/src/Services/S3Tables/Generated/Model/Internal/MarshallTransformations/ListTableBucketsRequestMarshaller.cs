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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Tables.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.S3Tables.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListTableBuckets Request Marshaller
    /// </summary>       
    public class ListTableBucketsRequestMarshaller : IMarshaller<IRequest, ListTableBucketsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListTableBucketsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListTableBucketsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.S3Tables");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetContinuationToken())
                request.Parameters.Add("continuationToken", StringUtils.FromString(publicRequest.ContinuationToken));
            
            if (publicRequest.IsSetMaxBuckets())
                request.Parameters.Add("maxBuckets", StringUtils.FromInt(publicRequest.MaxBuckets));
            
            if (publicRequest.IsSetPrefix())
                request.Parameters.Add("prefix", StringUtils.FromString(publicRequest.Prefix));
            
            if (publicRequest.IsSetType())
                request.Parameters.Add("type", StringUtils.FromString(publicRequest.Type));
            request.ResourcePath = "/buckets";
            request.UseQueryString = true;

            return request;
        }
        private static ListTableBucketsRequestMarshaller _instance = new ListTableBucketsRequestMarshaller();        

        internal static ListTableBucketsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListTableBucketsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}