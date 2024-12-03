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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SessionState Marshaller
    /// </summary>
    public class SessionStateMarshaller : IRequestMarshaller<SessionState, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SessionState requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConversationHistory())
            {
                context.Writer.WritePropertyName("conversationHistory");
                context.Writer.WriteObjectStart();

                var marshaller = ConversationHistoryMarshaller.Instance;
                marshaller.Marshall(requestObject.ConversationHistory, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFiles())
            {
                context.Writer.WritePropertyName("files");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFilesListValue in requestObject.Files)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = InputFileMarshaller.Instance;
                    marshaller.Marshall(requestObjectFilesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInvocationId())
            {
                context.Writer.WritePropertyName("invocationId");
                context.Writer.Write(requestObject.InvocationId);
            }

            if(requestObject.IsSetKnowledgeBaseConfigurations())
            {
                context.Writer.WritePropertyName("knowledgeBaseConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectKnowledgeBaseConfigurationsListValue in requestObject.KnowledgeBaseConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = KnowledgeBaseConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectKnowledgeBaseConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPromptSessionAttributes())
            {
                context.Writer.WritePropertyName("promptSessionAttributes");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectPromptSessionAttributesKvp in requestObject.PromptSessionAttributes)
                {
                    context.Writer.WritePropertyName(requestObjectPromptSessionAttributesKvp.Key);
                    var requestObjectPromptSessionAttributesValue = requestObjectPromptSessionAttributesKvp.Value;

                        context.Writer.Write(requestObjectPromptSessionAttributesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetReturnControlInvocationResults())
            {
                context.Writer.WritePropertyName("returnControlInvocationResults");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectReturnControlInvocationResultsListValue in requestObject.ReturnControlInvocationResults)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = InvocationResultMemberMarshaller.Instance;
                    marshaller.Marshall(requestObjectReturnControlInvocationResultsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSessionAttributes())
            {
                context.Writer.WritePropertyName("sessionAttributes");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSessionAttributesKvp in requestObject.SessionAttributes)
                {
                    context.Writer.WritePropertyName(requestObjectSessionAttributesKvp.Key);
                    var requestObjectSessionAttributesValue = requestObjectSessionAttributesKvp.Value;

                        context.Writer.Write(requestObjectSessionAttributesValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SessionStateMarshaller Instance = new SessionStateMarshaller();

    }
}