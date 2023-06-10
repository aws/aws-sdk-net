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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartChatContact Request Marshaller
    /// </summary>       
    public class StartChatContactRequestMarshaller : IMarshaller<IRequest, StartChatContactRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartChatContactRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartChatContactRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/contact/chat";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttributes())
                {
                    context.Writer.WritePropertyName("Attributes");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                    {
                        context.Writer.WritePropertyName(publicRequestAttributesKvp.Key);
                        var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                            context.Writer.Write(publicRequestAttributesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetChatDurationInMinutes())
                {
                    context.Writer.WritePropertyName("ChatDurationInMinutes");
                    context.Writer.Write(publicRequest.ChatDurationInMinutes);
                }

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
                if(publicRequest.IsSetContactFlowId())
                {
                    context.Writer.WritePropertyName("ContactFlowId");
                    context.Writer.Write(publicRequest.ContactFlowId);
                }

                if(publicRequest.IsSetInitialMessage())
                {
                    context.Writer.WritePropertyName("InitialMessage");
                    context.Writer.WriteObjectStart();

                    var marshaller = ChatMessageMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InitialMessage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInstanceId())
                {
                    context.Writer.WritePropertyName("InstanceId");
                    context.Writer.Write(publicRequest.InstanceId);
                }

                if(publicRequest.IsSetParticipantDetails())
                {
                    context.Writer.WritePropertyName("ParticipantDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = ParticipantDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ParticipantDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPersistentChat())
                {
                    context.Writer.WritePropertyName("PersistentChat");
                    context.Writer.WriteObjectStart();

                    var marshaller = PersistentChatMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PersistentChat, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRelatedContactId())
                {
                    context.Writer.WritePropertyName("RelatedContactId");
                    context.Writer.Write(publicRequest.RelatedContactId);
                }

                if(publicRequest.IsSetSupportedMessagingContentTypes())
                {
                    context.Writer.WritePropertyName("SupportedMessagingContentTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSupportedMessagingContentTypesListValue in publicRequest.SupportedMessagingContentTypes)
                    {
                            context.Writer.Write(publicRequestSupportedMessagingContentTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartChatContactRequestMarshaller _instance = new StartChatContactRequestMarshaller();        

        internal static StartChatContactRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartChatContactRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}