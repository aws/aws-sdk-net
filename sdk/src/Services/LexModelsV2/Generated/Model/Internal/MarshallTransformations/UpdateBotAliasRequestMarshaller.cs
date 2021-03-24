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
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateBotAlias Request Marshaller
    /// </summary>       
    public class UpdateBotAliasRequestMarshaller : IMarshaller<IRequest, UpdateBotAliasRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBotAliasRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateBotAliasRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelsV2");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-07";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBotAliasId())
                throw new AmazonLexModelsV2Exception("Request object does not have required field BotAliasId set");
            request.AddPathResource("{botAliasId}", StringUtils.FromString(publicRequest.BotAliasId));
            if (!publicRequest.IsSetBotId())
                throw new AmazonLexModelsV2Exception("Request object does not have required field BotId set");
            request.AddPathResource("{botId}", StringUtils.FromString(publicRequest.BotId));
            request.ResourcePath = "/bots/{botId}/botaliases/{botAliasId}/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBotAliasLocaleSettings())
                {
                    context.Writer.WritePropertyName("botAliasLocaleSettings");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestBotAliasLocaleSettingsKvp in publicRequest.BotAliasLocaleSettings)
                    {
                        context.Writer.WritePropertyName(publicRequestBotAliasLocaleSettingsKvp.Key);
                        var publicRequestBotAliasLocaleSettingsValue = publicRequestBotAliasLocaleSettingsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = BotAliasLocaleSettingsMarshaller.Instance;
                        marshaller.Marshall(publicRequestBotAliasLocaleSettingsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetBotAliasName())
                {
                    context.Writer.WritePropertyName("botAliasName");
                    context.Writer.Write(publicRequest.BotAliasName);
                }

                if(publicRequest.IsSetBotVersion())
                {
                    context.Writer.WritePropertyName("botVersion");
                    context.Writer.Write(publicRequest.BotVersion);
                }

                if(publicRequest.IsSetConversationLogSettings())
                {
                    context.Writer.WritePropertyName("conversationLogSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConversationLogSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ConversationLogSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetSentimentAnalysisSettings())
                {
                    context.Writer.WritePropertyName("sentimentAnalysisSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = SentimentAnalysisSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SentimentAnalysisSettings, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateBotAliasRequestMarshaller _instance = new UpdateBotAliasRequestMarshaller();        

        internal static UpdateBotAliasRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateBotAliasRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}