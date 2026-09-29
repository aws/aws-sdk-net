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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.BedrockAgentCore.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CodeInterpreterResult Object
    /// </summary>
    public partial class CodeInterpreterResultUnmarshaller : IJsonUnmarshaller<CodeInterpreterResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public CodeInterpreterResult Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new CodeInterpreterResult();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("content", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ContentBlock, ContentBlockUnmarshaller>(ContentBlockUnmarshaller.Instance);
                    unmarshalledObject.Content = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("isError", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsError = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("structuredContent", targetDepth, ref reader))
                {
                    var unmarshaller = ToolResultStructuredContentUnmarshaller.Instance;
                    unmarshalledObject.StructuredContent = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static CodeInterpreterResultUnmarshaller _instance = new CodeInterpreterResultUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CodeInterpreterResultUnmarshaller Instance => _instance;
    }
}
