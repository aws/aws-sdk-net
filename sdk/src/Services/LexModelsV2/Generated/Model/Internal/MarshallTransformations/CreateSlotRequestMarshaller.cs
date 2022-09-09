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
    /// CreateSlot Request Marshaller
    /// </summary>       
    public class CreateSlotRequestMarshaller : IMarshaller<IRequest, CreateSlotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSlotRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSlotRequest publicRequest)
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
            request.ResourcePath = "/bots/{botId}/botversions/{botVersion}/botlocales/{localeId}/intents/{intentId}/slots/";
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

                if(publicRequest.IsSetMultipleValuesSetting())
                {
                    context.Writer.WritePropertyName("multipleValuesSetting");
                    context.Writer.WriteObjectStart();

                    var marshaller = MultipleValuesSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MultipleValuesSetting, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetObfuscationSetting())
                {
                    context.Writer.WritePropertyName("obfuscationSetting");
                    context.Writer.WriteObjectStart();

                    var marshaller = ObfuscationSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ObfuscationSetting, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSlotName())
                {
                    context.Writer.WritePropertyName("slotName");
                    context.Writer.Write(publicRequest.SlotName);
                }

                if(publicRequest.IsSetSlotTypeId())
                {
                    context.Writer.WritePropertyName("slotTypeId");
                    context.Writer.Write(publicRequest.SlotTypeId);
                }

                if(publicRequest.IsSetSubSlotSetting())
                {
                    context.Writer.WritePropertyName("subSlotSetting");
                    context.Writer.WriteObjectStart();

                    var marshaller = SubSlotSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SubSlotSetting, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetValueElicitationSetting())
                {
                    context.Writer.WritePropertyName("valueElicitationSetting");
                    context.Writer.WriteObjectStart();

                    var marshaller = SlotValueElicitationSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ValueElicitationSetting, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateSlotRequestMarshaller _instance = new CreateSlotRequestMarshaller();        

        internal static CreateSlotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSlotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}