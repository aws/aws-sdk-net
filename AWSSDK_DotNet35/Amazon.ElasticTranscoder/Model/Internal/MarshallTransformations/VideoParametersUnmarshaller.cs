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
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VideoParameters Object
    /// </summary>  
    public class VideoParametersUnmarshaller : IUnmarshaller<VideoParameters, XmlUnmarshallerContext>, IUnmarshaller<VideoParameters, JsonUnmarshallerContext>
    {
        VideoParameters IUnmarshaller<VideoParameters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public VideoParameters Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            VideoParameters unmarshalledObject = new VideoParameters();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AspectRatio", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AspectRatio = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BitRate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BitRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Codec", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Codec = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CodecOptions", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.CodecOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisplayAspectRatio", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayAspectRatio = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FixedGOP", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FixedGOP = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FrameRate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FrameRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyframesMaxDist", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyframesMaxDist = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxFrameRate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxFrameRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxHeight", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxHeight = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxWidth", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxWidth = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PaddingPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PaddingPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Resolution", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Resolution = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SizingPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SizingPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Watermarks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PresetWatermark, PresetWatermarkUnmarshaller>(PresetWatermarkUnmarshaller.Instance);
                    unmarshalledObject.Watermarks = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static VideoParametersUnmarshaller _instance = new VideoParametersUnmarshaller();        

        public static VideoParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}