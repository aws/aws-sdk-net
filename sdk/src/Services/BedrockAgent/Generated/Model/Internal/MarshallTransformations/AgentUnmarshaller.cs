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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Agent Object
    /// </summary>  
    public class AgentUnmarshaller : IUnmarshaller<Agent, XmlUnmarshallerContext>, IUnmarshaller<Agent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Agent IUnmarshaller<Agent, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Agent Unmarshall(JsonUnmarshallerContext context)
        {
            Agent unmarshalledObject = new Agent();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("agentArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("agentCollaboration", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentCollaboration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("agentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("agentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("agentResourceRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentResourceRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("agentStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("agentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clientToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customerEncryptionKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomerEncryptionKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customOrchestration", targetDepth))
                {
                    var unmarshaller = CustomOrchestrationUnmarshaller.Instance;
                    unmarshalledObject.CustomOrchestration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureReasons", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.FailureReasons = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("foundationModel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FoundationModel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("guardrailConfiguration", targetDepth))
                {
                    var unmarshaller = GuardrailConfigurationUnmarshaller.Instance;
                    unmarshalledObject.GuardrailConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("idleSessionTTLInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.IdleSessionTTLInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instruction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Instruction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("memoryConfiguration", targetDepth))
                {
                    var unmarshaller = MemoryConfigurationUnmarshaller.Instance;
                    unmarshalledObject.MemoryConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("orchestrationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OrchestrationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("preparedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.PreparedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("promptOverrideConfiguration", targetDepth))
                {
                    var unmarshaller = PromptOverrideConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PromptOverrideConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recommendedActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RecommendedActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AgentUnmarshaller _instance = new AgentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AgentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}