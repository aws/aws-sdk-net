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
    /// Response Unmarshaller for FlowTrace Object
    /// </summary>  
    public class FlowTraceUnmarshaller : IJsonUnmarshaller<FlowTrace, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public FlowTrace Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            FlowTrace unmarshalledObject = new FlowTrace();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("conditionNodeResultTrace", targetDepth))
                {
                    var unmarshaller = FlowTraceConditionNodeResultEventUnmarshaller.Instance;
                    unmarshalledObject.ConditionNodeResultTrace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nodeActionTrace", targetDepth))
                {
                    var unmarshaller = FlowTraceNodeActionEventUnmarshaller.Instance;
                    unmarshalledObject.NodeActionTrace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nodeDependencyTrace", targetDepth))
                {
                    var unmarshaller = FlowTraceDependencyEventUnmarshaller.Instance;
                    unmarshalledObject.NodeDependencyTrace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nodeInputTrace", targetDepth))
                {
                    var unmarshaller = FlowTraceNodeInputEventUnmarshaller.Instance;
                    unmarshalledObject.NodeInputTrace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nodeOutputTrace", targetDepth))
                {
                    var unmarshaller = FlowTraceNodeOutputEventUnmarshaller.Instance;
                    unmarshalledObject.NodeOutputTrace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FlowTraceUnmarshaller _instance = new FlowTraceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FlowTraceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}