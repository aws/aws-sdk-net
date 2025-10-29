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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ContentBlockDelta Object
    /// </summary>  
    public class ContentBlockDeltaUnmarshaller : IUnmarshaller<ContentBlockDelta, XmlUnmarshallerContext>, IUnmarshaller<ContentBlockDelta, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ContentBlockDelta IUnmarshaller<ContentBlockDelta, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ContentBlockDelta Unmarshall(JsonUnmarshallerContext context)
        {
            ContentBlockDelta unmarshalledObject = new ContentBlockDelta();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("citation", targetDepth))
                {
                    var unmarshaller = CitationsDeltaUnmarshaller.Instance;
                    unmarshalledObject.Citation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("reasoningContent", targetDepth))
                {
                    var unmarshaller = ReasoningContentBlockDeltaUnmarshaller.Instance;
                    unmarshalledObject.ReasoningContent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("text", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Text = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("toolResult", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ToolResultBlockDelta, ToolResultBlockDeltaUnmarshaller>(ToolResultBlockDeltaUnmarshaller.Instance);
                    unmarshalledObject.ToolResult = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("toolUse", targetDepth))
                {
                    var unmarshaller = ToolUseBlockDeltaUnmarshaller.Instance;
                    unmarshalledObject.ToolUse = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ContentBlockDeltaUnmarshaller _instance = new ContentBlockDeltaUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContentBlockDeltaUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}