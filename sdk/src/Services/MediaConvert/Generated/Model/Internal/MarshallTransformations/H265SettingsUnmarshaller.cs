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
    /// Response Unmarshaller for H265Settings Object
    /// </summary>  
    public class H265SettingsUnmarshaller : IUnmarshaller<H265Settings, XmlUnmarshallerContext>, IUnmarshaller<H265Settings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        H265Settings IUnmarshaller<H265Settings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public H265Settings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            H265Settings unmarshalledObject = new H265Settings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("adaptiveQuantization", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdaptiveQuantization = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("alternateTransferFunctionSei", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AlternateTransferFunctionSei = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bitrate", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Bitrate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("codecLevel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CodecLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("codecProfile", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CodecProfile = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("flickerAdaptiveQuantization", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FlickerAdaptiveQuantization = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("framerateControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FramerateControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("framerateConversionAlgorithm", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FramerateConversionAlgorithm = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("hrdBufferInitialFillPercentage", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.HrdBufferInitialFillPercentage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hrdBufferSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.HrdBufferSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("interlaceMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InterlaceMode = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("numberBFramesBetweenReferenceFrames", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberBFramesBetweenReferenceFrames = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numberReferenceFrames", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberReferenceFrames = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("qualityTuningLevel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QualityTuningLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rateControlMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RateControlMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sampleAdaptiveOffsetFilterMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SampleAdaptiveOffsetFilterMode = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("slowPal", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SlowPal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("spatialAdaptiveQuantization", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SpatialAdaptiveQuantization = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("telecine", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Telecine = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("temporalAdaptiveQuantization", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemporalAdaptiveQuantization = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("temporalIds", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemporalIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tiles", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Tiles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("unregisteredSeiTimecode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UnregisteredSeiTimecode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("writeMp4PackagingType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WriteMp4PackagingType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static H265SettingsUnmarshaller _instance = new H265SettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static H265SettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}