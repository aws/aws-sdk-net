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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeBotAlias operation
    /// </summary>  
    public class DescribeBotAliasResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeBotAliasResponse response = new DescribeBotAliasResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("botAliasHistoryEvents", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BotAliasHistoryEvent, BotAliasHistoryEventUnmarshaller>(BotAliasHistoryEventUnmarshaller.Instance);
                    response.BotAliasHistoryEvents = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("botAliasId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BotAliasId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("botAliasLocaleSettings", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, BotAliasLocaleSettings, StringUnmarshaller, BotAliasLocaleSettingsUnmarshaller>(StringUnmarshaller.Instance, BotAliasLocaleSettingsUnmarshaller.Instance);
                    response.BotAliasLocaleSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("botAliasName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BotAliasName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("botAliasStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BotAliasStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("botId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BotId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("botVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BotVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("conversationLogSettings", targetDepth))
                {
                    var unmarshaller = ConversationLogSettingsUnmarshaller.Instance;
                    response.ConversationLogSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("creationDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdatedDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastUpdatedDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parentBotNetworks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ParentBotNetwork, ParentBotNetworkUnmarshaller>(ParentBotNetworkUnmarshaller.Instance);
                    response.ParentBotNetworks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sentimentAnalysisSettings", targetDepth))
                {
                    var unmarshaller = SentimentAnalysisSettingsUnmarshaller.Instance;
                    response.SentimentAnalysisSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceQuotaExceededException"))
                {
                    return ServiceQuotaExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonLexModelsV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeBotAliasResponseUnmarshaller _instance = new DescribeBotAliasResponseUnmarshaller();        

        internal static DescribeBotAliasResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeBotAliasResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}