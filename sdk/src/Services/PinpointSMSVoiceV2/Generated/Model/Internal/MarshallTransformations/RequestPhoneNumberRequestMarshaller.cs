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
    /// RequestPhoneNumber Request Marshaller
    /// </summary>       
    public class RequestPhoneNumberRequestMarshaller : IMarshaller<IRequest, RequestPhoneNumberRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RequestPhoneNumberRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RequestPhoneNumberRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointSMSVoiceV2");
            string target = "PinpointSMSVoiceV2.RequestPhoneNumber";
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
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDeletionProtectionEnabled())
                {
                    context.Writer.WritePropertyName("DeletionProtectionEnabled");
                    context.Writer.Write(publicRequest.DeletionProtectionEnabled);
                }

                if(publicRequest.IsSetInternationalSendingEnabled())
                {
                    context.Writer.WritePropertyName("InternationalSendingEnabled");
                    context.Writer.Write(publicRequest.InternationalSendingEnabled);
                }

                if(publicRequest.IsSetIsoCountryCode())
                {
                    context.Writer.WritePropertyName("IsoCountryCode");
                    context.Writer.Write(publicRequest.IsoCountryCode);
                }

                if(publicRequest.IsSetMessageType())
                {
                    context.Writer.WritePropertyName("MessageType");
                    context.Writer.Write(publicRequest.MessageType);
                }

                if(publicRequest.IsSetNumberCapabilities())
                {
                    context.Writer.WritePropertyName("NumberCapabilities");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNumberCapabilitiesListValue in publicRequest.NumberCapabilities)
                    {
                            context.Writer.Write(publicRequestNumberCapabilitiesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNumberType())
                {
                    context.Writer.WritePropertyName("NumberType");
                    context.Writer.Write(publicRequest.NumberType);
                }

                if(publicRequest.IsSetOptOutListName())
                {
                    context.Writer.WritePropertyName("OptOutListName");
                    context.Writer.Write(publicRequest.OptOutListName);
                }

                if(publicRequest.IsSetPoolId())
                {
                    context.Writer.WritePropertyName("PoolId");
                    context.Writer.Write(publicRequest.PoolId);
                }

                if(publicRequest.IsSetRegistrationId())
                {
                    context.Writer.WritePropertyName("RegistrationId");
                    context.Writer.Write(publicRequest.RegistrationId);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

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
        private static RequestPhoneNumberRequestMarshaller _instance = new RequestPhoneNumberRequestMarshaller();        

        internal static RequestPhoneNumberRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RequestPhoneNumberRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}