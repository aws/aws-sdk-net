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
    /// Response Unmarshaller for AudioPreMixerSettings Object
    /// </summary>
    public partial class AudioPreMixerSettingsUnmarshaller : IJsonUnmarshaller<AudioPreMixerSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AudioPreMixerSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new AudioPreMixerSettings();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("audioNormalizationSettings", targetDepth, ref reader))
                {
                    var unmarshaller = AudioNormalizationSettingsUnmarshaller.Instance;
                    unmarshalledObject.AudioNormalizationSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("channels", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Channels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("gainDb", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.GainDb = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("remixSettings", targetDepth, ref reader))
                {
                    var unmarshaller = RemixSettingsUnmarshaller.Instance;
                    unmarshalledObject.RemixSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static AudioPreMixerSettingsUnmarshaller _instance = new AudioPreMixerSettingsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AudioPreMixerSettingsUnmarshaller Instance => _instance;
    }
}
