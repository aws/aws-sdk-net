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
    /// Response Unmarshaller for OrchestrationTrace Object
    /// </summary>  
    public class OrchestrationTraceUnmarshaller : IUnmarshaller<OrchestrationTrace, XmlUnmarshallerContext>, IUnmarshaller<OrchestrationTrace, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OrchestrationTrace IUnmarshaller<OrchestrationTrace, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OrchestrationTrace Unmarshall(JsonUnmarshallerContext context)
        {
            OrchestrationTrace unmarshalledObject = new OrchestrationTrace();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("invocationInput", targetDepth))
                {
                    var unmarshaller = InvocationInputUnmarshaller.Instance;
                    unmarshalledObject.InvocationInput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("modelInvocationInput", targetDepth))
                {
                    var unmarshaller = ModelInvocationInputUnmarshaller.Instance;
                    unmarshalledObject.ModelInvocationInput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("modelInvocationOutput", targetDepth))
                {
                    var unmarshaller = OrchestrationModelInvocationOutputUnmarshaller.Instance;
                    unmarshalledObject.ModelInvocationOutput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("observation", targetDepth))
                {
                    var unmarshaller = ObservationUnmarshaller.Instance;
                    unmarshalledObject.Observation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rationale", targetDepth))
                {
                    var unmarshaller = RationaleUnmarshaller.Instance;
                    unmarshalledObject.Rationale = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OrchestrationTraceUnmarshaller _instance = new OrchestrationTraceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OrchestrationTraceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}