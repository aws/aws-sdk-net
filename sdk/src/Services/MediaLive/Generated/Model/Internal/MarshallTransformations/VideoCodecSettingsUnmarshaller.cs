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
    /// Response Unmarshaller for VideoCodecSettings Object
    /// </summary>  
    public class VideoCodecSettingsUnmarshaller : IJsonUnmarshaller<VideoCodecSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public VideoCodecSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            VideoCodecSettings unmarshalledObject = new VideoCodecSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("av1Settings", targetDepth))
                {
                    var unmarshaller = Av1SettingsUnmarshaller.Instance;
                    unmarshalledObject.Av1Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("frameCaptureSettings", targetDepth))
                {
                    var unmarshaller = FrameCaptureSettingsUnmarshaller.Instance;
                    unmarshalledObject.FrameCaptureSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("h264Settings", targetDepth))
                {
                    var unmarshaller = H264SettingsUnmarshaller.Instance;
                    unmarshalledObject.H264Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("h265Settings", targetDepth))
                {
                    var unmarshaller = H265SettingsUnmarshaller.Instance;
                    unmarshalledObject.H265Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mpeg2Settings", targetDepth))
                {
                    var unmarshaller = Mpeg2SettingsUnmarshaller.Instance;
                    unmarshalledObject.Mpeg2Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static VideoCodecSettingsUnmarshaller _instance = new VideoCodecSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VideoCodecSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}