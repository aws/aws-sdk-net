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
    /// Response Unmarshaller for VideoPreprocessor Object
    /// </summary>  
    public class VideoPreprocessorUnmarshaller : IJsonUnmarshaller<VideoPreprocessor, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public VideoPreprocessor Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            VideoPreprocessor unmarshalledObject = new VideoPreprocessor();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("colorCorrector", targetDepth))
                {
                    var unmarshaller = ColorCorrectorUnmarshaller.Instance;
                    unmarshalledObject.ColorCorrector = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deinterlacer", targetDepth))
                {
                    var unmarshaller = DeinterlacerUnmarshaller.Instance;
                    unmarshalledObject.Deinterlacer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dolbyVision", targetDepth))
                {
                    var unmarshaller = DolbyVisionUnmarshaller.Instance;
                    unmarshalledObject.DolbyVision = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hdr10Plus", targetDepth))
                {
                    var unmarshaller = Hdr10PlusUnmarshaller.Instance;
                    unmarshalledObject.Hdr10Plus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("imageInserter", targetDepth))
                {
                    var unmarshaller = ImageInserterUnmarshaller.Instance;
                    unmarshalledObject.ImageInserter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("noiseReducer", targetDepth))
                {
                    var unmarshaller = NoiseReducerUnmarshaller.Instance;
                    unmarshalledObject.NoiseReducer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("partnerWatermarking", targetDepth))
                {
                    var unmarshaller = PartnerWatermarkingUnmarshaller.Instance;
                    unmarshalledObject.PartnerWatermarking = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timecodeBurnin", targetDepth))
                {
                    var unmarshaller = TimecodeBurninUnmarshaller.Instance;
                    unmarshalledObject.TimecodeBurnin = unmarshaller.Unmarshall(context, ref reader);
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