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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53GlobalResolver.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53GlobalResolver.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAccessTokens Request Marshaller
    /// </summary>       
    public class ListAccessTokensRequestMarshaller : IMarshaller<IRequest, ListAccessTokensRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAccessTokensRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListAccessTokensRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53GlobalResolver");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-09-27";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDnsViewId())
                throw new AmazonRoute53GlobalResolverException("Request object does not have required field DnsViewId set");
            request.AddPathResource("{dnsViewId}", StringUtils.FromString(publicRequest.DnsViewId));
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
                if(request.Parameters.ContainsKey("max_results"))
                   request.Parameters.Remove("max_results");
                request.Parameters.Add("max_results", StringUtils.FromInt(publicRequest.MaxResults));
            }
            if (publicRequest.IsSetNextToken())
            {
                if(request.Parameters.ContainsKey("next_token"))
                   request.Parameters.Remove("next_token");
                request.Parameters.Add("next_token", StringUtils.FromString(publicRequest.NextToken));
            }
            request.ResourcePath = "/tokens/dns-view/{dnsViewId}";
            request.UseQueryString = true;

            return request;
        }
        private static ListAccessTokensRequestMarshaller _instance = new ListAccessTokensRequestMarshaller();        

        internal static ListAccessTokensRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListAccessTokensRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}