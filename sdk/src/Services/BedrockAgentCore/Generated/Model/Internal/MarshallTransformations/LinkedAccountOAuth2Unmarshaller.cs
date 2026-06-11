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
    /// Response Unmarshaller for LinkedAccountOAuth2 Object
    /// </summary>  
    public class LinkedAccountOAuth2Unmarshaller : IJsonUnmarshaller<LinkedAccountOAuth2, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public LinkedAccountOAuth2 Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            LinkedAccountOAuth2 unmarshalledObject = new LinkedAccountOAuth2();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("apple", targetDepth, ref reader))
                {
                    var unmarshaller = OAuth2AuthenticationUnmarshaller.Instance;
                    unmarshalledObject.Apple = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("github", targetDepth, ref reader))
                {
                    var unmarshaller = OAuth2AuthenticationUnmarshaller.Instance;
                    unmarshalledObject.Github = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("google", targetDepth, ref reader))
                {
                    var unmarshaller = OAuth2AuthenticationUnmarshaller.Instance;
                    unmarshalledObject.Google = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("telegram", targetDepth, ref reader))
                {
                    var unmarshaller = OAuth2AuthenticationUnmarshaller.Instance;
                    unmarshalledObject.Telegram = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("x", targetDepth, ref reader))
                {
                    var unmarshaller = OAuth2AuthenticationUnmarshaller.Instance;
                    unmarshalledObject.X = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LinkedAccountOAuth2Unmarshaller _instance = new LinkedAccountOAuth2Unmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LinkedAccountOAuth2Unmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}