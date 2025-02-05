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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IVS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.IVS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VideoConfiguration Object
    /// </summary>  
    public class VideoConfigurationUnmarshaller : IJsonUnmarshaller<VideoConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public VideoConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            VideoConfiguration unmarshalledObject = new VideoConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("avcLevel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvcLevel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("avcProfile", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvcProfile = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("codec", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Codec = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("encoder", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Encoder = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("level", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Level = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("profile", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Profile = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("targetBitrate", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.TargetBitrate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("targetFramerate", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.TargetFramerate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("track", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Track = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("videoHeight", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.VideoHeight = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("videoWidth", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.VideoWidth = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static VideoConfigurationUnmarshaller _instance = new VideoConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VideoConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}