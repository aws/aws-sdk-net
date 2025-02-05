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
    /// M3u8Settings Marshaller
    /// </summary>
    public class M3u8SettingsMarshaller : IRequestMarshaller<M3u8Settings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(M3u8Settings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudioFramesPerPes())
            {
                context.Writer.WritePropertyName("audioFramesPerPes");
                context.Writer.WriteNumberValue(requestObject.AudioFramesPerPes.Value);
            }

            if(requestObject.IsSetAudioPids())
            {
                context.Writer.WritePropertyName("audioPids");
                context.Writer.WriteStringValue(requestObject.AudioPids);
            }

            if(requestObject.IsSetEcmPid())
            {
                context.Writer.WritePropertyName("ecmPid");
                context.Writer.WriteStringValue(requestObject.EcmPid);
            }

            if(requestObject.IsSetKlvBehavior())
            {
                context.Writer.WritePropertyName("klvBehavior");
                context.Writer.WriteStringValue(requestObject.KlvBehavior);
            }

            if(requestObject.IsSetKlvDataPids())
            {
                context.Writer.WritePropertyName("klvDataPids");
                context.Writer.WriteStringValue(requestObject.KlvDataPids);
            }

            if(requestObject.IsSetNielsenId3Behavior())
            {
                context.Writer.WritePropertyName("nielsenId3Behavior");
                context.Writer.WriteStringValue(requestObject.NielsenId3Behavior);
            }

            if(requestObject.IsSetPatInterval())
            {
                context.Writer.WritePropertyName("patInterval");
                context.Writer.WriteNumberValue(requestObject.PatInterval.Value);
            }

            if(requestObject.IsSetPcrControl())
            {
                context.Writer.WritePropertyName("pcrControl");
                context.Writer.WriteStringValue(requestObject.PcrControl);
            }

            if(requestObject.IsSetPcrPeriod())
            {
                context.Writer.WritePropertyName("pcrPeriod");
                context.Writer.WriteNumberValue(requestObject.PcrPeriod.Value);
            }

            if(requestObject.IsSetPcrPid())
            {
                context.Writer.WritePropertyName("pcrPid");
                context.Writer.WriteStringValue(requestObject.PcrPid);
            }

            if(requestObject.IsSetPmtInterval())
            {
                context.Writer.WritePropertyName("pmtInterval");
                context.Writer.WriteNumberValue(requestObject.PmtInterval.Value);
            }

            if(requestObject.IsSetPmtPid())
            {
                context.Writer.WritePropertyName("pmtPid");
                context.Writer.WriteStringValue(requestObject.PmtPid);
            }

            if(requestObject.IsSetProgramNum())
            {
                context.Writer.WritePropertyName("programNum");
                context.Writer.WriteNumberValue(requestObject.ProgramNum.Value);
            }

            if(requestObject.IsSetScte35Behavior())
            {
                context.Writer.WritePropertyName("scte35Behavior");
                context.Writer.WriteStringValue(requestObject.Scte35Behavior);
            }

            if(requestObject.IsSetScte35Pid())
            {
                context.Writer.WritePropertyName("scte35Pid");
                context.Writer.WriteStringValue(requestObject.Scte35Pid);
            }

            if(requestObject.IsSetTimedMetadataBehavior())
            {
                context.Writer.WritePropertyName("timedMetadataBehavior");
                context.Writer.WriteStringValue(requestObject.TimedMetadataBehavior);
            }

            if(requestObject.IsSetTimedMetadataPid())
            {
                context.Writer.WritePropertyName("timedMetadataPid");
                context.Writer.WriteStringValue(requestObject.TimedMetadataPid);
            }

            if(requestObject.IsSetTransportStreamId())
            {
                context.Writer.WritePropertyName("transportStreamId");
                context.Writer.WriteNumberValue(requestObject.TransportStreamId.Value);
            }

            if(requestObject.IsSetVideoPid())
            {
                context.Writer.WritePropertyName("videoPid");
                context.Writer.WriteStringValue(requestObject.VideoPid);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static M3u8SettingsMarshaller Instance = new M3u8SettingsMarshaller();

    }
}