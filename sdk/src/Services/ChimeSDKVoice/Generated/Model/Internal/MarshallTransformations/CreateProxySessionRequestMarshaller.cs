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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCapabilities())
                {
                    context.Writer.WritePropertyName("Capabilities");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCapabilitiesListValue in publicRequest.Capabilities)
                    {
                            context.Writer.Write(publicRequestCapabilitiesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetExpiryMinutes())
                {
                    context.Writer.WritePropertyName("ExpiryMinutes");
                    context.Writer.Write(publicRequest.ExpiryMinutes);
                }

                if(publicRequest.IsSetGeoMatchLevel())
                {
                    context.Writer.WritePropertyName("GeoMatchLevel");
                    context.Writer.Write(publicRequest.GeoMatchLevel);
                }

                if(publicRequest.IsSetGeoMatchParams())
                {
                    context.Writer.WritePropertyName("GeoMatchParams");
                    context.Writer.WriteObjectStart();

                    var marshaller = GeoMatchParamsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GeoMatchParams, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNumberSelectionBehavior())
                {
                    context.Writer.WritePropertyName("NumberSelectionBehavior");
                    context.Writer.Write(publicRequest.NumberSelectionBehavior);
                }

                if(publicRequest.IsSetParticipantPhoneNumbers())
                {
                    context.Writer.WritePropertyName("ParticipantPhoneNumbers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestParticipantPhoneNumbersListValue in publicRequest.ParticipantPhoneNumbers)
                    {
                            context.Writer.Write(publicRequestParticipantPhoneNumbersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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