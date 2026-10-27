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
    /// Response Unmarshaller for MultiplexM2tsSettings Object
    /// </summary>
    public partial class MultiplexM2tsSettingsUnmarshaller : IJsonUnmarshaller<MultiplexM2tsSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public MultiplexM2tsSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new MultiplexM2tsSettings();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("absentInputAudioBehavior", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AbsentInputAudioBehavior = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("arib", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arib = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("audioBufferModel", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioBufferModel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("audioFramesPerPes", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.AudioFramesPerPes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("audioStreamType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioStreamType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ccDescriptor", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CcDescriptor = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ebif", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ebif = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("esRateInPes", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EsRateInPes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("klv", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Klv = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("nielsenId3Behavior", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NielsenId3Behavior = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("pcrControl", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PcrControl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("pcrPeriod", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.PcrPeriod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("scte35Control", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Scte35Control = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("scte35PrerollPullupMilliseconds", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Scte35PrerollPullupMilliseconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static MultiplexM2tsSettingsUnmarshaller _instance = new MultiplexM2tsSettingsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static MultiplexM2tsSettingsUnmarshaller Instance => _instance;
    }
}
