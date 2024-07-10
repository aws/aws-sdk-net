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
    /// Response Unmarshaller for FlowNodeConfiguration Object
    /// </summary>  
    public class FlowNodeConfigurationUnmarshaller : IUnmarshaller<FlowNodeConfiguration, XmlUnmarshallerContext>, IUnmarshaller<FlowNodeConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FlowNodeConfiguration IUnmarshaller<FlowNodeConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public FlowNodeConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            FlowNodeConfiguration unmarshalledObject = new FlowNodeConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("agent", targetDepth))
                {
                    var unmarshaller = AgentFlowNodeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Agent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("collector", targetDepth))
                {
                    var unmarshaller = CollectorFlowNodeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Collector = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("condition", targetDepth))
                {
                    var unmarshaller = ConditionFlowNodeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Condition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("input", targetDepth))
                {
                    var unmarshaller = InputFlowNodeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Input = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iterator", targetDepth))
                {
                    var unmarshaller = IteratorFlowNodeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Iterator = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("knowledgeBase", targetDepth))
                {
                    var unmarshaller = KnowledgeBaseFlowNodeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.KnowledgeBase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lambdaFunction", targetDepth))
                {
                    var unmarshaller = LambdaFunctionFlowNodeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lex", targetDepth))
                {
                    var unmarshaller = LexFlowNodeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Lex = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("output", targetDepth))
                {
                    var unmarshaller = OutputFlowNodeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Output = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("prompt", targetDepth))
                {
                    var unmarshaller = PromptFlowNodeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Prompt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("retrieval", targetDepth))
                {
                    var unmarshaller = RetrievalFlowNodeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Retrieval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storage", targetDepth))
                {
                    var unmarshaller = StorageFlowNodeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Storage = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FlowNodeConfigurationUnmarshaller _instance = new FlowNodeConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FlowNodeConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}