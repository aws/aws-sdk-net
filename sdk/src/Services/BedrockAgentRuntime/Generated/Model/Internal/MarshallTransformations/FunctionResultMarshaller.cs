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
    /// FunctionResult Marshaller
    /// </summary>
    public class FunctionResultMarshaller : IRequestMarshaller<FunctionResult, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FunctionResult requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActionGroup())
            {
                context.Writer.WritePropertyName("actionGroup");
                context.Writer.Write(requestObject.ActionGroup);
            }

            if(requestObject.IsSetAgentId())
            {
                context.Writer.WritePropertyName("agentId");
                context.Writer.Write(requestObject.AgentId);
            }

            if(requestObject.IsSetConfirmationState())
            {
                context.Writer.WritePropertyName("confirmationState");
                context.Writer.Write(requestObject.ConfirmationState);
            }

            if(requestObject.IsSetFunction())
            {
                context.Writer.WritePropertyName("function");
                context.Writer.Write(requestObject.Function);
            }

            if(requestObject.IsSetResponseBody())
            {
                context.Writer.WritePropertyName("responseBody");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectResponseBodyKvp in requestObject.ResponseBody)
                {
                    context.Writer.WritePropertyName(requestObjectResponseBodyKvp.Key);
                    var requestObjectResponseBodyValue = requestObjectResponseBodyKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = ContentBodyMarshaller.Instance;
                    marshaller.Marshall(requestObjectResponseBodyValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetResponseState())
            {
                context.Writer.WritePropertyName("responseState");
                context.Writer.Write(requestObject.ResponseState);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FunctionResultMarshaller Instance = new FunctionResultMarshaller();

    }
}