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
    /// Response Unmarshaller for OutputSettings Object
    /// </summary>  
    public class OutputSettingsUnmarshaller : IJsonUnmarshaller<OutputSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public OutputSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            OutputSettings unmarshalledObject = new OutputSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("archiveOutputSettings", targetDepth))
                {
                    var unmarshaller = ArchiveOutputSettingsUnmarshaller.Instance;
                    unmarshalledObject.ArchiveOutputSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cmafIngestOutputSettings", targetDepth))
                {
                    var unmarshaller = CmafIngestOutputSettingsUnmarshaller.Instance;
                    unmarshalledObject.CmafIngestOutputSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("frameCaptureOutputSettings", targetDepth))
                {
                    var unmarshaller = FrameCaptureOutputSettingsUnmarshaller.Instance;
                    unmarshalledObject.FrameCaptureOutputSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hlsOutputSettings", targetDepth))
                {
                    var unmarshaller = HlsOutputSettingsUnmarshaller.Instance;
                    unmarshalledObject.HlsOutputSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mediaPackageOutputSettings", targetDepth))
                {
                    var unmarshaller = MediaPackageOutputSettingsUnmarshaller.Instance;
                    unmarshalledObject.MediaPackageOutputSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("msSmoothOutputSettings", targetDepth))
                {
                    var unmarshaller = MsSmoothOutputSettingsUnmarshaller.Instance;
                    unmarshalledObject.MsSmoothOutputSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("multiplexOutputSettings", targetDepth))
                {
                    var unmarshaller = MultiplexOutputSettingsUnmarshaller.Instance;
                    unmarshalledObject.MultiplexOutputSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("rtmpOutputSettings", targetDepth))
                {
                    var unmarshaller = RtmpOutputSettingsUnmarshaller.Instance;
                    unmarshalledObject.RtmpOutputSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("srtOutputSettings", targetDepth))
                {
                    var unmarshaller = SrtOutputSettingsUnmarshaller.Instance;
                    unmarshalledObject.SrtOutputSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("udpOutputSettings", targetDepth))
                {
                    var unmarshaller = UdpOutputSettingsUnmarshaller.Instance;
                    unmarshalledObject.UdpOutputSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OutputSettingsUnmarshaller _instance = new OutputSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OutputSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}