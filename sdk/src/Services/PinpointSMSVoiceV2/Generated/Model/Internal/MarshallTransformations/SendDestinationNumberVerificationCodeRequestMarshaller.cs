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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointSMSVoiceV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendDestinationNumberVerificationCode Request Marshaller
    /// </summary>       
    public class SendDestinationNumberVerificationCodeRequestMarshaller : IMarshaller<IRequest, SendDestinationNumberVerificationCodeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendDestinationNumberVerificationCodeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendDestinationNumberVerificationCodeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointSMSVoiceV2");
            string target = "PinpointSMSVoiceV2.SendDestinationNumberVerificationCode";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConfigurationSetName())
                {
                    context.Writer.WritePropertyName("ConfigurationSetName");
                    context.Writer.Write(publicRequest.ConfigurationSetName);
                }

                if(publicRequest.IsSetContext())
                {
                    context.Writer.WritePropertyName("Context");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestContextKvp in publicRequest.Context)
                    {
                        context.Writer.WritePropertyName(publicRequestContextKvp.Key);
                        var publicRequestContextValue = publicRequestContextKvp.Value;

                            context.Writer.Write(publicRequestContextValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDestinationCountryParameters())
                {
                    context.Writer.WritePropertyName("DestinationCountryParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestDestinationCountryParametersKvp in publicRequest.DestinationCountryParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestDestinationCountryParametersKvp.Key);
                        var publicRequestDestinationCountryParametersValue = publicRequestDestinationCountryParametersKvp.Value;

                            context.Writer.Write(publicRequestDestinationCountryParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLanguageCode())
                {
                    context.Writer.WritePropertyName("LanguageCode");
                    context.Writer.Write(publicRequest.LanguageCode);
                }

                if(publicRequest.IsSetOriginationIdentity())
                {
                    context.Writer.WritePropertyName("OriginationIdentity");
                    context.Writer.Write(publicRequest.OriginationIdentity);
                }

                if(publicRequest.IsSetVerificationChannel())
                {
                    context.Writer.WritePropertyName("VerificationChannel");
                    context.Writer.Write(publicRequest.VerificationChannel);
                }

                if(publicRequest.IsSetVerifiedDestinationNumberId())
                {
                    context.Writer.WritePropertyName("VerifiedDestinationNumberId");
                    context.Writer.Write(publicRequest.VerifiedDestinationNumberId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SendDestinationNumberVerificationCodeRequestMarshaller _instance = new SendDestinationNumberVerificationCodeRequestMarshaller();        

        internal static SendDestinationNumberVerificationCodeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendDestinationNumberVerificationCodeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}