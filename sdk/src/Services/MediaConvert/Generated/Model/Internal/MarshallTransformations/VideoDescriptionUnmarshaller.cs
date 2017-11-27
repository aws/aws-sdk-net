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
    /// Response Unmarshaller for VideoDescription Object
    /// </summary>  
    public class VideoDescriptionUnmarshaller : IUnmarshaller<VideoDescription, XmlUnmarshallerContext>, IUnmarshaller<VideoDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        VideoDescription IUnmarshaller<VideoDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VideoDescription Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            VideoDescription unmarshalledObject = new VideoDescription();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("afdSignaling", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfdSignaling = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("antiAlias", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AntiAlias = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("codecSettings", targetDepth))
                {
                    var unmarshaller = VideoCodecSettingsUnmarshaller.Instance;
                    unmarshalledObject.CodecSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("colorMetadata", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColorMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("crop", targetDepth))
                {
                    var unmarshaller = RectangleUnmarshaller.Instance;
                    unmarshalledObject.Crop = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dropFrameTimecode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DropFrameTimecode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fixedAfd", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FixedAfd = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("height", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Height = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("position", targetDepth))
                {
                    var unmarshaller = RectangleUnmarshaller.Instance;
                    unmarshalledObject.Position = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("respondToAfd", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RespondToAfd = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scalingBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScalingBehavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sharpness", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Sharpness = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timecodeInsertion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimecodeInsertion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("videoPreprocessors", targetDepth))
                {
                    var unmarshaller = VideoPreprocessorUnmarshaller.Instance;
                    unmarshalledObject.VideoPreprocessors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("width", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Width = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static VideoDescriptionUnmarshaller _instance = new VideoDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VideoDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}