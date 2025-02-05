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
    /// UpdateSlotType Request Marshaller
    /// </summary>       
    public class UpdateSlotTypeRequestMarshaller : IMarshaller<IRequest, UpdateSlotTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSlotTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSlotTypeRequest publicRequest)
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
            if (!publicRequest.IsSetSlotTypeId())
                throw new AmazonLexModelsV2Exception("Request object does not have required field SlotTypeId set");
            request.AddPathResource("{slotTypeId}", StringUtils.FromString(publicRequest.SlotTypeId));
            request.ResourcePath = "/bots/{botId}/botversions/{botVersion}/botlocales/{localeId}/slottypes/{slotTypeId}/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCompositeSlotTypeSetting())
            {
                context.Writer.WritePropertyName("compositeSlotTypeSetting");
                context.Writer.WriteStartObject();

                var marshaller = CompositeSlotTypeSettingMarshaller.Instance;
                marshaller.Marshall(publicRequest.CompositeSlotTypeSetting, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetExternalSourceSetting())
            {
                context.Writer.WritePropertyName("externalSourceSetting");
                context.Writer.WriteStartObject();

                var marshaller = ExternalSourceSettingMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExternalSourceSetting, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetParentSlotTypeSignature())
            {
                context.Writer.WritePropertyName("parentSlotTypeSignature");
                context.Writer.WriteStringValue(publicRequest.ParentSlotTypeSignature);
            }

            if(publicRequest.IsSetSlotTypeName())
            {
                context.Writer.WritePropertyName("slotTypeName");
                context.Writer.WriteStringValue(publicRequest.SlotTypeName);
            }

            if(publicRequest.IsSetSlotTypeValues())
            {
                context.Writer.WritePropertyName("slotTypeValues");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSlotTypeValuesListValue in publicRequest.SlotTypeValues)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SlotTypeValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestSlotTypeValuesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetValueSelectionSetting())
            {
                context.Writer.WritePropertyName("valueSelectionSetting");
                context.Writer.WriteStartObject();

                var marshaller = SlotValueSelectionSettingMarshaller.Instance;
                marshaller.Marshall(publicRequest.ValueSelectionSetting, context);

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
        private static UpdateSlotTypeRequestMarshaller _instance = new UpdateSlotTypeRequestMarshaller();        

        internal static UpdateSlotTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSlotTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}