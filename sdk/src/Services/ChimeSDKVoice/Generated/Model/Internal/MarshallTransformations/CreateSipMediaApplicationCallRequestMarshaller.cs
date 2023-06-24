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
    /// CreateSipMediaApplicationCall Request Marshaller
    /// </summary>       
    public class CreateSipMediaApplicationCallRequestMarshaller : IMarshaller<IRequest, CreateSipMediaApplicationCallRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSipMediaApplicationCallRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSipMediaApplicationCallRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKVoice");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-08-03";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetSipMediaApplicationId())
                throw new AmazonChimeSDKVoiceException("Request object does not have required field SipMediaApplicationId set");
            request.AddPathResource("{sipMediaApplicationId}", StringUtils.FromString(publicRequest.SipMediaApplicationId));
            request.ResourcePath = "/sip-media-applications/{sipMediaApplicationId}/calls";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetArgumentsMap())
                {
                    context.Writer.WritePropertyName("ArgumentsMap");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestArgumentsMapKvp in publicRequest.ArgumentsMap)
                    {
                        context.Writer.WritePropertyName(publicRequestArgumentsMapKvp.Key);
                        var publicRequestArgumentsMapValue = publicRequestArgumentsMapKvp.Value;

                            context.Writer.Write(publicRequestArgumentsMapValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFromPhoneNumber())
                {
                    context.Writer.WritePropertyName("FromPhoneNumber");
                    context.Writer.Write(publicRequest.FromPhoneNumber);
                }

                if(publicRequest.IsSetSipHeaders())
                {
                    context.Writer.WritePropertyName("SipHeaders");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestSipHeadersKvp in publicRequest.SipHeaders)
                    {
                        context.Writer.WritePropertyName(publicRequestSipHeadersKvp.Key);
                        var publicRequestSipHeadersValue = publicRequestSipHeadersKvp.Value;

                            context.Writer.Write(publicRequestSipHeadersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetToPhoneNumber())
                {
                    context.Writer.WritePropertyName("ToPhoneNumber");
                    context.Writer.Write(publicRequest.ToPhoneNumber);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateSipMediaApplicationCallRequestMarshaller _instance = new CreateSipMediaApplicationCallRequestMarshaller();        

        internal static CreateSipMediaApplicationCallRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSipMediaApplicationCallRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}