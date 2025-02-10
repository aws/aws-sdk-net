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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QBusiness.Model;
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
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ChatSync Request Marshaller
    /// </summary>       
    public class ChatSyncRequestMarshaller : IMarshaller<IRequest, ChatSyncRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ChatSyncRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ChatSyncRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QBusiness");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-27";
            request.HttpMethod = "POST";

            request.AddSubResource("sync");
            if (!publicRequest.IsSetApplicationId())
                throw new AmazonQBusinessException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            
            if (publicRequest.IsSetUserGroups())
                request.ParameterCollection.Add("userGroups", publicRequest.UserGroups);
            
            if (publicRequest.IsSetUserId())
                request.Parameters.Add("userId", StringUtils.FromString(publicRequest.UserId));
            request.ResourcePath = "/applications/{applicationId}/conversations";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetActionExecution())
            {
                context.Writer.WritePropertyName("actionExecution");
                context.Writer.WriteStartObject();

                var marshaller = ActionExecutionMarshaller.Instance;
                marshaller.Marshall(publicRequest.ActionExecution, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAttachments())
            {
                context.Writer.WritePropertyName("attachments");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAttachmentsListValue in publicRequest.Attachments)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AttachmentInputMarshaller.Instance;
                    marshaller.Marshall(publicRequestAttachmentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAttributeFilter())
            {
                context.Writer.WritePropertyName("attributeFilter");
                context.Writer.WriteStartObject();

                var marshaller = AttributeFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.AttributeFilter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAuthChallengeResponse())
            {
                context.Writer.WritePropertyName("authChallengeResponse");
                context.Writer.WriteStartObject();

                var marshaller = AuthChallengeResponseMarshaller.Instance;
                marshaller.Marshall(publicRequest.AuthChallengeResponse, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetChatMode())
            {
                context.Writer.WritePropertyName("chatMode");
                context.Writer.WriteStringValue(publicRequest.ChatMode);
            }

            if(publicRequest.IsSetChatModeConfiguration())
            {
                context.Writer.WritePropertyName("chatModeConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ChatModeConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ChatModeConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetConversationId())
            {
                context.Writer.WritePropertyName("conversationId");
                context.Writer.WriteStringValue(publicRequest.ConversationId);
            }

            if(publicRequest.IsSetParentMessageId())
            {
                context.Writer.WritePropertyName("parentMessageId");
                context.Writer.WriteStringValue(publicRequest.ParentMessageId);
            }

            if(publicRequest.IsSetUserMessage())
            {
                context.Writer.WritePropertyName("userMessage");
                context.Writer.WriteStringValue(publicRequest.UserMessage);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            request.UseQueryString = true;

            return request;
        }
        private static ChatSyncRequestMarshaller _instance = new ChatSyncRequestMarshaller();        

        internal static ChatSyncRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ChatSyncRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}