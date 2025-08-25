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
    /// Response Unmarshaller for VideoSelector Object
    /// </summary>  
    public class VideoSelectorUnmarshaller : IUnmarshaller<VideoSelector, XmlUnmarshallerContext>, IUnmarshaller<VideoSelector, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        VideoSelector IUnmarshaller<VideoSelector, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public VideoSelector Unmarshall(JsonUnmarshallerContext context)
        {
            VideoSelector unmarshalledObject = new VideoSelector();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("alphaBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AlphaBehavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("colorSpace", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColorSpace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("colorSpaceUsage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColorSpaceUsage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("embeddedTimecodeOverride", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EmbeddedTimecodeOverride = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hdr10Metadata", targetDepth))
                {
                    var unmarshaller = Hdr10MetadataUnmarshaller.Instance;
                    unmarshalledObject.Hdr10Metadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxLuminance", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxLuminance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("padVideo", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PadVideo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Pid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("programNumber", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ProgramNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rotate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Rotate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sampleRange", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SampleRange = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("selectorType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SelectorType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("streams", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.Streams = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static VideoSelectorUnmarshaller _instance = new VideoSelectorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VideoSelectorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}