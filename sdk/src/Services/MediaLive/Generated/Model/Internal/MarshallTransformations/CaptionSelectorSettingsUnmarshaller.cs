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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CaptionSelectorSettings Object
    /// </summary>  
    public class CaptionSelectorSettingsUnmarshaller : IJsonUnmarshaller<CaptionSelectorSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CaptionSelectorSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CaptionSelectorSettings unmarshalledObject = new CaptionSelectorSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ancillarySourceSettings", targetDepth))
                {
                    var unmarshaller = AncillarySourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.AncillarySourceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("aribSourceSettings", targetDepth))
                {
                    var unmarshaller = AribSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.AribSourceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dvbSubSourceSettings", targetDepth))
                {
                    var unmarshaller = DvbSubSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.DvbSubSourceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("embeddedSourceSettings", targetDepth))
                {
                    var unmarshaller = EmbeddedSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.EmbeddedSourceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scte20SourceSettings", targetDepth))
                {
                    var unmarshaller = Scte20SourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte20SourceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scte27SourceSettings", targetDepth))
                {
                    var unmarshaller = Scte27SourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte27SourceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("teletextSourceSettings", targetDepth))
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
        public static CaptionSelectorSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}