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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonProtocol.Model;
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
namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueryIdempotencyTokenAutoFill Request Marshaller
    /// </summary>       
    public class QueryIdempotencyTokenAutoFillRequestMarshaller : IMarshaller<IRequest, QueryIdempotencyTokenAutoFillRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((QueryIdempotencyTokenAutoFillRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(QueryIdempotencyTokenAutoFillRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetToken())
                request.Parameters.Add("token", StringUtils.FromString(publicRequest.Token));
            else            
                request.Parameters.Add("token", System.Guid.NewGuid().ToString());
                
            request.ResourcePath = "/QueryIdempotencyTokenAutoFill";
            request.UseQueryString = true;

            return request;
        }
        private static QueryIdempotencyTokenAutoFillRequestMarshaller _instance = new QueryIdempotencyTokenAutoFillRequestMarshaller();        

        internal static QueryIdempotencyTokenAutoFillRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QueryIdempotencyTokenAutoFillRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}