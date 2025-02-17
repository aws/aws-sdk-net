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

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VideoOverlay Object
    /// </summary>  
    public class VideoOverlayUnmarshaller : IUnmarshaller<VideoOverlay, XmlUnmarshallerContext>, IUnmarshaller<VideoOverlay, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        VideoOverlay IUnmarshaller<VideoOverlay, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public VideoOverlay Unmarshall(JsonUnmarshallerContext context)
        {
            VideoOverlay unmarshalledObject = new VideoOverlay();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("endTimecode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndTimecode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("initialPosition", targetDepth))
                {
                    var unmarshaller = VideoOverlayPositionUnmarshaller.Instance;
                    unmarshalledObject.InitialPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("input", targetDepth))
                {
                    var unmarshaller = VideoOverlayInputUnmarshaller.Instance;
                    unmarshalledObject.Input = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("playback", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Playback = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startTimecode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartTimecode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<VideoOverlayTransition, VideoOverlayTransitionUnmarshaller>(VideoOverlayTransitionUnmarshaller.Instance);
                    unmarshalledObject.Transitions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static VideoOverlayUnmarshaller _instance = new VideoOverlayUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VideoOverlayUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}