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
    /// Response Unmarshaller for H264Settings Object
    /// </summary>  
    public class H264SettingsUnmarshaller : IJsonUnmarshaller<H264Settings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public H264Settings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            H264Settings unmarshalledObject = new H264Settings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("adaptiveQuantization", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdaptiveQuantization = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("bandwidthReductionFilter", targetDepth, ref reader))
                {
                    var unmarshaller = BandwidthReductionFilterUnmarshaller.Instance;
                    unmarshalledObject.BandwidthReductionFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("bitrate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Bitrate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("codecLevel", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CodecLevel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("codecProfile", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CodecProfile = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dynamicSubGop", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DynamicSubGop = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("endOfStreamMarkers", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndOfStreamMarkers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("entropyEncoding", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntropyEncoding = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fieldEncoding", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FieldEncoding = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("flickerAdaptiveQuantization", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FlickerAdaptiveQuantization = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("framerateControl", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FramerateControl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("framerateConversionAlgorithm", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FramerateConversionAlgorithm = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("framerateDenominator", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.FramerateDenominator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("framerateNumerator", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.FramerateNumerator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gopBReference", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GopBReference = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gopClosedCadence", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.GopClosedCadence = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gopSize", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.GopSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gopSizeUnits", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GopSizeUnits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hrdBufferFinalFillPercentage", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.HrdBufferFinalFillPercentage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hrdBufferInitialFillPercentage", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.HrdBufferInitialFillPercentage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hrdBufferSize", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.HrdBufferSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("interlaceMode", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InterlaceMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("maxBitrate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MaxBitrate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("minIInterval", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MinIInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("numberBFramesBetweenReferenceFrames", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.NumberBFramesBetweenReferenceFrames = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("numberReferenceFrames", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.NumberReferenceFrames = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parControl", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParControl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parDenominator", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ParDenominator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parNumerator", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ParNumerator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("perFrameMetrics", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PerFrameMetrics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("qualityTuningLevel", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QualityTuningLevel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("qvbrSettings", targetDepth, ref reader))
                {
                    var unmarshaller = H264QvbrSettingsUnmarshaller.Instance;
                    unmarshalledObject.QvbrSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("rateControlMode", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RateControlMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("repeatPps", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RepeatPps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("saliencyAwareEncoding", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SaliencyAwareEncoding = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scanTypeConversionMode", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScanTypeConversionMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sceneChangeDetect", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SceneChangeDetect = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("slices", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Slices = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("slowPal", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SlowPal = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("softness", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Softness = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("spatialAdaptiveQuantization", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SpatialAdaptiveQuantization = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("syntax", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Syntax = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("telecine", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Telecine = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("temporalAdaptiveQuantization", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemporalAdaptiveQuantization = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unregisteredSeiTimecode", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UnregisteredSeiTimecode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("writeMp4PackagingType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WriteMp4PackagingType = unmarshaller.Unmarshall(context, ref reader);
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