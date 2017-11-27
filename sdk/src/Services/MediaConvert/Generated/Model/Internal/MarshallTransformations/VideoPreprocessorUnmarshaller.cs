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
    /// Response Unmarshaller for VideoPreprocessor Object
    /// </summary>  
    public class VideoPreprocessorUnmarshaller : IUnmarshaller<VideoPreprocessor, XmlUnmarshallerContext>, IUnmarshaller<VideoPreprocessor, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        VideoPreprocessor IUnmarshaller<VideoPreprocessor, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VideoPreprocessor Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            VideoPreprocessor unmarshalledObject = new VideoPreprocessor();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("colorCorrector", targetDepth))
                {
                    var unmarshaller = ColorCorrectorUnmarshaller.Instance;
                    unmarshalledObject.ColorCorrector = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deinterlacer", targetDepth))
                {
                    var unmarshaller = DeinterlacerUnmarshaller.Instance;
                    unmarshalledObject.Deinterlacer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageInserter", targetDepth))
                {
                    var unmarshaller = ImageInserterUnmarshaller.Instance;
                    unmarshalledObject.ImageInserter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("noiseReducer", targetDepth))
                {
                    var unmarshaller = NoiseReducerUnmarshaller.Instance;
                    unmarshalledObject.NoiseReducer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timecodeBurnin", targetDepth))
                {
                    var unmarshaller = TimecodeBurninUnmarshaller.Instance;
                    unmarshalledObject.TimecodeBurnin = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static VideoPreprocessorUnmarshaller _instance = new VideoPreprocessorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VideoPreprocessorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}