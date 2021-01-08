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

            if(requestObject.IsSetDialogueIntelligence())
            {
                context.Writer.WritePropertyName("dialogueIntelligence");
                context.Writer.Write(requestObject.DialogueIntelligence);
            }

            if(requestObject.IsSetDynamicRangeCompressionLine())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionLine");
                context.Writer.Write(requestObject.DynamicRangeCompressionLine);
            }

            if(requestObject.IsSetDynamicRangeCompressionRf())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionRf");
                context.Writer.Write(requestObject.DynamicRangeCompressionRf);
            }

            if(requestObject.IsSetLoRoCenterMixLevel())
            {
                context.Writer.WritePropertyName("loRoCenterMixLevel");
                context.Writer.Write(requestObject.LoRoCenterMixLevel);
            }

            if(requestObject.IsSetLoRoSurroundMixLevel())
            {
                context.Writer.WritePropertyName("loRoSurroundMixLevel");
                context.Writer.Write(requestObject.LoRoSurroundMixLevel);
            }

            if(requestObject.IsSetLtRtCenterMixLevel())
            {
                context.Writer.WritePropertyName("ltRtCenterMixLevel");
                context.Writer.Write(requestObject.LtRtCenterMixLevel);
            }

            if(requestObject.IsSetLtRtSurroundMixLevel())
            {
                context.Writer.WritePropertyName("ltRtSurroundMixLevel");
                context.Writer.Write(requestObject.LtRtSurroundMixLevel);
            }

            if(requestObject.IsSetMeteringMode())
            {
                context.Writer.WritePropertyName("meteringMode");
                context.Writer.Write(requestObject.MeteringMode);
            }

            if(requestObject.IsSetSampleRate())
            {
                context.Writer.WritePropertyName("sampleRate");
                context.Writer.Write(requestObject.SampleRate);
            }

            if(requestObject.IsSetSpeechThreshold())
            {
                context.Writer.WritePropertyName("speechThreshold");
                context.Writer.Write(requestObject.SpeechThreshold);
            }

            if(requestObject.IsSetStereoDownmix())
            {
                context.Writer.WritePropertyName("stereoDownmix");
                context.Writer.Write(requestObject.StereoDownmix);
            }

            if(requestObject.IsSetSurroundExMode())
            {
                context.Writer.WritePropertyName("surroundExMode");
                context.Writer.Write(requestObject.SurroundExMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static Eac3AtmosSettingsMarshaller Instance = new Eac3AtmosSettingsMarshaller();

    }
}