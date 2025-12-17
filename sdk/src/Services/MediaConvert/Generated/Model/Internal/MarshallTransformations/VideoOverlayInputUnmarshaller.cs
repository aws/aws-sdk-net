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
    /// Response Unmarshaller for VideoOverlayInput Object
    /// </summary>  
    public class VideoOverlayInputUnmarshaller : IUnmarshaller<VideoOverlayInput, XmlUnmarshallerContext>, IUnmarshaller<VideoOverlayInput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        VideoOverlayInput IUnmarshaller<VideoOverlayInput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public VideoOverlayInput Unmarshall(JsonUnmarshallerContext context)
        {
            VideoOverlayInput unmarshalledObject = new VideoOverlayInput();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("audioSelectors", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, AudioSelector, StringUnmarshaller, AudioSelectorUnmarshaller>(StringUnmarshaller.Instance, AudioSelectorUnmarshaller.Instance);
                    unmarshalledObject.AudioSelectors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileInput", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FileInput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputClippings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<VideoOverlayInputClipping, VideoOverlayInputClippingUnmarshaller>(VideoOverlayInputClippingUnmarshaller.Instance);
                    unmarshalledObject.InputClippings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timecodeSource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimecodeSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timecodeStart", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimecodeStart = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static VideoOverlayInputUnmarshaller _instance = new VideoOverlayInputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VideoOverlayInputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}