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
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VideoCodecSettings Object
    /// </summary>  
    public class VideoCodecSettingsUnmarshaller : IUnmarshaller<VideoCodecSettings, XmlUnmarshallerContext>, IUnmarshaller<VideoCodecSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        VideoCodecSettings IUnmarshaller<VideoCodecSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VideoCodecSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            VideoCodecSettings unmarshalledObject = new VideoCodecSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("av1Settings", targetDepth))
                {
                    var unmarshaller = Av1SettingsUnmarshaller.Instance;
                    unmarshalledObject.Av1Settings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("avcIntraSettings", targetDepth))
                {
                    var unmarshaller = AvcIntraSettingsUnmarshaller.Instance;
                    unmarshalledObject.AvcIntraSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("codec", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Codec = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("frameCaptureSettings", targetDepth))
                {
                    var unmarshaller = FrameCaptureSettingsUnmarshaller.Instance;
                    unmarshalledObject.FrameCaptureSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("h264Settings", targetDepth))
                {
                    var unmarshaller = H264SettingsUnmarshaller.Instance;
                    unmarshalledObject.H264Settings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("h265Settings", targetDepth))
                {
                    var unmarshaller = H265SettingsUnmarshaller.Instance;
                    unmarshalledObject.H265Settings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mpeg2Settings", targetDepth))
                {
                    var unmarshaller = Mpeg2SettingsUnmarshaller.Instance;
                    unmarshalledObject.Mpeg2Settings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("proresSettings", targetDepth))
                {
                    var unmarshaller = ProresSettingsUnmarshaller.Instance;
                    unmarshalledObject.ProresSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vc3Settings", targetDepth))
                {
                    var unmarshaller = Vc3SettingsUnmarshaller.Instance;
                    unmarshalledObject.Vc3Settings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vp8Settings", targetDepth))
                {
                    var unmarshaller = Vp8SettingsUnmarshaller.Instance;
                    unmarshalledObject.Vp8Settings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vp9Settings", targetDepth))
                {
                    var unmarshaller = Vp9SettingsUnmarshaller.Instance;
                    unmarshalledObject.Vp9Settings = unmarshaller.Unmarshall(context);
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