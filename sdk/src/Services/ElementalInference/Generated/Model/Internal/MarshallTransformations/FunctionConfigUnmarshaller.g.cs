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

using Amazon.ElementalInference.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElementalInference.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FunctionConfig Object
    /// </summary>
    public partial class FunctionConfigUnmarshaller : IJsonUnmarshaller<FunctionConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public FunctionConfig Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new FunctionConfig();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("clippingSettings", targetDepth, ref reader))
                {
                    var unmarshaller = ClippingSettingsUnmarshaller.Instance;
                    unmarshalledObject.ClippingSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("contextualMetadataSettings", targetDepth, ref reader))
                {
                    var unmarshaller = ContextualMetadataSettingsUnmarshaller.Instance;
                    unmarshalledObject.ContextualMetadataSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("frameSettings", targetDepth, ref reader))
                {
                    var unmarshaller = FrameSettingsUnmarshaller.Instance;
                    unmarshalledObject.FrameSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("functionArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FunctionArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("subtitlingSettings", targetDepth, ref reader))
                {
                    var unmarshaller = SubtitlingSettingsUnmarshaller.Instance;
                    unmarshalledObject.SubtitlingSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("trigger", targetDepth, ref reader))
                {
                    var unmarshaller = TriggerUnmarshaller.Instance;
                    unmarshalledObject.Trigger = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static FunctionConfigUnmarshaller _instance = new FunctionConfigUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static FunctionConfigUnmarshaller Instance => _instance;
    }
}
