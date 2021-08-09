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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SegmentDetection Object
    /// </summary>  
    public class SegmentDetectionUnmarshaller : IUnmarshaller<SegmentDetection, XmlUnmarshallerContext>, IUnmarshaller<SegmentDetection, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SegmentDetection IUnmarshaller<SegmentDetection, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SegmentDetection Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SegmentDetection unmarshalledObject = new SegmentDetection();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DurationFrames", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.DurationFrames = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DurationMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.DurationMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DurationSMPTE", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DurationSMPTE = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndFrameNumber", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.EndFrameNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndTimecodeSMPTE", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndTimecodeSMPTE = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndTimestampMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.EndTimestampMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShotSegment", targetDepth))
                {
                    var unmarshaller = ShotSegmentUnmarshaller.Instance;
                    unmarshalledObject.ShotSegment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartFrameNumber", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.StartFrameNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTimecodeSMPTE", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartTimecodeSMPTE = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTimestampMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.StartTimestampMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TechnicalCueSegment", targetDepth))
                {
                    var unmarshaller = TechnicalCueSegmentUnmarshaller.Instance;
                    unmarshalledObject.TechnicalCueSegment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SegmentDetectionUnmarshaller _instance = new SegmentDetectionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SegmentDetectionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}