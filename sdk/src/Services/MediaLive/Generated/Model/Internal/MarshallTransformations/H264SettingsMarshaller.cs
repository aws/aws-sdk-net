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
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// H264Settings Marshaller
    /// </summary>
    public class H264SettingsMarshaller : IRequestMarshaller<H264Settings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(H264Settings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdaptiveQuantization())
            {
                context.Writer.WritePropertyName("adaptiveQuantization");
                context.Writer.WriteStringValue(requestObject.AdaptiveQuantization);
            }

            if(requestObject.IsSetAfdSignaling())
            {
                context.Writer.WritePropertyName("afdSignaling");
                context.Writer.WriteStringValue(requestObject.AfdSignaling);
            }

            if(requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                context.Writer.WriteNumberValue(requestObject.Bitrate.Value);
            }

            if(requestObject.IsSetBufFillPct())
            {
                context.Writer.WritePropertyName("bufFillPct");
                context.Writer.WriteNumberValue(requestObject.BufFillPct.Value);
            }

            if(requestObject.IsSetBufSize())
            {
                context.Writer.WritePropertyName("bufSize");
                context.Writer.WriteNumberValue(requestObject.BufSize.Value);
            }

            if(requestObject.IsSetColorMetadata())
            {
                context.Writer.WritePropertyName("colorMetadata");
                context.Writer.WriteStringValue(requestObject.ColorMetadata);
            }

            if(requestObject.IsSetColorSpaceSettings())
            {
                context.Writer.WritePropertyName("colorSpaceSettings");
                context.Writer.WriteStartObject();

                var marshaller = H264ColorSpaceSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ColorSpaceSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEntropyEncoding())
            {
                context.Writer.WritePropertyName("entropyEncoding");
                context.Writer.WriteStringValue(requestObject.EntropyEncoding);
            }

            if(requestObject.IsSetFilterSettings())
            {
                context.Writer.WritePropertyName("filterSettings");
                context.Writer.WriteStartObject();

                var marshaller = H264FilterSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.FilterSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFixedAfd())
            {
                context.Writer.WritePropertyName("fixedAfd");
                context.Writer.WriteStringValue(requestObject.FixedAfd);
            }

            if(requestObject.IsSetFlickerAq())
            {
                context.Writer.WritePropertyName("flickerAq");
                context.Writer.WriteStringValue(requestObject.FlickerAq);
            }

            if(requestObject.IsSetForceFieldPictures())
            {
                context.Writer.WritePropertyName("forceFieldPictures");
                context.Writer.WriteStringValue(requestObject.ForceFieldPictures);
            }

            if(requestObject.IsSetFramerateControl())
            {
                context.Writer.WritePropertyName("framerateControl");
                context.Writer.WriteStringValue(requestObject.FramerateControl);
            }

            if(requestObject.IsSetFramerateDenominator())
            {
                context.Writer.WritePropertyName("framerateDenominator");
                context.Writer.WriteNumberValue(requestObject.FramerateDenominator.Value);
            }

            if(requestObject.IsSetFramerateNumerator())
            {
                context.Writer.WritePropertyName("framerateNumerator");
                context.Writer.WriteNumberValue(requestObject.FramerateNumerator.Value);
            }

            if(requestObject.IsSetGopBReference())
            {
                context.Writer.WritePropertyName("gopBReference");
                context.Writer.WriteStringValue(requestObject.GopBReference);
            }

            if(requestObject.IsSetGopClosedCadence())
            {
                context.Writer.WritePropertyName("gopClosedCadence");
                context.Writer.WriteNumberValue(requestObject.GopClosedCadence.Value);
            }

            if(requestObject.IsSetGopNumBFrames())
            {
                context.Writer.WritePropertyName("gopNumBFrames");
                context.Writer.WriteNumberValue(requestObject.GopNumBFrames.Value);
            }

            if(requestObject.IsSetGopSize())
            {
                context.Writer.WritePropertyName("gopSize");
                if(StringUtils.IsSpecialDoubleValue(requestObject.GopSize.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.GopSize.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.GopSize.Value);
                }
            }

            if(requestObject.IsSetGopSizeUnits())
            {
                context.Writer.WritePropertyName("gopSizeUnits");
                context.Writer.WriteStringValue(requestObject.GopSizeUnits);
            }

            if(requestObject.IsSetLevel())
            {
                context.Writer.WritePropertyName("level");
                context.Writer.WriteStringValue(requestObject.Level);
            }

            if(requestObject.IsSetLookAheadRateControl())
            {
                context.Writer.WritePropertyName("lookAheadRateControl");
                context.Writer.WriteStringValue(requestObject.LookAheadRateControl);
            }

            if(requestObject.IsSetMaxBitrate())
            {
                context.Writer.WritePropertyName("maxBitrate");
                context.Writer.WriteNumberValue(requestObject.MaxBitrate.Value);
            }

            if(requestObject.IsSetMinBitrate())
            {
                context.Writer.WritePropertyName("minBitrate");
                context.Writer.WriteNumberValue(requestObject.MinBitrate.Value);
            }

            if(requestObject.IsSetMinIInterval())
            {
                context.Writer.WritePropertyName("minIInterval");
                context.Writer.WriteNumberValue(requestObject.MinIInterval.Value);
            }

            if(requestObject.IsSetMinQp())
            {
                context.Writer.WritePropertyName("minQp");
                context.Writer.WriteNumberValue(requestObject.MinQp.Value);
            }

            if(requestObject.IsSetNumRefFrames())
            {
                context.Writer.WritePropertyName("numRefFrames");
                context.Writer.WriteNumberValue(requestObject.NumRefFrames.Value);
            }

            if(requestObject.IsSetParControl())
            {
                context.Writer.WritePropertyName("parControl");
                context.Writer.WriteStringValue(requestObject.ParControl);
            }

            if(requestObject.IsSetParDenominator())
            {
                context.Writer.WritePropertyName("parDenominator");
                context.Writer.WriteNumberValue(requestObject.ParDenominator.Value);
            }

            if(requestObject.IsSetParNumerator())
            {
                context.Writer.WritePropertyName("parNumerator");
                context.Writer.WriteNumberValue(requestObject.ParNumerator.Value);
            }

            if(requestObject.IsSetProfile())
            {
                context.Writer.WritePropertyName("profile");
                context.Writer.WriteStringValue(requestObject.Profile);
            }

            if(requestObject.IsSetQualityLevel())
            {
                context.Writer.WritePropertyName("qualityLevel");
                context.Writer.WriteStringValue(requestObject.QualityLevel);
            }

            if(requestObject.IsSetQvbrQualityLevel())
            {
                context.Writer.WritePropertyName("qvbrQualityLevel");
                context.Writer.WriteNumberValue(requestObject.QvbrQualityLevel.Value);
            }

            if(requestObject.IsSetRateControlMode())
            {
                context.Writer.WritePropertyName("rateControlMode");
                context.Writer.WriteStringValue(requestObject.RateControlMode);
            }

            if(requestObject.IsSetScanType())
            {
                context.Writer.WritePropertyName("scanType");
                context.Writer.WriteStringValue(requestObject.ScanType);
            }

            if(requestObject.IsSetSceneChangeDetect())
            {
                context.Writer.WritePropertyName("sceneChangeDetect");
                context.Writer.WriteStringValue(requestObject.SceneChangeDetect);
            }

            if(requestObject.IsSetSlices())
            {
                context.Writer.WritePropertyName("slices");
                context.Writer.WriteNumberValue(requestObject.Slices.Value);
            }

            if(requestObject.IsSetSoftness())
            {
                context.Writer.WritePropertyName("softness");
                context.Writer.WriteNumberValue(requestObject.Softness.Value);
            }

            if(requestObject.IsSetSpatialAq())
            {
                context.Writer.WritePropertyName("spatialAq");
                context.Writer.WriteStringValue(requestObject.SpatialAq);
            }

            if(requestObject.IsSetSubgopLength())
            {
                context.Writer.WritePropertyName("subgopLength");
                context.Writer.WriteStringValue(requestObject.SubgopLength);
            }

            if(requestObject.IsSetSyntax())
            {
                context.Writer.WritePropertyName("syntax");
                context.Writer.WriteStringValue(requestObject.Syntax);
            }

            if(requestObject.IsSetTemporalAq())
            {
                context.Writer.WritePropertyName("temporalAq");
                context.Writer.WriteStringValue(requestObject.TemporalAq);
            }

            if(requestObject.IsSetTimecodeBurninSettings())
            {
                context.Writer.WritePropertyName("timecodeBurninSettings");
                context.Writer.WriteStartObject();

                var marshaller = TimecodeBurninSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.TimecodeBurninSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimecodeInsertion())
            {
                context.Writer.WritePropertyName("timecodeInsertion");
                context.Writer.WriteStringValue(requestObject.TimecodeInsertion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static H264SettingsMarshaller Instance = new H264SettingsMarshaller();

    }
}