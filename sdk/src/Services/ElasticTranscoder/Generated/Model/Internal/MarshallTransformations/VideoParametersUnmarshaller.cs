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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VideoParameters Object
    /// </summary>  
    public class VideoParametersUnmarshaller : IJsonUnmarshaller<VideoParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public VideoParameters Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            VideoParameters unmarshalledObject = new VideoParameters();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AspectRatio", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AspectRatio = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BitRate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BitRate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Codec", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Codec = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CodecOptions", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.CodecOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DisplayAspectRatio", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayAspectRatio = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FixedGOP", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FixedGOP = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FrameRate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FrameRate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KeyframesMaxDist", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyframesMaxDist = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaxFrameRate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxFrameRate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaxHeight", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxHeight = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaxWidth", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxWidth = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PaddingPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PaddingPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Resolution", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Resolution = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SizingPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SizingPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Watermarks", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PresetWatermark, PresetWatermarkUnmarshaller>(PresetWatermarkUnmarshaller.Instance);
                    unmarshalledObject.Watermarks = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static VideoParametersUnmarshaller _instance = new VideoParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VideoParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}