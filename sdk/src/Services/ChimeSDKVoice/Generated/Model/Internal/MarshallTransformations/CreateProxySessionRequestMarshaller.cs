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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKVoice.Model;
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
namespace Amazon.ChimeSDKVoice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateProxySession Request Marshaller
    /// </summary>       
    public class CreateProxySessionRequestMarshaller : IMarshaller<IRequest, CreateProxySessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProxySessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateProxySessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKVoice");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-08-03";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetVoiceConnectorId())
                throw new AmazonChimeSDKVoiceException("Request object does not have required field VoiceConnectorId set");
            request.AddPathResource("{voiceConnectorId}", StringUtils.FromString(publicRequest.VoiceConnectorId));
            request.ResourcePath = "/voice-connectors/{voiceConnectorId}/proxy-sessions";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCapabilities())
            {
                context.Writer.WritePropertyName("Capabilities");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCapabilitiesListValue in publicRequest.Capabilities)
                {
                        context.Writer.WriteStringValue(publicRequestCapabilitiesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetExpiryMinutes())
            {
                context.Writer.WritePropertyName("ExpiryMinutes");
                context.Writer.WriteNumberValue(publicRequest.ExpiryMinutes.Value);
            }

            if(publicRequest.IsSetGeoMatchLevel())
            {
                context.Writer.WritePropertyName("GeoMatchLevel");
                context.Writer.WriteStringValue(publicRequest.GeoMatchLevel);
            }

            if(publicRequest.IsSetGeoMatchParams())
            {
                context.Writer.WritePropertyName("GeoMatchParams");
                context.Writer.WriteStartObject();

                var marshaller = GeoMatchParamsMarshaller.Instance;
                marshaller.Marshall(publicRequest.GeoMatchParams, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNumberSelectionBehavior())
            {
                context.Writer.WritePropertyName("NumberSelectionBehavior");
                context.Writer.WriteStringValue(publicRequest.NumberSelectionBehavior);
            }

            if(publicRequest.IsSetParticipantPhoneNumbers())
            {
                context.Writer.WritePropertyName("ParticipantPhoneNumbers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestParticipantPhoneNumbersListValue in publicRequest.ParticipantPhoneNumbers)
                {
                        context.Writer.WriteStringValue(publicRequestParticipantPhoneNumbersListValue);
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
        private static CreateProxySessionRequestMarshaller _instance = new CreateProxySessionRequestMarshaller();        

        internal static CreateProxySessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateProxySessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}