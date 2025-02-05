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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMIncidents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SSMIncidents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ChatChannel Marshaller
    /// </summary>
    public class ChatChannelMarshaller : IRequestMarshaller<ChatChannel, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ChatChannel requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetChatbotSns())
            {
                context.Writer.WritePropertyName("chatbotSns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectChatbotSnsListValue in requestObject.ChatbotSns)
                {
                        context.Writer.WriteStringValue(requestObjectChatbotSnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEmpty())
            {
                context.Writer.WritePropertyName("empty");
                context.Writer.WriteStartObject();

                var marshaller = EmptyChatChannelMarshaller.Instance;
                marshaller.Marshall(requestObject.Empty, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ChatChannelMarshaller Instance = new ChatChannelMarshaller();

    }
}