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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FlowExecutionEvent Object
    /// </summary>  
    public class FlowExecutionEventUnmarshaller : IUnmarshaller<FlowExecutionEvent, XmlUnmarshallerContext>, IUnmarshaller<FlowExecutionEvent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FlowExecutionEvent IUnmarshaller<FlowExecutionEvent, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public FlowExecutionEvent Unmarshall(JsonUnmarshallerContext context)
        {
            FlowExecutionEvent unmarshalledObject = new FlowExecutionEvent();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("conditionResultEvent", targetDepth))
                {
                    var unmarshaller = ConditionResultEventUnmarshaller.Instance;
                    unmarshalledObject.ConditionResultEvent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("flowFailureEvent", targetDepth))
                {
                    var unmarshaller = FlowFailureEventUnmarshaller.Instance;
                    unmarshalledObject.FlowFailureEvent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("flowInputEvent", targetDepth))
                {
                    var unmarshaller = FlowExecutionInputEventUnmarshaller.Instance;
                    unmarshalledObject.FlowInputEvent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("flowOutputEvent", targetDepth))
                {
                    var unmarshaller = FlowExecutionOutputEventUnmarshaller.Instance;
                    unmarshalledObject.FlowOutputEvent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nodeActionEvent", targetDepth))
                {
                    var unmarshaller = NodeActionEventUnmarshaller.Instance;
                    unmarshalledObject.NodeActionEvent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nodeDependencyEvent", targetDepth))
                {
                    var unmarshaller = NodeDependencyEventUnmarshaller.Instance;
                    unmarshalledObject.NodeDependencyEvent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nodeFailureEvent", targetDepth))
                {
                    var unmarshaller = NodeFailureEventUnmarshaller.Instance;
                    unmarshalledObject.NodeFailureEvent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nodeInputEvent", targetDepth))
                {
                    var unmarshaller = NodeInputEventUnmarshaller.Instance;
                    unmarshalledObject.NodeInputEvent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nodeOutputEvent", targetDepth))
                {
                    var unmarshaller = NodeOutputEventUnmarshaller.Instance;
                    unmarshalledObject.NodeOutputEvent = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FlowExecutionEventUnmarshaller _instance = new FlowExecutionEventUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FlowExecutionEventUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}