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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FaceDetail Object
    /// </summary>  
    public class FaceDetailUnmarshaller : IJsonUnmarshaller<FaceDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public FaceDetail Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            FaceDetail unmarshalledObject = new FaceDetail();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AgeRange", targetDepth))
                {
                    var unmarshaller = AgeRangeUnmarshaller.Instance;
                    unmarshalledObject.AgeRange = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Beard", targetDepth))
                {
                    var unmarshaller = BeardUnmarshaller.Instance;
                    unmarshalledObject.Beard = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BoundingBox", targetDepth))
                {
                    var unmarshaller = BoundingBoxUnmarshaller.Instance;
                    unmarshalledObject.BoundingBox = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Confidence", targetDepth))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.Confidence = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Emotions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Emotion, EmotionUnmarshaller>(EmotionUnmarshaller.Instance);
                    unmarshalledObject.Emotions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EyeDirection", targetDepth))
                {
                    var unmarshaller = EyeDirectionUnmarshaller.Instance;
                    unmarshalledObject.EyeDirection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Eyeglasses", targetDepth))
                {
                    var unmarshaller = EyeglassesUnmarshaller.Instance;
                    unmarshalledObject.Eyeglasses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EyesOpen", targetDepth))
                {
                    var unmarshaller = EyeOpenUnmarshaller.Instance;
                    unmarshalledObject.EyesOpen = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FaceOccluded", targetDepth))
                {
                    var unmarshaller = FaceOccludedUnmarshaller.Instance;
                    unmarshalledObject.FaceOccluded = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Gender", targetDepth))
                {
                    var unmarshaller = GenderUnmarshaller.Instance;
                    unmarshalledObject.Gender = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Landmarks", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Landmark, LandmarkUnmarshaller>(LandmarkUnmarshaller.Instance);
                    unmarshalledObject.Landmarks = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MouthOpen", targetDepth))
                {
                    var unmarshaller = MouthOpenUnmarshaller.Instance;
                    unmarshalledObject.MouthOpen = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Mustache", targetDepth))
                {
                    var unmarshaller = MustacheUnmarshaller.Instance;
                    unmarshalledObject.Mustache = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Pose", targetDepth))
                {
                    var unmarshaller = PoseUnmarshaller.Instance;
                    unmarshalledObject.Pose = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Quality", targetDepth))
                {
                    var unmarshaller = ImageQualityUnmarshaller.Instance;
                    unmarshalledObject.Quality = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Smile", targetDepth))
                {
                    var unmarshaller = SmileUnmarshaller.Instance;
                    unmarshalledObject.Smile = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Sunglasses", targetDepth))
                {
                    var unmarshaller = SunglassesUnmarshaller.Instance;
                    unmarshalledObject.Sunglasses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FaceDetailUnmarshaller _instance = new FaceDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FaceDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}