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
 * Do not modify this file. This file is generated from the ivschat-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Ivschat.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Ivschat.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateChatToken Request Marshaller
    /// </summary>       
    public class CreateChatTokenRequestMarshaller : IMarshaller<IRequest, CreateChatTokenRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateChatTokenRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateChatTokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Ivschat");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/CreateChatToken";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttributes())
                {
                    context.Writer.WritePropertyName("attributes");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                    {
                        context.Writer.WritePropertyName(publicRequestAttributesKvp.Key);
                        var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                            context.Writer.Write(publicRequestAttributesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCapabilities())
                {
                    context.Writer.WritePropertyName("capabilities");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCapabilitiesListValue in publicRequest.Capabilities)
                    {
                            context.Writer.Write(publicRequestCapabilitiesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRoomIdentifier())
                {
                    context.Writer.WritePropertyName("roomIdentifier");
                    context.Writer.Write(publicRequest.RoomIdentifier);
                }

                if(publicRequest.IsSetSessionDurationInMinutes())
                {
                    context.Writer.WritePropertyName("sessionDurationInMinutes");
                    context.Writer.Write(publicRequest.SessionDurationInMinutes);
                }

                if(publicRequest.IsSetUserId())
                {
                    context.Writer.WritePropertyName("userId");
                    context.Writer.Write(publicRequest.UserId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateChatTokenRequestMarshaller _instance = new CreateChatTokenRequestMarshaller();        

        internal static CreateChatTokenRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateChatTokenRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}