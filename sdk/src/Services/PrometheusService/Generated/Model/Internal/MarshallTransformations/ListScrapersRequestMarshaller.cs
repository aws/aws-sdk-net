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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PrometheusService.Model;
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
namespace Amazon.PrometheusService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListScrapers Request Marshaller
    /// </summary>       
    public class ListScrapersRequestMarshaller : IMarshaller<IRequest, ListScrapersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListScrapersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListScrapersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PrometheusService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetFilters())
            {
                foreach(var kvp in publicRequest.Filters)
                {
                    if(request.ParameterCollection.ContainsKey(kvp.Key))
                       continue;
                    else
                       request.ParameterCollection.Add(kvp.Key, kvp.Value);
                }
            }
            if (publicRequest.IsSetMaxResults())
            {
                if(request.Parameters.ContainsKey("maxResults"))
                   request.Parameters.Remove("maxResults");
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            }
            if (publicRequest.IsSetNextToken())
            {
                if(request.Parameters.ContainsKey("nextToken"))
                   request.Parameters.Remove("nextToken");
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }
            request.ResourcePath = "/scrapers";
            request.UseQueryString = true;

            return request;
        }
        private static ListScrapersRequestMarshaller _instance = new ListScrapersRequestMarshaller();        

        internal static ListScrapersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListScrapersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}