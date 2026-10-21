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

using Amazon.BedrockRuntime.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ToolResultContentBlock Object
    /// </summary>
    public partial class ToolResultContentBlockUnmarshaller : IJsonUnmarshaller<ToolResultContentBlock, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ToolResultContentBlock Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new ToolResultContentBlock();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("document", targetDepth, ref reader))
                {
                    var unmarshaller = DocumentBlockUnmarshaller.Instance;
                    unmarshalledObject.Document = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("image", targetDepth, ref reader))
                {
                    var unmarshaller = ImageBlockUnmarshaller.Instance;
                    unmarshalledObject.Image = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("json", targetDepth, ref reader))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    unmarshalledObject.Json = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("searchResult", targetDepth, ref reader))
                {
                    var unmarshaller = SearchResultBlockUnmarshaller.Instance;
                    unmarshalledObject.SearchResult = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("text", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Text = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("video", targetDepth, ref reader))
                {
                    var unmarshaller = VideoBlockUnmarshaller.Instance;
                    unmarshalledObject.Video = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static ToolResultContentBlockUnmarshaller _instance = new ToolResultContentBlockUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ToolResultContentBlockUnmarshaller Instance => _instance;
    }
}
