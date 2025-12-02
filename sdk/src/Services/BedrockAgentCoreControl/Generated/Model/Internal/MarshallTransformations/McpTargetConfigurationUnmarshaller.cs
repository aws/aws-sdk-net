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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCoreControl.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for McpTargetConfiguration Object
    /// </summary>  
    public class McpTargetConfigurationUnmarshaller : IUnmarshaller<McpTargetConfiguration, XmlUnmarshallerContext>, IUnmarshaller<McpTargetConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        McpTargetConfiguration IUnmarshaller<McpTargetConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public McpTargetConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            McpTargetConfiguration unmarshalledObject = new McpTargetConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("apiGateway", targetDepth))
                {
                    var unmarshaller = ApiGatewayTargetConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ApiGateway = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lambda", targetDepth))
                {
                    var unmarshaller = McpLambdaTargetConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Lambda = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mcpServer", targetDepth))
                {
                    var unmarshaller = McpServerTargetConfigurationUnmarshaller.Instance;
                    unmarshalledObject.McpServer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("openApiSchema", targetDepth))
                {
                    var unmarshaller = ApiSchemaConfigurationUnmarshaller.Instance;
                    unmarshalledObject.OpenApiSchema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("smithyModel", targetDepth))
                {
                    var unmarshaller = ApiSchemaConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SmithyModel = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static McpTargetConfigurationUnmarshaller _instance = new McpTargetConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static McpTargetConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}