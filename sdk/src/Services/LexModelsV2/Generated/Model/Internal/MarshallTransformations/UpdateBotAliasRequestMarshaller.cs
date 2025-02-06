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
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBotAliasLocaleSettings())
            {
                context.Writer.WritePropertyName("botAliasLocaleSettings");
                context.Writer.WriteStartObject();
                foreach (var publicRequestBotAliasLocaleSettingsKvp in publicRequest.BotAliasLocaleSettings)
                {
                    context.Writer.WritePropertyName(publicRequestBotAliasLocaleSettingsKvp.Key);
                    var publicRequestBotAliasLocaleSettingsValue = publicRequestBotAliasLocaleSettingsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = BotAliasLocaleSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequestBotAliasLocaleSettingsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetBotAliasName())
            {
                context.Writer.WritePropertyName("botAliasName");
                context.Writer.WriteStringValue(publicRequest.BotAliasName);
            }

            if(publicRequest.IsSetBotVersion())
            {
                context.Writer.WritePropertyName("botVersion");
                context.Writer.WriteStringValue(publicRequest.BotVersion);
            }

            if(publicRequest.IsSetConversationLogSettings())
            {
                context.Writer.WritePropertyName("conversationLogSettings");
                context.Writer.WriteStartObject();

                var marshaller = ConversationLogSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.ConversationLogSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetSentimentAnalysisSettings())
            {
                context.Writer.WritePropertyName("sentimentAnalysisSettings");
                context.Writer.WriteStartObject();

                var marshaller = SentimentAnalysisSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.SentimentAnalysisSettings, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


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