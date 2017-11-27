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
            if(requestObject.IsSetAttenuationControl())
            {
                context.Writer.WritePropertyName("attenuationControl");
                context.Writer.Write(requestObject.AttenuationControl);
            }

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

            if(requestObject.IsSetDcFilter())
            {
                context.Writer.WritePropertyName("dcFilter");
                context.Writer.Write(requestObject.DcFilter);
            }

            if(requestObject.IsSetDialnorm())
            {
                context.Writer.WritePropertyName("dialnorm");
                context.Writer.Write(requestObject.Dialnorm);
            }

            if(requestObject.IsSetDrcLine())
            {
                context.Writer.WritePropertyName("drcLine");
                context.Writer.Write(requestObject.DrcLine);
            }

            if(requestObject.IsSetDrcRf())
            {
                context.Writer.WritePropertyName("drcRf");
                context.Writer.Write(requestObject.DrcRf);
            }

            if(requestObject.IsSetLfeControl())
            {
                context.Writer.WritePropertyName("lfeControl");
                context.Writer.Write(requestObject.LfeControl);
            }

            if(requestObject.IsSetLfeFilter())
            {
                context.Writer.WritePropertyName("lfeFilter");
                context.Writer.Write(requestObject.LfeFilter);
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

            if(requestObject.IsSetMetadataControl())
            {
                context.Writer.WritePropertyName("metadataControl");
                context.Writer.Write(requestObject.MetadataControl);
            }

            if(requestObject.IsSetPassthroughControl())
            {
                context.Writer.WritePropertyName("passthroughControl");
                context.Writer.Write(requestObject.PassthroughControl);
            }

            if(requestObject.IsSetPhaseControl())
            {
                context.Writer.WritePropertyName("phaseControl");
                context.Writer.Write(requestObject.PhaseControl);
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

            if(requestObject.IsSetSurroundMode())
            {
                context.Writer.WritePropertyName("surroundMode");
                context.Writer.Write(requestObject.SurroundMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static Eac3SettingsMarshaller Instance = new Eac3SettingsMarshaller();

    }
}