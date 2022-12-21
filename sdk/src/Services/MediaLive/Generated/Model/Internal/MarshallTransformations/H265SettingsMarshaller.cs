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
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
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

            if(requestObject.IsSetAfdSignaling())
            {
                context.Writer.WritePropertyName("afdSignaling");
                context.Writer.Write(requestObject.AfdSignaling);
            }

            if(requestObject.IsSetAlternativeTransferFunction())
            {
                context.Writer.WritePropertyName("alternativeTransferFunction");
                context.Writer.Write(requestObject.AlternativeTransferFunction);
            }

            if(requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                context.Writer.Write(requestObject.Bitrate);
            }

            if(requestObject.IsSetBufSize())
            {
                context.Writer.WritePropertyName("bufSize");
                context.Writer.Write(requestObject.BufSize);
            }

            if(requestObject.IsSetColorMetadata())
            {
                context.Writer.WritePropertyName("colorMetadata");
                context.Writer.Write(requestObject.ColorMetadata);
            }

            if(requestObject.IsSetColorSpaceSettings())
            {
                context.Writer.WritePropertyName("colorSpaceSettings");
                context.Writer.WriteObjectStart();

                var marshaller = H265ColorSpaceSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ColorSpaceSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFilterSettings())
            {
                context.Writer.WritePropertyName("filterSettings");
                context.Writer.WriteObjectStart();

                var marshaller = H265FilterSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.FilterSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFixedAfd())
            {
                context.Writer.WritePropertyName("fixedAfd");
                context.Writer.Write(requestObject.FixedAfd);
            }

            if(requestObject.IsSetFlickerAq())
            {
                context.Writer.WritePropertyName("flickerAq");
                context.Writer.Write(requestObject.FlickerAq);
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

            if(requestObject.IsSetLevel())
            {
                context.Writer.WritePropertyName("level");
                context.Writer.Write(requestObject.Level);
            }

            if(requestObject.IsSetLookAheadRateControl())
            {
                context.Writer.WritePropertyName("lookAheadRateControl");
                context.Writer.Write(requestObject.LookAheadRateControl);
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

            if(requestObject.IsSetProfile())
            {
                context.Writer.WritePropertyName("profile");
                context.Writer.Write(requestObject.Profile);
            }

            if(requestObject.IsSetQvbrQualityLevel())
            {
                context.Writer.WritePropertyName("qvbrQualityLevel");
                context.Writer.Write(requestObject.QvbrQualityLevel);
            }

            if(requestObject.IsSetRateControlMode())
            {
                context.Writer.WritePropertyName("rateControlMode");
                context.Writer.Write(requestObject.RateControlMode);
            }

            if(requestObject.IsSetScanType())
            {
                context.Writer.WritePropertyName("scanType");
                context.Writer.Write(requestObject.ScanType);
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

            if(requestObject.IsSetTier())
            {
                context.Writer.WritePropertyName("tier");
                context.Writer.Write(requestObject.Tier);
            }

            if(requestObject.IsSetTimecodeBurninSettings())
            {
                context.Writer.WritePropertyName("timecodeBurninSettings");
                context.Writer.WriteObjectStart();

                var marshaller = TimecodeBurninSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.TimecodeBurninSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimecodeInsertion())
            {
                context.Writer.WritePropertyName("timecodeInsertion");
                context.Writer.Write(requestObject.TimecodeInsertion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static H265SettingsMarshaller Instance = new H265SettingsMarshaller();

    }
}