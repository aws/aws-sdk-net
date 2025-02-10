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
    /// Response Unmarshaller for AudioCodecSettings Object
    /// </summary>  
    public class AudioCodecSettingsUnmarshaller : IJsonUnmarshaller<AudioCodecSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AudioCodecSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AudioCodecSettings unmarshalledObject = new AudioCodecSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("aacSettings", targetDepth))
                {
                    var unmarshaller = AacSettingsUnmarshaller.Instance;
                    unmarshalledObject.AacSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ac3Settings", targetDepth))
                {
                    var unmarshaller = Ac3SettingsUnmarshaller.Instance;
                    unmarshalledObject.Ac3Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("aiffSettings", targetDepth))
                {
                    var unmarshaller = AiffSettingsUnmarshaller.Instance;
                    unmarshalledObject.AiffSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("codec", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Codec = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("eac3AtmosSettings", targetDepth))
                {
                    var unmarshaller = Eac3AtmosSettingsUnmarshaller.Instance;
                    unmarshalledObject.Eac3AtmosSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("eac3Settings", targetDepth))
                {
                    var unmarshaller = Eac3SettingsUnmarshaller.Instance;
                    unmarshalledObject.Eac3Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("flacSettings", targetDepth))
                {
                    var unmarshaller = FlacSettingsUnmarshaller.Instance;
                    unmarshalledObject.FlacSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mp2Settings", targetDepth))
                {
                    var unmarshaller = Mp2SettingsUnmarshaller.Instance;
                    unmarshalledObject.Mp2Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mp3Settings", targetDepth))
                {
                    var unmarshaller = Mp3SettingsUnmarshaller.Instance;
                    unmarshalledObject.Mp3Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("opusSettings", targetDepth))
                {
                    var unmarshaller = OpusSettingsUnmarshaller.Instance;
                    unmarshalledObject.OpusSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("vorbisSettings", targetDepth))
                {
                    var unmarshaller = VorbisSettingsUnmarshaller.Instance;
                    unmarshalledObject.VorbisSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("wavSettings", targetDepth))
                {
                    var unmarshaller = WavSettingsUnmarshaller.Instance;
                    unmarshalledObject.WavSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AudioCodecSettingsUnmarshaller _instance = new AudioCodecSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AudioCodecSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}