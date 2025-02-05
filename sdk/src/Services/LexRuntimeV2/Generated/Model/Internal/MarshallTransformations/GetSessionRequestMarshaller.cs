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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexRuntimeV2.Model;
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
namespace Amazon.LexRuntimeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSession Request Marshaller
    /// </summary>       
    public class GetSessionRequestMarshaller : IMarshaller<IRequest, GetSessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetSessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexRuntimeV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-07";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetBotAliasId())
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field BotAliasId set");
            request.AddPathResource("{botAliasId}", StringUtils.FromString(publicRequest.BotAliasId));
            if (!publicRequest.IsSetBotId())
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field BotId set");
            request.AddPathResource("{botId}", StringUtils.FromString(publicRequest.BotId));
            if (!publicRequest.IsSetLocaleId())
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field LocaleId set");
            request.AddPathResource("{localeId}", StringUtils.FromString(publicRequest.LocaleId));
            if (!publicRequest.IsSetSessionId())
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field SessionId set");
            request.AddPathResource("{sessionId}", StringUtils.FromString(publicRequest.SessionId));
            request.ResourcePath = "/bots/{botId}/botAliases/{botAliasId}/botLocales/{localeId}/sessions/{sessionId}";

            return request;
        }
        private static GetSessionRequestMarshaller _instance = new GetSessionRequestMarshaller();        

        internal static GetSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}