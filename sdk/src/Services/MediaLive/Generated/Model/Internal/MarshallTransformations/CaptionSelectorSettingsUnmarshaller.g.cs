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
    /// Response Unmarshaller for CaptionSelectorSettings Object
    /// </summary>
    public partial class CaptionSelectorSettingsUnmarshaller : IJsonUnmarshaller<CaptionSelectorSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public CaptionSelectorSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new CaptionSelectorSettings();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ancillarySourceSettings", targetDepth, ref reader))
                {
                    var unmarshaller = AncillarySourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.AncillarySourceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("aribSourceSettings", targetDepth, ref reader))
                {
                    var unmarshaller = AribSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.AribSourceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("dvbSubSourceSettings", targetDepth, ref reader))
                {
                    var unmarshaller = DvbSubSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.DvbSubSourceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("embeddedSourceSettings", targetDepth, ref reader))
                {
                    var unmarshaller = EmbeddedSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.EmbeddedSourceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("scte20SourceSettings", targetDepth, ref reader))
                {
                    var unmarshaller = Scte20SourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte20SourceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("scte27SourceSettings", targetDepth, ref reader))
                {
                    var unmarshaller = Scte27SourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte27SourceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("smartSubtitleSourceSettings", targetDepth, ref reader))
                {
                    var unmarshaller = SmartSubtitleSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.SmartSubtitleSourceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("teletextSourceSettings", targetDepth, ref reader))
                {
                    var unmarshaller = TeletextSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.TeletextSourceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static CaptionSelectorSettingsUnmarshaller _instance = new CaptionSelectorSettingsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CaptionSelectorSettingsUnmarshaller Instance => _instance;
    }
}
