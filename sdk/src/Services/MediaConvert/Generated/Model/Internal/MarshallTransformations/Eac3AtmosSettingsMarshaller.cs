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
    /// Eac3AtmosSettings Marshaller
    /// </summary>
    public class Eac3AtmosSettingsMarshaller : IRequestMarshaller<Eac3AtmosSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Eac3AtmosSettings requestObject, JsonMarshallerContext context)
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

            if(requestObject.IsSetDialogueIntelligence())
            {
                context.Writer.WritePropertyName("dialogueIntelligence");
                context.Writer.WriteStringValue(requestObject.DialogueIntelligence);
            }

            if(requestObject.IsSetDownmixControl())
            {
                context.Writer.WritePropertyName("downmixControl");
                context.Writer.WriteStringValue(requestObject.DownmixControl);
            }

            if(requestObject.IsSetDynamicRangeCompressionLine())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionLine");
                context.Writer.WriteStringValue(requestObject.DynamicRangeCompressionLine);
            }

            if(requestObject.IsSetDynamicRangeCompressionRf())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionRf");
                context.Writer.WriteStringValue(requestObject.DynamicRangeCompressionRf);
            }

            if(requestObject.IsSetDynamicRangeControl())
            {
                context.Writer.WritePropertyName("dynamicRangeControl");
                context.Writer.WriteStringValue(requestObject.DynamicRangeControl);
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

            if(requestObject.IsSetMeteringMode())
            {
                context.Writer.WritePropertyName("meteringMode");
                context.Writer.WriteStringValue(requestObject.MeteringMode);
            }

            if(requestObject.IsSetSampleRate())
            {
                context.Writer.WritePropertyName("sampleRate");
                context.Writer.WriteNumberValue(requestObject.SampleRate.Value);
            }

            if(requestObject.IsSetSpeechThreshold())
            {
                context.Writer.WritePropertyName("speechThreshold");
                context.Writer.WriteNumberValue(requestObject.SpeechThreshold.Value);
            }

            if(requestObject.IsSetStereoDownmix())
            {
                context.Writer.WritePropertyName("stereoDownmix");
                context.Writer.WriteStringValue(requestObject.StereoDownmix);
            }

            if(requestObject.IsSetSurroundExMode())
            {
                context.Writer.WritePropertyName("surroundExMode");
                context.Writer.WriteStringValue(requestObject.SurroundExMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Eac3AtmosSettingsMarshaller Instance = new Eac3AtmosSettingsMarshaller();

    }
}