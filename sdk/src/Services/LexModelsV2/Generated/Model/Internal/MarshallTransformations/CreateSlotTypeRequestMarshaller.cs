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
    /// CreateSlotType Request Marshaller
    /// </summary>       
    public class CreateSlotTypeRequestMarshaller : IMarshaller<IRequest, CreateSlotTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSlotTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSlotTypeRequest publicRequest)
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
            request.ResourcePath = "/bots/{botId}/botversions/{botVersion}/botlocales/{localeId}/slottypes/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCompositeSlotTypeSetting())
                {
                    context.Writer.WritePropertyName("compositeSlotTypeSetting");
                    context.Writer.WriteObjectStart();

                    var marshaller = CompositeSlotTypeSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CompositeSlotTypeSetting, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetExternalSourceSetting())
                {
                    context.Writer.WritePropertyName("externalSourceSetting");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExternalSourceSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExternalSourceSetting, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetParentSlotTypeSignature())
                {
                    context.Writer.WritePropertyName("parentSlotTypeSignature");
                    context.Writer.Write(publicRequest.ParentSlotTypeSignature);
                }

                if(publicRequest.IsSetSlotTypeName())
                {
                    context.Writer.WritePropertyName("slotTypeName");
                    context.Writer.Write(publicRequest.SlotTypeName);
                }

                if(publicRequest.IsSetSlotTypeValues())
                {
                    context.Writer.WritePropertyName("slotTypeValues");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSlotTypeValuesListValue in publicRequest.SlotTypeValues)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SlotTypeValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestSlotTypeValuesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetValueSelectionSetting())
                {
                    context.Writer.WritePropertyName("valueSelectionSetting");
                    context.Writer.WriteObjectStart();

                    var marshaller = SlotValueSelectionSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ValueSelectionSetting, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateSlotTypeRequestMarshaller _instance = new CreateSlotTypeRequestMarshaller();        

        internal static CreateSlotTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSlotTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}