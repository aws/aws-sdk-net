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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCore.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HarnessContentBlockStart Object
    /// </summary>  
    public class HarnessContentBlockStartUnmarshaller : IJsonUnmarshaller<HarnessContentBlockStart, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public HarnessContentBlockStart Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            HarnessContentBlockStart unmarshalledObject = new HarnessContentBlockStart();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("toolResult", targetDepth))
                {
                    var unmarshaller = HarnessToolResultBlockStartUnmarshaller.Instance;
                    unmarshalledObject.ToolResult = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("toolUse", targetDepth))
                {
                    var unmarshaller = HarnessToolUseBlockStartUnmarshaller.Instance;
                    unmarshalledObject.ToolUse = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static HarnessContentBlockStartUnmarshaller _instance = new HarnessContentBlockStartUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HarnessContentBlockStartUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}