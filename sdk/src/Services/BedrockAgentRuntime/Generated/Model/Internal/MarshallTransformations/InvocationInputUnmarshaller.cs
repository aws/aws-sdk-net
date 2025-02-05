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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InvocationInput Object
    /// </summary>  
    public class InvocationInputUnmarshaller : IJsonUnmarshaller<InvocationInput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public InvocationInput Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            InvocationInput unmarshalledObject = new InvocationInput();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("actionGroupInvocationInput", targetDepth))
                {
                    var unmarshaller = ActionGroupInvocationInputUnmarshaller.Instance;
                    unmarshalledObject.ActionGroupInvocationInput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("agentCollaboratorInvocationInput", targetDepth))
                {
                    var unmarshaller = AgentCollaboratorInvocationInputUnmarshaller.Instance;
                    unmarshalledObject.AgentCollaboratorInvocationInput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("codeInterpreterInvocationInput", targetDepth))
                {
                    var unmarshaller = CodeInterpreterInvocationInputUnmarshaller.Instance;
                    unmarshalledObject.CodeInterpreterInvocationInput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("invocationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InvocationType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("knowledgeBaseLookupInput", targetDepth))
                {
                    var unmarshaller = KnowledgeBaseLookupInputUnmarshaller.Instance;
                    unmarshalledObject.KnowledgeBaseLookupInput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("traceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TraceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InvocationInputUnmarshaller _instance = new InvocationInputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvocationInputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}