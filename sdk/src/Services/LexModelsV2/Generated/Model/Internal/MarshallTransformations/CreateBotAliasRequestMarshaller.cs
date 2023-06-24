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
    /// CreateBotAlias Request Marshaller
    /// </summary>       
    public class CreateBotAliasRequestMarshaller : IMarshaller<IRequest, CreateBotAliasRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBotAliasRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBotAliasRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelsV2");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-07";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBotId())
                throw new AmazonLexModelsV2Exception("Request object does not have required field BotId set");
            request.AddPathResource("{botId}", StringUtils.FromString(publicRequest.BotId));
            request.ResourcePath = "/bots/{botId}/botaliases/";
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

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateBotAliasRequestMarshaller _instance = new CreateBotAliasRequestMarshaller();        

        internal static CreateBotAliasRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBotAliasRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}