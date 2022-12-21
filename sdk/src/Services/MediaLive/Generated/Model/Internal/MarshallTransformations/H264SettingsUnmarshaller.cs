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
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for H264Settings Object
    /// </summary>  
    public class H264SettingsUnmarshaller : IUnmarshaller<H264Settings, XmlUnmarshallerContext>, IUnmarshaller<H264Settings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        H264Settings IUnmarshaller<H264Settings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public H264Settings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            H264Settings unmarshalledObject = new H264Settings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("adaptiveQuantization", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdaptiveQuantization = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("afdSignaling", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfdSignaling = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bitrate", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Bitrate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bufFillPct", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BufFillPct = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bufSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BufSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("colorMetadata", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColorMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("colorSpaceSettings", targetDepth))
                {
                    var unmarshaller = H264ColorSpaceSettingsUnmarshaller.Instance;
                    unmarshalledObject.ColorSpaceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("entropyEncoding", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntropyEncoding = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("filterSettings", targetDepth))
                {
                    var unmarshaller = H264FilterSettingsUnmarshaller.Instance;
                    unmarshalledObject.FilterSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fixedAfd", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FixedAfd = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("flickerAq", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FlickerAq = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("forceFieldPictures", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ForceFieldPictures = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("framerateControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FramerateControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("framerateDenominator", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FramerateDenominator = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("framerateNumerator", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FramerateNumerator = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gopBReference", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GopBReference = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gopClosedCadence", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.GopClosedCadence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gopNumBFrames", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.GopNumBFrames = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gopSize", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.GopSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gopSizeUnits", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GopSizeUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("level", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Level = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lookAheadRateControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LookAheadRateControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxBitrate", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxBitrate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minIInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinIInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numRefFrames", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumRefFrames = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parDenominator", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ParDenominator = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parNumerator", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ParNumerator = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("profile", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Profile = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("qualityLevel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QualityLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("qvbrQualityLevel", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.QvbrQualityLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rateControlMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RateControlMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scanType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScanType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sceneChangeDetect", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SceneChangeDetect = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("slices", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Slices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("softness", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Softness = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("spatialAq", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SpatialAq = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("subgopLength", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubgopLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("syntax", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Syntax = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("temporalAq", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemporalAq = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timecodeBurninSettings", targetDepth))
                {
                    var unmarshaller = TimecodeBurninSettingsUnmarshaller.Instance;
                    unmarshalledObject.TimecodeBurninSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timecodeInsertion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimecodeInsertion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static H264SettingsUnmarshaller _instance = new H264SettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static H264SettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}