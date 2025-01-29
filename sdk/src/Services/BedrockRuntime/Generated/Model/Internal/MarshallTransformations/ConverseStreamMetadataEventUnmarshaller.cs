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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConverseStreamMetadataEvent Object
    /// </summary>  
    public class ConverseStreamMetadataEventUnmarshaller : IJsonUnmarshaller<ConverseStreamMetadataEvent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ConverseStreamMetadataEvent Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ConverseStreamMetadataEvent unmarshalledObject = new ConverseStreamMetadataEvent();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("metrics", targetDepth))
                {
                    var unmarshaller = ConverseStreamMetricsUnmarshaller.Instance;
                    unmarshalledObject.Metrics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("performanceConfig", targetDepth))
                {
                    var unmarshaller = PerformanceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PerformanceConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("trace", targetDepth))
                {
                    var unmarshaller = ConverseStreamTraceUnmarshaller.Instance;
                    unmarshalledObject.Trace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("usage", targetDepth))
                {
                    var unmarshaller = TokenUsageUnmarshaller.Instance;
                    unmarshalledObject.Usage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ConverseStreamMetadataEventUnmarshaller _instance = new ConverseStreamMetadataEventUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConverseStreamMetadataEventUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}