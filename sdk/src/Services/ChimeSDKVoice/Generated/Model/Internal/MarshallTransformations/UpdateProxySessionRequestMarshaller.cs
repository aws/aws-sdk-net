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
    /// UpdateProxySession Request Marshaller
    /// </summary>       
    public class UpdateProxySessionRequestMarshaller : IMarshaller<IRequest, UpdateProxySessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateProxySessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateProxySessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKVoice");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-08-03";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetProxySessionId())
                throw new AmazonChimeSDKVoiceException("Request object does not have required field ProxySessionId set");
            request.AddPathResource("{proxySessionId}", StringUtils.FromString(publicRequest.ProxySessionId));
            if (!publicRequest.IsSetVoiceConnectorId())
                throw new AmazonChimeSDKVoiceException("Request object does not have required field VoiceConnectorId set");
            request.AddPathResource("{voiceConnectorId}", StringUtils.FromString(publicRequest.VoiceConnectorId));
            request.ResourcePath = "/voice-connectors/{voiceConnectorId}/proxy-sessions/{proxySessionId}";
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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateProxySessionRequestMarshaller _instance = new UpdateProxySessionRequestMarshaller();        

        internal static UpdateProxySessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateProxySessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}