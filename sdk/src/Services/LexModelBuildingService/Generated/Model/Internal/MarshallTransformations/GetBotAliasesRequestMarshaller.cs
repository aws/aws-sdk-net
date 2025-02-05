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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelBuildingService.Model;
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
namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetBotAliases Request Marshaller
    /// </summary>       
    public class GetBotAliasesRequestMarshaller : IMarshaller<IRequest, GetBotAliasesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetBotAliasesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetBotAliasesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelBuildingService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-04-19";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetBotName())
                throw new AmazonLexModelBuildingServiceException("Request object does not have required field BotName set");
            request.AddPathResource("{botName}", StringUtils.FromString(publicRequest.BotName));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNameContains())
                request.Parameters.Add("nameContains", StringUtils.FromString(publicRequest.NameContains));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/bots/{botName}/aliases/";
            request.UseQueryString = true;

            return request;
        }
        private static GetBotAliasesRequestMarshaller _instance = new GetBotAliasesRequestMarshaller();        

        internal static GetBotAliasesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetBotAliasesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}