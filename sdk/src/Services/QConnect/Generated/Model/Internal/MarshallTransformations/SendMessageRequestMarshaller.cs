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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendMessage Request Marshaller
    /// </summary>       
    public class SendMessageRequestMarshaller : IMarshaller<IRequest, SendMessageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendMessageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAssistantId())
                throw new AmazonQConnectException("Request object does not have required field AssistantId set");
            request.AddPathResource("{assistantId}", StringUtils.FromString(publicRequest.AssistantId));
            if (!publicRequest.IsSetSessionId())
                throw new AmazonQConnectException("Request object does not have required field SessionId set");
            request.AddPathResource("{sessionId}", StringUtils.FromString(publicRequest.SessionId));
            request.ResourcePath = "/assistants/{assistantId}/sessions/{sessionId}/message";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAiAgentId())
                {
                    context.Writer.WritePropertyName("aiAgentId");
                    context.Writer.Write(publicRequest.AiAgentId);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetConfiguration())
                {
                    context.Writer.WritePropertyName("configuration");
                    context.Writer.WriteObjectStart();

                    var marshaller = MessageConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Configuration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetConversationContext())
                {
                    context.Writer.WritePropertyName("conversationContext");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConversationContextMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ConversationContext, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMessage())
                {
                    context.Writer.WritePropertyName("message");
                    context.Writer.WriteObjectStart();

                    var marshaller = MessageInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Message, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMetadata())
                {
                    context.Writer.WritePropertyName("metadata");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestMetadataKvp in publicRequest.Metadata)
                    {
                        context.Writer.WritePropertyName(publicRequestMetadataKvp.Key);
                        var publicRequestMetadataValue = publicRequestMetadataKvp.Value;

                            context.Writer.Write(publicRequestMetadataValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOrchestratorUseCase())
                {
                    context.Writer.WritePropertyName("orchestratorUseCase");
                    context.Writer.Write(publicRequest.OrchestratorUseCase);
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("type");
                    context.Writer.Write(publicRequest.Type);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SendMessageRequestMarshaller _instance = new SendMessageRequestMarshaller();        

        internal static SendMessageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendMessageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}