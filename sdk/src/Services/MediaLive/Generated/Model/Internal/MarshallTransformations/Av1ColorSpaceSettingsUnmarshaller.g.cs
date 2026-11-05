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
    /// Response Unmarshaller for Av1ColorSpaceSettings Object
    /// </summary>
    public partial class Av1ColorSpaceSettingsUnmarshaller : IJsonUnmarshaller<Av1ColorSpaceSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Av1ColorSpaceSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new Av1ColorSpaceSettings();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("colorSpacePassthroughSettings", targetDepth, ref reader))
                {
                    var unmarshaller = ColorSpacePassthroughSettingsUnmarshaller.Instance;
                    unmarshalledObject.ColorSpacePassthroughSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("hdr10Settings", targetDepth, ref reader))
                {
                    var unmarshaller = Hdr10SettingsUnmarshaller.Instance;
                    unmarshalledObject.Hdr10Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("hlg2020Settings", targetDepth, ref reader))
                {
                    var unmarshaller = Hlg2020SettingsUnmarshaller.Instance;
                    unmarshalledObject.Hlg2020Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("rec601Settings", targetDepth, ref reader))
                {
                    var unmarshaller = Rec601SettingsUnmarshaller.Instance;
                    unmarshalledObject.Rec601Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("rec709Settings", targetDepth, ref reader))
                {
                    var unmarshaller = Rec709SettingsUnmarshaller.Instance;
                    unmarshalledObject.Rec709Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static Av1ColorSpaceSettingsUnmarshaller _instance = new Av1ColorSpaceSettingsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static Av1ColorSpaceSettingsUnmarshaller Instance => _instance;
    }
}
