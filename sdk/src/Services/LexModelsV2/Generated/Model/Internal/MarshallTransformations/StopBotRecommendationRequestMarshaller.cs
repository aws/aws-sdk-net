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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
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
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StopBotRecommendation Request Marshaller
    /// </summary>       
    public class StopBotRecommendationRequestMarshaller : IMarshaller<IRequest, StopBotRecommendationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StopBotRecommendationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StopBotRecommendationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelsV2");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-07";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBotId())
                throw new AmazonLexModelsV2Exception("Request object does not have required field BotId set");
            request.AddPathResource("{botId}", StringUtils.FromString(publicRequest.BotId));
            if (!publicRequest.IsSetBotRecommendationId())
                throw new AmazonLexModelsV2Exception("Request object does not have required field BotRecommendationId set");
            request.AddPathResource("{botRecommendationId}", StringUtils.FromString(publicRequest.BotRecommendationId));
            if (!publicRequest.IsSetBotVersion())
                throw new AmazonLexModelsV2Exception("Request object does not have required field BotVersion set");
            request.AddPathResource("{botVersion}", StringUtils.FromString(publicRequest.BotVersion));
            if (!publicRequest.IsSetLocaleId())
                throw new AmazonLexModelsV2Exception("Request object does not have required field LocaleId set");
            request.AddPathResource("{localeId}", StringUtils.FromString(publicRequest.LocaleId));
            request.ResourcePath = "/bots/{botId}/botversions/{botVersion}/botlocales/{localeId}/botrecommendations/{botRecommendationId}/stopbotrecommendation";

            return request;
        }
        private static StopBotRecommendationRequestMarshaller _instance = new StopBotRecommendationRequestMarshaller();        

        internal static StopBotRecommendationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StopBotRecommendationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}