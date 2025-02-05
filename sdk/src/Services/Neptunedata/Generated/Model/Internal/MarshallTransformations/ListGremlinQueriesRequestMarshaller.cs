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
    /// ListGremlinQueries Request Marshaller
    /// </summary>       
    public class ListGremlinQueriesRequestMarshaller : IMarshaller<IRequest, ListGremlinQueriesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListGremlinQueriesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListGremlinQueriesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Neptunedata");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-08-01";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetIncludeWaiting())
                request.Parameters.Add("includeWaiting", StringUtils.FromBool(publicRequest.IncludeWaiting));
            request.ResourcePath = "/gremlin/status";
            request.UseQueryString = true;

            return request;
        }
        private static ListGremlinQueriesRequestMarshaller _instance = new ListGremlinQueriesRequestMarshaller();        

        internal static ListGremlinQueriesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListGremlinQueriesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}