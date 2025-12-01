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

#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBotLocale Request Marshaller
    /// </summary>       
    public class CreateBotLocaleRequestMarshaller : IMarshaller<IRequest, CreateBotLocaleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBotLocaleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBotLocaleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelsV2");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-07";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBotId())
                throw new AmazonLexModelsV2Exception("Request object does not have required field BotId set");
            request.AddPathResource("{botId}", StringUtils.FromString(publicRequest.BotId));
            if (!publicRequest.IsSetBotVersion())
                throw new AmazonLexModelsV2Exception("Request object does not have required field BotVersion set");
            request.AddPathResource("{botVersion}", StringUtils.FromString(publicRequest.BotVersion));
            request.ResourcePath = "/bots/{botId}/botversions/{botVersion}/botlocales/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetGenerativeAISettings())
                {
                    context.Writer.WritePropertyName("generativeAISettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = GenerativeAISettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GenerativeAISettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLocaleId())
                {
                    context.Writer.WritePropertyName("localeId");
                    context.Writer.Write(publicRequest.LocaleId);
                }

                if(publicRequest.IsSetNluIntentConfidenceThreshold())
                {
                    context.Writer.WritePropertyName("nluIntentConfidenceThreshold");
                    if(StringUtils.IsSpecialDoubleValue(publicRequest.NluIntentConfidenceThreshold))
                    {
                        context.Writer.Write(StringUtils.FromSpecialDoubleValue(publicRequest.NluIntentConfidenceThreshold));
                    }
                    else
                    {
                        context.Writer.Write(publicRequest.NluIntentConfidenceThreshold);
                    }
                }

                if(publicRequest.IsSetSpeechDetectionSensitivity())
                {
                    context.Writer.WritePropertyName("speechDetectionSensitivity");
                    context.Writer.Write(publicRequest.SpeechDetectionSensitivity);
                }

                if(publicRequest.IsSetSpeechRecognitionSettings())
                {
                    context.Writer.WritePropertyName("speechRecognitionSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = SpeechRecognitionSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SpeechRecognitionSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUnifiedSpeechSettings())
                {
                    context.Writer.WritePropertyName("unifiedSpeechSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = UnifiedSpeechSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.UnifiedSpeechSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVoiceSettings())
                {
                    context.Writer.WritePropertyName("voiceSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = VoiceSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VoiceSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateBotLocaleRequestMarshaller _instance = new CreateBotLocaleRequestMarshaller();        

        internal static CreateBotLocaleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBotLocaleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}