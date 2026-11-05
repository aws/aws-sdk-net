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

using Amazon.MediaLive.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InputDeviceUhdSettings Object
    /// </summary>
    public partial class InputDeviceUhdSettingsUnmarshaller : IJsonUnmarshaller<InputDeviceUhdSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public InputDeviceUhdSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new InputDeviceUhdSettings();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("activeInput", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActiveInput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("audioChannelPairs", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<InputDeviceUhdAudioChannelPairConfig, InputDeviceUhdAudioChannelPairConfigUnmarshaller>(InputDeviceUhdAudioChannelPairConfigUnmarshaller.Instance);
                    unmarshalledObject.AudioChannelPairs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("codec", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Codec = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("configuredInput", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConfiguredInput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("deviceState", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("framerate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Framerate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("height", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Height = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("inputResolution", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputResolution = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("latencyMs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.LatencyMs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("maxBitrate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MaxBitrate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("mediaconnectSettings", targetDepth, ref reader))
                {
                    var unmarshaller = InputDeviceMediaConnectSettingsUnmarshaller.Instance;
                    unmarshalledObject.MediaconnectSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("scanType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScanType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("width", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Width = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static InputDeviceUhdSettingsUnmarshaller _instance = new InputDeviceUhdSettingsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InputDeviceUhdSettingsUnmarshaller Instance => _instance;
    }
}
