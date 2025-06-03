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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FlowValidationDetails Object
    /// </summary>  
    public class FlowValidationDetailsUnmarshaller : IJsonUnmarshaller<FlowValidationDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public FlowValidationDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            FlowValidationDetails unmarshalledObject = new FlowValidationDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("cyclicConnection", targetDepth))
                {
                    var unmarshaller = CyclicConnectionFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.CyclicConnection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("duplicateConditionExpression", targetDepth))
                {
                    var unmarshaller = DuplicateConditionExpressionFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.DuplicateConditionExpression = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("duplicateConnections", targetDepth))
                {
                    var unmarshaller = DuplicateConnectionsFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.DuplicateConnections = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("incompatibleConnectionDataType", targetDepth))
                {
                    var unmarshaller = IncompatibleConnectionDataTypeFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.IncompatibleConnectionDataType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("invalidLoopBoundary", targetDepth))
                {
                    var unmarshaller = InvalidLoopBoundaryFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.InvalidLoopBoundary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("loopIncompatibleNodeType", targetDepth))
                {
                    var unmarshaller = LoopIncompatibleNodeTypeFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.LoopIncompatibleNodeType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("malformedConditionExpression", targetDepth))
                {
                    var unmarshaller = MalformedConditionExpressionFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MalformedConditionExpression = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("malformedNodeInputExpression", targetDepth))
                {
                    var unmarshaller = MalformedNodeInputExpressionFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MalformedNodeInputExpression = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mismatchedNodeInputType", targetDepth))
                {
                    var unmarshaller = MismatchedNodeInputTypeFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MismatchedNodeInputType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mismatchedNodeOutputType", targetDepth))
                {
                    var unmarshaller = MismatchedNodeOutputTypeFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MismatchedNodeOutputType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("missingConnectionConfiguration", targetDepth))
                {
                    var unmarshaller = MissingConnectionConfigurationFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MissingConnectionConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("missingDefaultCondition", targetDepth))
                {
                    var unmarshaller = MissingDefaultConditionFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MissingDefaultCondition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("missingEndingNodes", targetDepth))
                {
                    var unmarshaller = MissingEndingNodesFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MissingEndingNodes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("missingLoopControllerNode", targetDepth))
                {
                    var unmarshaller = MissingLoopControllerNodeFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MissingLoopControllerNode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("missingLoopInputNode", targetDepth))
                {
                    var unmarshaller = MissingLoopInputNodeFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MissingLoopInputNode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("missingNodeConfiguration", targetDepth))
                {
                    var unmarshaller = MissingNodeConfigurationFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MissingNodeConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("missingNodeInput", targetDepth))
                {
                    var unmarshaller = MissingNodeInputFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MissingNodeInput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("missingNodeOutput", targetDepth))
                {
                    var unmarshaller = MissingNodeOutputFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MissingNodeOutput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("missingStartingNodes", targetDepth))
                {
                    var unmarshaller = MissingStartingNodesFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MissingStartingNodes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("multipleLoopControllerNodes", targetDepth))
                {
                    var unmarshaller = MultipleLoopControllerNodesFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MultipleLoopControllerNodes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("multipleLoopInputNodes", targetDepth))
                {
                    var unmarshaller = MultipleLoopInputNodesFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MultipleLoopInputNodes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("multipleNodeInputConnections", targetDepth))
                {
                    var unmarshaller = MultipleNodeInputConnectionsFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.MultipleNodeInputConnections = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unfulfilledNodeInput", targetDepth))
                {
                    var unmarshaller = UnfulfilledNodeInputFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.UnfulfilledNodeInput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unknownConnectionCondition", targetDepth))
                {
                    var unmarshaller = UnknownConnectionConditionFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.UnknownConnectionCondition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unknownConnectionSource", targetDepth))
                {
                    var unmarshaller = UnknownConnectionSourceFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.UnknownConnectionSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unknownConnectionSourceOutput", targetDepth))
                {
                    var unmarshaller = UnknownConnectionSourceOutputFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.UnknownConnectionSourceOutput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unknownConnectionTarget", targetDepth))
                {
                    var unmarshaller = UnknownConnectionTargetFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.UnknownConnectionTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unknownConnectionTargetInput", targetDepth))
                {
                    var unmarshaller = UnknownConnectionTargetInputFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.UnknownConnectionTargetInput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unknownNodeInput", targetDepth))
                {
                    var unmarshaller = UnknownNodeInputFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.UnknownNodeInput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unknownNodeOutput", targetDepth))
                {
                    var unmarshaller = UnknownNodeOutputFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.UnknownNodeOutput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unreachableNode", targetDepth))
                {
                    var unmarshaller = UnreachableNodeFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.UnreachableNode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unsatisfiedConnectionConditions", targetDepth))
                {
                    var unmarshaller = UnsatisfiedConnectionConditionsFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.UnsatisfiedConnectionConditions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unspecified", targetDepth))
                {
                    var unmarshaller = UnspecifiedFlowValidationDetailsUnmarshaller.Instance;
                    unmarshalledObject.Unspecified = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FlowValidationDetailsUnmarshaller _instance = new FlowValidationDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FlowValidationDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}