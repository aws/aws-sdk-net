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
    /// Mpeg2Settings Marshaller
    /// </summary>
    public class Mpeg2SettingsMarshaller : IRequestMarshaller<Mpeg2Settings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Mpeg2Settings requestObject, JsonMarshallerContext context)
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

            if(requestObject.IsSetColorMetadata())
            {
                context.Writer.WritePropertyName("colorMetadata");
                context.Writer.Write(requestObject.ColorMetadata);
            }

            if(requestObject.IsSetColorSpace())
            {
                context.Writer.WritePropertyName("colorSpace");
                context.Writer.Write(requestObject.ColorSpace);
            }

            if(requestObject.IsSetDisplayAspectRatio())
            {
                context.Writer.WritePropertyName("displayAspectRatio");
                context.Writer.Write(requestObject.DisplayAspectRatio);
            }

            if(requestObject.IsSetFilterSettings())
            {
                context.Writer.WritePropertyName("filterSettings");
                context.Writer.WriteObjectStart();

                var marshaller = Mpeg2FilterSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.FilterSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFixedAfd())
            {
                context.Writer.WritePropertyName("fixedAfd");
                context.Writer.Write(requestObject.FixedAfd);
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

            if(requestObject.IsSetGopNumBFrames())
            {
                context.Writer.WritePropertyName("gopNumBFrames");
                context.Writer.Write(requestObject.GopNumBFrames);
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

            if(requestObject.IsSetScanType())
            {
                context.Writer.WritePropertyName("scanType");
                context.Writer.Write(requestObject.ScanType);
            }

            if(requestObject.IsSetSubgopLength())
            {
                context.Writer.WritePropertyName("subgopLength");
                context.Writer.Write(requestObject.SubgopLength);
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
        public readonly static Mpeg2SettingsMarshaller Instance = new Mpeg2SettingsMarshaller();

    }
}