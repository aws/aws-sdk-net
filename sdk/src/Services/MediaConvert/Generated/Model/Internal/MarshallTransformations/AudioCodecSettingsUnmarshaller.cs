/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Response Unmarshaller for AudioCodecSettings Object
    /// </summary>  
    public class AudioCodecSettingsUnmarshaller : IUnmarshaller<AudioCodecSettings, XmlUnmarshallerContext>, IUnmarshaller<AudioCodecSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AudioCodecSettings IUnmarshaller<AudioCodecSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AudioCodecSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AudioCodecSettings unmarshalledObject = new AudioCodecSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("aacSettings", targetDepth))
                {
                    var unmarshaller = AacSettingsUnmarshaller.Instance;
                    unmarshalledObject.AacSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ac3Settings", targetDepth))
                {
                    var unmarshaller = Ac3SettingsUnmarshaller.Instance;
                    unmarshalledObject.Ac3Settings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("aiffSettings", targetDepth))
                {
                    var unmarshaller = AiffSettingsUnmarshaller.Instance;
                    unmarshalledObject.AiffSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("codec", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Codec = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eac3Settings", targetDepth))
                {
                    var unmarshaller = Eac3SettingsUnmarshaller.Instance;
                    unmarshalledObject.Eac3Settings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mp2Settings", targetDepth))
                {
                    var unmarshaller = Mp2SettingsUnmarshaller.Instance;
                    unmarshalledObject.Mp2Settings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("wavSettings", targetDepth))
                {
                    var unmarshaller = WavSettingsUnmarshaller.Instance;
                    unmarshalledObject.WavSettings = unmarshaller.Unmarshall(context);
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