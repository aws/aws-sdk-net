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
    /// Response Unmarshaller for Trace Object
    /// </summary>  
    public class TraceUnmarshaller : IJsonUnmarshaller<Trace, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Trace Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Trace unmarshalledObject = new Trace();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("customOrchestrationTrace", targetDepth))
                {
                    var unmarshaller = CustomOrchestrationTraceUnmarshaller.Instance;
                    unmarshalledObject.CustomOrchestrationTrace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("failureTrace", targetDepth))
                {
                    var unmarshaller = FailureTraceUnmarshaller.Instance;
                    unmarshalledObject.FailureTrace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("guardrailTrace", targetDepth))
                {
                    var unmarshaller = GuardrailTraceUnmarshaller.Instance;
                    unmarshalledObject.GuardrailTrace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("orchestrationTrace", targetDepth))
                {
                    var unmarshaller = OrchestrationTraceUnmarshaller.Instance;
                    unmarshalledObject.OrchestrationTrace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("postProcessingTrace", targetDepth))
                {
                    var unmarshaller = PostProcessingTraceUnmarshaller.Instance;
                    unmarshalledObject.PostProcessingTrace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("preProcessingTrace", targetDepth))
                {
                    var unmarshaller = PreProcessingTraceUnmarshaller.Instance;
                    unmarshalledObject.PreProcessingTrace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("routingClassifierTrace", targetDepth))
                {
                    var unmarshaller = RoutingClassifierTraceUnmarshaller.Instance;
                    unmarshalledObject.RoutingClassifierTrace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TraceUnmarshaller _instance = new TraceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TraceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}