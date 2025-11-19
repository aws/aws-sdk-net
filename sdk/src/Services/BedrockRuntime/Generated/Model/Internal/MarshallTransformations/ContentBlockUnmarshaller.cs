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
    /// Response Unmarshaller for ContentBlock Object
    /// </summary>  
    public class ContentBlockUnmarshaller : IUnmarshaller<ContentBlock, XmlUnmarshallerContext>, IUnmarshaller<ContentBlock, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ContentBlock IUnmarshaller<ContentBlock, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ContentBlock Unmarshall(JsonUnmarshallerContext context)
        {
            ContentBlock unmarshalledObject = new ContentBlock();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cachePoint", targetDepth))
                {
                    var unmarshaller = CachePointBlockUnmarshaller.Instance;
                    unmarshalledObject.CachePoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("citationsContent", targetDepth))
                {
                    var unmarshaller = CitationsContentBlockUnmarshaller.Instance;
                    unmarshalledObject.CitationsContent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("document", targetDepth))
                {
                    var unmarshaller = DocumentBlockUnmarshaller.Instance;
                    unmarshalledObject.Document = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("guardContent", targetDepth))
                {
                    var unmarshaller = GuardrailConverseContentBlockUnmarshaller.Instance;
                    unmarshalledObject.GuardContent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("image", targetDepth))
                {
                    var unmarshaller = ImageBlockUnmarshaller.Instance;
                    unmarshalledObject.Image = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("reasoningContent", targetDepth))
                {
                    var unmarshaller = ReasoningContentBlockUnmarshaller.Instance;
                    unmarshalledObject.ReasoningContent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("searchResult", targetDepth))
                {
                    var unmarshaller = SearchResultBlockUnmarshaller.Instance;
                    unmarshalledObject.SearchResult = unmarshaller.Unmarshall(context);
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
                    var unmarshaller = ToolResultBlockUnmarshaller.Instance;
                    unmarshalledObject.ToolResult = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("toolUse", targetDepth))
                {
                    var unmarshaller = ToolUseBlockUnmarshaller.Instance;
                    unmarshalledObject.ToolUse = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("video", targetDepth))
                {
                    var unmarshaller = VideoBlockUnmarshaller.Instance;
                    unmarshalledObject.Video = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ContentBlockUnmarshaller _instance = new ContentBlockUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContentBlockUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}