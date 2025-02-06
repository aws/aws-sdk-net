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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelBuildingService.Model;
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
namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutSlotType Request Marshaller
    /// </summary>       
    public class PutSlotTypeRequestMarshaller : IMarshaller<IRequest, PutSlotTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutSlotTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutSlotTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelBuildingService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-04-19";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetName())
                throw new AmazonLexModelBuildingServiceException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/slottypes/{name}/versions/$LATEST";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetChecksum())
            {
                context.Writer.WritePropertyName("checksum");
                context.Writer.WriteStringValue(publicRequest.Checksum);
            }

            if(publicRequest.IsSetCreateVersion())
            {
                context.Writer.WritePropertyName("createVersion");
                context.Writer.WriteBooleanValue(publicRequest.CreateVersion.Value);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEnumerationValues())
            {
                context.Writer.WritePropertyName("enumerationValues");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEnumerationValuesListValue in publicRequest.EnumerationValues)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EnumerationValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestEnumerationValuesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetParentSlotTypeSignature())
            {
                context.Writer.WritePropertyName("parentSlotTypeSignature");
                context.Writer.WriteStringValue(publicRequest.ParentSlotTypeSignature);
            }

            if(publicRequest.IsSetSlotTypeConfigurations())
            {
                context.Writer.WritePropertyName("slotTypeConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSlotTypeConfigurationsListValue in publicRequest.SlotTypeConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SlotTypeConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestSlotTypeConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetValueSelectionStrategy())
            {
                context.Writer.WritePropertyName("valueSelectionStrategy");
                context.Writer.WriteStringValue(publicRequest.ValueSelectionStrategy);
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
        private static PutSlotTypeRequestMarshaller _instance = new PutSlotTypeRequestMarshaller();        

        internal static PutSlotTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutSlotTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}