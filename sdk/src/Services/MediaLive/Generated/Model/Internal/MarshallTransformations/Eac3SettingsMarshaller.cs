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
    /// Eac3Settings Marshaller
    /// </summary>
    public class Eac3SettingsMarshaller : IRequestMarshaller<Eac3Settings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Eac3Settings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttenuationControl())
            {
                context.Writer.WritePropertyName("attenuationControl");
                context.Writer.WriteStringValue(requestObject.AttenuationControl);
            }

            if(requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Bitrate.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Bitrate.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Bitrate.Value);
                }
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

            if(requestObject.IsSetDcFilter())
            {
                context.Writer.WritePropertyName("dcFilter");
                context.Writer.WriteStringValue(requestObject.DcFilter);
            }

            if(requestObject.IsSetDialnorm())
            {
                context.Writer.WritePropertyName("dialnorm");
                context.Writer.WriteNumberValue(requestObject.Dialnorm.Value);
            }

            if(requestObject.IsSetDrcLine())
            {
                context.Writer.WritePropertyName("drcLine");
                context.Writer.WriteStringValue(requestObject.DrcLine);
            }

            if(requestObject.IsSetDrcRf())
            {
                context.Writer.WritePropertyName("drcRf");
                context.Writer.WriteStringValue(requestObject.DrcRf);
            }

            if(requestObject.IsSetLfeControl())
            {
                context.Writer.WritePropertyName("lfeControl");
                context.Writer.WriteStringValue(requestObject.LfeControl);
            }

            if(requestObject.IsSetLfeFilter())
            {
                context.Writer.WritePropertyName("lfeFilter");
                context.Writer.WriteStringValue(requestObject.LfeFilter);
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

            if(requestObject.IsSetMetadataControl())
            {
                context.Writer.WritePropertyName("metadataControl");
                context.Writer.WriteStringValue(requestObject.MetadataControl);
            }

            if(requestObject.IsSetPassthroughControl())
            {
                context.Writer.WritePropertyName("passthroughControl");
                context.Writer.WriteStringValue(requestObject.PassthroughControl);
            }

            if(requestObject.IsSetPhaseControl())
            {
                context.Writer.WritePropertyName("phaseControl");
                context.Writer.WriteStringValue(requestObject.PhaseControl);
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

            if(requestObject.IsSetSurroundMode())
            {
                context.Writer.WritePropertyName("surroundMode");
                context.Writer.WriteStringValue(requestObject.SurroundMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Eac3SettingsMarshaller Instance = new Eac3SettingsMarshaller();

    }
}