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
    /// H265Settings Marshaller
    /// </summary>       
    public class H265SettingsMarshaller : IRequestMarshaller<H265Settings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(H265Settings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAdaptiveQuantization())
            {
                context.Writer.WritePropertyName("adaptiveQuantization");
                context.Writer.Write(requestObject.AdaptiveQuantization);
            }

            if(requestObject.IsSetAlternateTransferFunctionSei())
            {
                context.Writer.WritePropertyName("alternateTransferFunctionSei");
                context.Writer.Write(requestObject.AlternateTransferFunctionSei);
            }

            if(requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                context.Writer.Write(requestObject.Bitrate);
            }

            if(requestObject.IsSetCodecLevel())
            {
                context.Writer.WritePropertyName("codecLevel");
                context.Writer.Write(requestObject.CodecLevel);
            }

            if(requestObject.IsSetCodecProfile())
            {
                context.Writer.WritePropertyName("codecProfile");
                context.Writer.Write(requestObject.CodecProfile);
            }

            if(requestObject.IsSetFlickerAdaptiveQuantization())
            {
                context.Writer.WritePropertyName("flickerAdaptiveQuantization");
                context.Writer.Write(requestObject.FlickerAdaptiveQuantization);
            }

            if(requestObject.IsSetFramerateControl())
            {
                context.Writer.WritePropertyName("framerateControl");
                context.Writer.Write(requestObject.FramerateControl);
            }

            if(requestObject.IsSetFramerateConversionAlgorithm())
            {
                context.Writer.WritePropertyName("framerateConversionAlgorithm");
                context.Writer.Write(requestObject.FramerateConversionAlgorithm);
            }

            if(requestObject.IsSetFramerateDenominator())
            {
                context.Writer.WritePropertyName("framerateDenominator");
                context.Writer.Write(requestObject.FramerateDenominator);
            }

            if(requestObject.IsSetFramerateNumerator())
            {
                context.Writer.WritePropertyName("framerateNumerator");
                context.Writer.Write(requestObject.FramerateNumerator);
            }

            if(requestObject.IsSetGopBReference())
            {
                context.Writer.WritePropertyName("gopBReference");
                context.Writer.Write(requestObject.GopBReference);
            }

            if(requestObject.IsSetGopClosedCadence())
            {
                context.Writer.WritePropertyName("gopClosedCadence");
                context.Writer.Write(requestObject.GopClosedCadence);
            }

            if(requestObject.IsSetGopSize())
            {
                context.Writer.WritePropertyName("gopSize");
                context.Writer.Write(requestObject.GopSize);
            }

            if(requestObject.IsSetGopSizeUnits())
            {
                context.Writer.WritePropertyName("gopSizeUnits");
                context.Writer.Write(requestObject.GopSizeUnits);
            }

            if(requestObject.IsSetHrdBufferInitialFillPercentage())
            {
                context.Writer.WritePropertyName("hrdBufferInitialFillPercentage");
                context.Writer.Write(requestObject.HrdBufferInitialFillPercentage);
            }

            if(requestObject.IsSetHrdBufferSize())
            {
                context.Writer.WritePropertyName("hrdBufferSize");
                context.Writer.Write(requestObject.HrdBufferSize);
            }

            if(requestObject.IsSetInterlaceMode())
            {
                context.Writer.WritePropertyName("interlaceMode");
                context.Writer.Write(requestObject.InterlaceMode);
            }

            if(requestObject.IsSetMaxBitrate())
            {
                context.Writer.WritePropertyName("maxBitrate");
                context.Writer.Write(requestObject.MaxBitrate);
            }

            if(requestObject.IsSetMinIInterval())
            {
                context.Writer.WritePropertyName("minIInterval");
                context.Writer.Write(requestObject.MinIInterval);
            }

            if(requestObject.IsSetNumberBFramesBetweenReferenceFrames())
            {
                context.Writer.WritePropertyName("numberBFramesBetweenReferenceFrames");
                context.Writer.Write(requestObject.NumberBFramesBetweenReferenceFrames);
            }

            if(requestObject.IsSetNumberReferenceFrames())
            {
                context.Writer.WritePropertyName("numberReferenceFrames");
                context.Writer.Write(requestObject.NumberReferenceFrames);
            }

            if(requestObject.IsSetParControl())
            {
                context.Writer.WritePropertyName("parControl");
                context.Writer.Write(requestObject.ParControl);
            }

            if(requestObject.IsSetParDenominator())
            {
                context.Writer.WritePropertyName("parDenominator");
                context.Writer.Write(requestObject.ParDenominator);
            }

            if(requestObject.IsSetParNumerator())
            {
                context.Writer.WritePropertyName("parNumerator");
                context.Writer.Write(requestObject.ParNumerator);
            }

            if(requestObject.IsSetQualityTuningLevel())
            {
                context.Writer.WritePropertyName("qualityTuningLevel");
                context.Writer.Write(requestObject.QualityTuningLevel);
            }

            if(requestObject.IsSetRateControlMode())
            {
                context.Writer.WritePropertyName("rateControlMode");
                context.Writer.Write(requestObject.RateControlMode);
            }

            if(requestObject.IsSetSampleAdaptiveOffsetFilterMode())
            {
                context.Writer.WritePropertyName("sampleAdaptiveOffsetFilterMode");
                context.Writer.Write(requestObject.SampleAdaptiveOffsetFilterMode);
            }

            if(requestObject.IsSetSceneChangeDetect())
            {
                context.Writer.WritePropertyName("sceneChangeDetect");
                context.Writer.Write(requestObject.SceneChangeDetect);
            }

            if(requestObject.IsSetSlices())
            {
                context.Writer.WritePropertyName("slices");
                context.Writer.Write(requestObject.Slices);
            }

            if(requestObject.IsSetSlowPal())
            {
                context.Writer.WritePropertyName("slowPal");
                context.Writer.Write(requestObject.SlowPal);
            }

            if(requestObject.IsSetSpatialAdaptiveQuantization())
            {
                context.Writer.WritePropertyName("spatialAdaptiveQuantization");
                context.Writer.Write(requestObject.SpatialAdaptiveQuantization);
            }

            if(requestObject.IsSetTelecine())
            {
                context.Writer.WritePropertyName("telecine");
                context.Writer.Write(requestObject.Telecine);
            }

            if(requestObject.IsSetTemporalAdaptiveQuantization())
            {
                context.Writer.WritePropertyName("temporalAdaptiveQuantization");
                context.Writer.Write(requestObject.TemporalAdaptiveQuantization);
            }

            if(requestObject.IsSetTemporalIds())
            {
                context.Writer.WritePropertyName("temporalIds");
                context.Writer.Write(requestObject.TemporalIds);
            }

            if(requestObject.IsSetTiles())
            {
                context.Writer.WritePropertyName("tiles");
                context.Writer.Write(requestObject.Tiles);
            }

            if(requestObject.IsSetUnregisteredSeiTimecode())
            {
                context.Writer.WritePropertyName("unregisteredSeiTimecode");
                context.Writer.Write(requestObject.UnregisteredSeiTimecode);
            }

            if(requestObject.IsSetWriteMp4PackagingType())
            {
                context.Writer.WritePropertyName("writeMp4PackagingType");
                context.Writer.Write(requestObject.WriteMp4PackagingType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static H265SettingsMarshaller Instance = new H265SettingsMarshaller();

    }
}