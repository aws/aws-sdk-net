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
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Ac4Settings Marshaller
    /// </summary>
    public class Ac4SettingsMarshaller : IRequestMarshaller<Ac4Settings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Ac4Settings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                context.Writer.WriteNumberValue(requestObject.Bitrate.Value);
            }

            if(requestObject.IsSetBitstreamMode())
            {
                context.Writer.WritePropertyName("bitstreamMode");
                context.Writer.WriteStringValue(requestObject.BitstreamMode);
            }

            if(requestObject.IsSetCodingMode())
            {
                context.Writer.WritePropertyName("codingMode");
                context.Writer.WriteStringValue(requestObject.CodingMode);
            }

            if(requestObject.IsSetDynamicRangeCompressionFlatPanelTv())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionFlatPanelTv");
                context.Writer.WriteStringValue(requestObject.DynamicRangeCompressionFlatPanelTv);
            }

            if(requestObject.IsSetDynamicRangeCompressionHomeTheater())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionHomeTheater");
                context.Writer.WriteStringValue(requestObject.DynamicRangeCompressionHomeTheater);
            }

            if(requestObject.IsSetDynamicRangeCompressionPortableHeadphones())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionPortableHeadphones");
                context.Writer.WriteStringValue(requestObject.DynamicRangeCompressionPortableHeadphones);
            }

            if(requestObject.IsSetDynamicRangeCompressionPortableSpeakers())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionPortableSpeakers");
                context.Writer.WriteStringValue(requestObject.DynamicRangeCompressionPortableSpeakers);
            }

            if(requestObject.IsSetLoRoCenterMixLevel())
            {
                context.Writer.WritePropertyName("loRoCenterMixLevel");
                if(StringUtils.IsSpecialDoubleValue(requestObject.LoRoCenterMixLevel.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.LoRoCenterMixLevel.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.LoRoCenterMixLevel.Value);
                }
            }

            if(requestObject.IsSetLoRoSurroundMixLevel())
            {
                context.Writer.WritePropertyName("loRoSurroundMixLevel");
                if(StringUtils.IsSpecialDoubleValue(requestObject.LoRoSurroundMixLevel.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.LoRoSurroundMixLevel.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.LoRoSurroundMixLevel.Value);
                }
            }

            if(requestObject.IsSetLtRtCenterMixLevel())
            {
                context.Writer.WritePropertyName("ltRtCenterMixLevel");
                if(StringUtils.IsSpecialDoubleValue(requestObject.LtRtCenterMixLevel.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.LtRtCenterMixLevel.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.LtRtCenterMixLevel.Value);
                }
            }

            if(requestObject.IsSetLtRtSurroundMixLevel())
            {
                context.Writer.WritePropertyName("ltRtSurroundMixLevel");
                if(StringUtils.IsSpecialDoubleValue(requestObject.LtRtSurroundMixLevel.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.LtRtSurroundMixLevel.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.LtRtSurroundMixLevel.Value);
                }
            }

            if(requestObject.IsSetSampleRate())
            {
                context.Writer.WritePropertyName("sampleRate");
                context.Writer.WriteNumberValue(requestObject.SampleRate.Value);
            }

            if(requestObject.IsSetStereoDownmix())
            {
                context.Writer.WritePropertyName("stereoDownmix");
                context.Writer.WriteStringValue(requestObject.StereoDownmix);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Ac4SettingsMarshaller Instance = new Ac4SettingsMarshaller();

    }
}