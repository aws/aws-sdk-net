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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Mpeg2Settings Object
    /// </summary>  
    public class Mpeg2SettingsUnmarshaller : IJsonUnmarshaller<Mpeg2Settings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Mpeg2Settings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Mpeg2Settings unmarshalledObject = new Mpeg2Settings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("adaptiveQuantization", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdaptiveQuantization = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("afdSignaling", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfdSignaling = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("colorMetadata", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColorMetadata = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("colorSpace", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColorSpace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("displayAspectRatio", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayAspectRatio = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("filterSettings", targetDepth))
                {
                    var unmarshaller = Mpeg2FilterSettingsUnmarshaller.Instance;
                    unmarshalledObject.FilterSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fixedAfd", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FixedAfd = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("framerateDenominator", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.FramerateDenominator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("framerateNumerator", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.FramerateNumerator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gopClosedCadence", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.GopClosedCadence = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gopNumBFrames", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.GopNumBFrames = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gopSize", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.GopSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gopSizeUnits", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GopSizeUnits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scanType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScanType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("subgopLength", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubgopLength = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timecodeBurninSettings", targetDepth))
                {
                    var unmarshaller = TimecodeBurninSettingsUnmarshaller.Instance;
                    unmarshalledObject.TimecodeBurninSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timecodeInsertion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimecodeInsertion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static Mpeg2SettingsUnmarshaller _instance = new Mpeg2SettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static Mpeg2SettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}