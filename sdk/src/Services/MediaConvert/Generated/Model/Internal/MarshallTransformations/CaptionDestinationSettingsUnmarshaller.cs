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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CaptionDestinationSettings Object
    /// </summary>  
    public class CaptionDestinationSettingsUnmarshaller : IJsonUnmarshaller<CaptionDestinationSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CaptionDestinationSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CaptionDestinationSettings unmarshalledObject = new CaptionDestinationSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("burninDestinationSettings", targetDepth))
                {
                    var unmarshaller = BurninDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.BurninDestinationSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("destinationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dvbSubDestinationSettings", targetDepth))
                {
                    var unmarshaller = DvbSubDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.DvbSubDestinationSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("embeddedDestinationSettings", targetDepth))
                {
                    var unmarshaller = EmbeddedDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.EmbeddedDestinationSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("imscDestinationSettings", targetDepth))
                {
                    var unmarshaller = ImscDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.ImscDestinationSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sccDestinationSettings", targetDepth))
                {
                    var unmarshaller = SccDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.SccDestinationSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("srtDestinationSettings", targetDepth))
                {
                    var unmarshaller = SrtDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.SrtDestinationSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("teletextDestinationSettings", targetDepth))
                {
                    var unmarshaller = TeletextDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.TeletextDestinationSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ttmlDestinationSettings", targetDepth))
                {
                    var unmarshaller = TtmlDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.TtmlDestinationSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("webvttDestinationSettings", targetDepth))
                {
                    var unmarshaller = WebvttDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.WebvttDestinationSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CaptionDestinationSettingsUnmarshaller _instance = new CaptionDestinationSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CaptionDestinationSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}