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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Neptunedata.Model;
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
namespace Amazon.Neptunedata.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetPropertygraphStream Request Marshaller
    /// </summary>       
    public class GetPropertygraphStreamRequestMarshaller : IMarshaller<IRequest, GetPropertygraphStreamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetPropertygraphStreamRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetPropertygraphStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Neptunedata");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-08-01";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetCommitNum())
                request.Parameters.Add("commitNum", StringUtils.FromLong(publicRequest.CommitNum));
            
            if (publicRequest.IsSetIteratorType())
                request.Parameters.Add("iteratorType", StringUtils.FromString(publicRequest.IteratorType));
            
            if (publicRequest.IsSetLimit())
                request.Parameters.Add("limit", StringUtils.FromLong(publicRequest.Limit));
            
            if (publicRequest.IsSetOpNum())
                request.Parameters.Add("opNum", StringUtils.FromLong(publicRequest.OpNum));
            request.ResourcePath = "/propertygraph/stream";
        
            if (publicRequest.IsSetEncoding()) 
            {
                request.Headers["Accept-Encoding"] = publicRequest.Encoding;
            }
            request.UseQueryString = true;

            return request;
        }
        private static GetPropertygraphStreamRequestMarshaller _instance = new GetPropertygraphStreamRequestMarshaller();        

        internal static GetPropertygraphStreamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetPropertygraphStreamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}