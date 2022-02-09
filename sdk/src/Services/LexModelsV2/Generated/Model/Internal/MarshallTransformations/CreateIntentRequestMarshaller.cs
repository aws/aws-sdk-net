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
    /// CreateIntent Request Marshaller
    /// </summary>       
    public class CreateIntentRequestMarshaller : IMarshaller<IRequest, CreateIntentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIntentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateIntentRequest publicRequest)
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
            if (!publicRequest.IsSetLocaleId())
                throw new AmazonLexModelsV2Exception("Request object does not have required field LocaleId set");
            request.AddPathResource("{localeId}", StringUtils.FromString(publicRequest.LocaleId));
            request.ResourcePath = "/bots/{botId}/botversions/{botVersion}/botlocales/{localeId}/intents/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDialogCodeHook())
                {
                    context.Writer.WritePropertyName("dialogCodeHook");
                    context.Writer.WriteObjectStart();

                    var marshaller = DialogCodeHookSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DialogCodeHook, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFulfillmentCodeHook())
                {
                    context.Writer.WritePropertyName("fulfillmentCodeHook");
                    context.Writer.WriteObjectStart();

                    var marshaller = FulfillmentCodeHookSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FulfillmentCodeHook, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInputContexts())
                {
                    context.Writer.WritePropertyName("inputContexts");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInputContextsListValue in publicRequest.InputContexts)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = InputContextMarshaller.Instance;
                        marshaller.Marshall(publicRequestInputContextsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIntentClosingSetting())
                {
                    context.Writer.WritePropertyName("intentClosingSetting");
                    context.Writer.WriteObjectStart();

                    var marshaller = IntentClosingSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.IntentClosingSetting, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIntentConfirmationSetting())
                {
                    context.Writer.WritePropertyName("intentConfirmationSetting");
                    context.Writer.WriteObjectStart();

                    var marshaller = IntentConfirmationSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.IntentConfirmationSetting, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIntentName())
                {
                    context.Writer.WritePropertyName("intentName");
                    context.Writer.Write(publicRequest.IntentName);
                }

                if(publicRequest.IsSetKendraConfiguration())
                {
                    context.Writer.WritePropertyName("kendraConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = KendraConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.KendraConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputContexts())
                {
                    context.Writer.WritePropertyName("outputContexts");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOutputContextsListValue in publicRequest.OutputContexts)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = OutputContextMarshaller.Instance;
                        marshaller.Marshall(publicRequestOutputContextsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetParentIntentSignature())
                {
                    context.Writer.WritePropertyName("parentIntentSignature");
                    context.Writer.Write(publicRequest.ParentIntentSignature);
                }

                if(publicRequest.IsSetSampleUtterances())
                {
                    context.Writer.WritePropertyName("sampleUtterances");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSampleUtterancesListValue in publicRequest.SampleUtterances)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SampleUtteranceMarshaller.Instance;
                        marshaller.Marshall(publicRequestSampleUtterancesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateIntentRequestMarshaller _instance = new CreateIntentRequestMarshaller();        

        internal static CreateIntentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIntentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}