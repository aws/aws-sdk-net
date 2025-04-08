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
    /// UpdateIntent Request Marshaller
    /// </summary>       
    public class UpdateIntentRequestMarshaller : IMarshaller<IRequest, UpdateIntentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateIntentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateIntentRequest publicRequest)
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
            if (!publicRequest.IsSetIntentId())
                throw new AmazonLexModelsV2Exception("Request object does not have required field IntentId set");
            request.AddPathResource("{intentId}", StringUtils.FromString(publicRequest.IntentId));
            if (!publicRequest.IsSetLocaleId())
                throw new AmazonLexModelsV2Exception("Request object does not have required field LocaleId set");
            request.AddPathResource("{localeId}", StringUtils.FromString(publicRequest.LocaleId));
            request.ResourcePath = "/bots/{botId}/botversions/{botVersion}/botlocales/{localeId}/intents/{intentId}/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDialogCodeHook())
            {
                context.Writer.WritePropertyName("dialogCodeHook");
                context.Writer.WriteStartObject();

                var marshaller = DialogCodeHookSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.DialogCodeHook, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFulfillmentCodeHook())
            {
                context.Writer.WritePropertyName("fulfillmentCodeHook");
                context.Writer.WriteStartObject();

                var marshaller = FulfillmentCodeHookSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.FulfillmentCodeHook, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInitialResponseSetting())
            {
                context.Writer.WritePropertyName("initialResponseSetting");
                context.Writer.WriteStartObject();

                var marshaller = InitialResponseSettingMarshaller.Instance;
                marshaller.Marshall(publicRequest.InitialResponseSetting, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputContexts())
            {
                context.Writer.WritePropertyName("inputContexts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInputContextsListValue in publicRequest.InputContexts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputContextMarshaller.Instance;
                    marshaller.Marshall(publicRequestInputContextsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetIntentClosingSetting())
            {
                context.Writer.WritePropertyName("intentClosingSetting");
                context.Writer.WriteStartObject();

                var marshaller = IntentClosingSettingMarshaller.Instance;
                marshaller.Marshall(publicRequest.IntentClosingSetting, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIntentConfirmationSetting())
            {
                context.Writer.WritePropertyName("intentConfirmationSetting");
                context.Writer.WriteStartObject();

                var marshaller = IntentConfirmationSettingMarshaller.Instance;
                marshaller.Marshall(publicRequest.IntentConfirmationSetting, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIntentName())
            {
                context.Writer.WritePropertyName("intentName");
                context.Writer.WriteStringValue(publicRequest.IntentName);
            }

            if(publicRequest.IsSetKendraConfiguration())
            {
                context.Writer.WritePropertyName("kendraConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = KendraConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.KendraConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutputContexts())
            {
                context.Writer.WritePropertyName("outputContexts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOutputContextsListValue in publicRequest.OutputContexts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = OutputContextMarshaller.Instance;
                    marshaller.Marshall(publicRequestOutputContextsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetParentIntentSignature())
            {
                context.Writer.WritePropertyName("parentIntentSignature");
                context.Writer.WriteStringValue(publicRequest.ParentIntentSignature);
            }

            if(publicRequest.IsSetQInConnectIntentConfiguration())
            {
                context.Writer.WritePropertyName("qInConnectIntentConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = QInConnectIntentConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.QInConnectIntentConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetQnAIntentConfiguration())
            {
                context.Writer.WritePropertyName("qnAIntentConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = QnAIntentConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.QnAIntentConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSampleUtterances())
            {
                context.Writer.WritePropertyName("sampleUtterances");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSampleUtterancesListValue in publicRequest.SampleUtterances)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SampleUtteranceMarshaller.Instance;
                    marshaller.Marshall(publicRequestSampleUtterancesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSlotPriorities())
            {
                context.Writer.WritePropertyName("slotPriorities");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSlotPrioritiesListValue in publicRequest.SlotPriorities)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SlotPriorityMarshaller.Instance;
                    marshaller.Marshall(publicRequestSlotPrioritiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
        private static UpdateIntentRequestMarshaller _instance = new UpdateIntentRequestMarshaller();        

        internal static UpdateIntentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateIntentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}