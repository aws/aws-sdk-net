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
using ThirdParty.Json.LitJson;

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
                context.Writer.Write(requestObject.Bitrate);
            }

            if(requestObject.IsSetBitstreamMode())
            {
                context.Writer.WritePropertyName("bitstreamMode");
                context.Writer.Write(requestObject.BitstreamMode);
            }

            if(requestObject.IsSetCodingMode())
            {
                context.Writer.WritePropertyName("codingMode");
                context.Writer.Write(requestObject.CodingMode);
            }

            if(requestObject.IsSetDynamicRangeCompressionFlatPanelTv())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionFlatPanelTv");
                context.Writer.Write(requestObject.DynamicRangeCompressionFlatPanelTv);
            }

            if(requestObject.IsSetDynamicRangeCompressionHomeTheater())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionHomeTheater");
                context.Writer.Write(requestObject.DynamicRangeCompressionHomeTheater);
            }

            if(requestObject.IsSetDynamicRangeCompressionPortableHeadphones())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionPortableHeadphones");
                context.Writer.Write(requestObject.DynamicRangeCompressionPortableHeadphones);
            }

            if(requestObject.IsSetDynamicRangeCompressionPortableSpeakers())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionPortableSpeakers");
                context.Writer.Write(requestObject.DynamicRangeCompressionPortableSpeakers);
            }

            if(requestObject.IsSetLoRoCenterMixLevel())
            {
                context.Writer.WritePropertyName("loRoCenterMixLevel");
                if(StringUtils.IsSpecialDoubleValue(requestObject.LoRoCenterMixLevel))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.LoRoCenterMixLevel));
                }
                else
                {
                    context.Writer.Write(requestObject.LoRoCenterMixLevel);
                }
            }

            if(requestObject.IsSetLoRoSurroundMixLevel())
            {
                context.Writer.WritePropertyName("loRoSurroundMixLevel");
                if(StringUtils.IsSpecialDoubleValue(requestObject.LoRoSurroundMixLevel))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.LoRoSurroundMixLevel));
                }
                else
                {
                    context.Writer.Write(requestObject.LoRoSurroundMixLevel);
                }
            }

            if(requestObject.IsSetLtRtCenterMixLevel())
            {
                context.Writer.WritePropertyName("ltRtCenterMixLevel");
                if(StringUtils.IsSpecialDoubleValue(requestObject.LtRtCenterMixLevel))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.LtRtCenterMixLevel));
                }
                else
                {
                    context.Writer.Write(requestObject.LtRtCenterMixLevel);
                }
            }

            if(requestObject.IsSetLtRtSurroundMixLevel())
            {
                context.Writer.WritePropertyName("ltRtSurroundMixLevel");
                if(StringUtils.IsSpecialDoubleValue(requestObject.LtRtSurroundMixLevel))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.LtRtSurroundMixLevel));
                }
                else
                {
                    context.Writer.Write(requestObject.LtRtSurroundMixLevel);
                }
            }

            if(requestObject.IsSetSampleRate())
            {
                context.Writer.WritePropertyName("sampleRate");
                context.Writer.Write(requestObject.SampleRate);
            }

            if(requestObject.IsSetStereoDownmix())
            {
                context.Writer.WritePropertyName("stereoDownmix");
                context.Writer.Write(requestObject.StereoDownmix);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Ac4SettingsMarshaller Instance = new Ac4SettingsMarshaller();

    }
}