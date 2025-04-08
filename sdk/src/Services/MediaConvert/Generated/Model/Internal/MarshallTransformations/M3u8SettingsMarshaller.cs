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
            if(requestObject.IsSetAudioDuration())
            {
                context.Writer.WritePropertyName("audioDuration");
                context.Writer.WriteStringValue(requestObject.AudioDuration);
            }

            if(requestObject.IsSetAudioFramesPerPes())
            {
                context.Writer.WritePropertyName("audioFramesPerPes");
                context.Writer.WriteNumberValue(requestObject.AudioFramesPerPes.Value);
            }

            if(requestObject.IsSetAudioPids())
            {
                context.Writer.WritePropertyName("audioPids");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAudioPidsListValue in requestObject.AudioPids)
                {
                        context.Writer.WriteNumberValue(requestObjectAudioPidsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAudioPtsOffsetDelta())
            {
                context.Writer.WritePropertyName("audioPtsOffsetDelta");
                context.Writer.WriteNumberValue(requestObject.AudioPtsOffsetDelta.Value);
            }

            if(requestObject.IsSetDataPTSControl())
            {
                context.Writer.WritePropertyName("dataPTSControl");
                context.Writer.WriteStringValue(requestObject.DataPTSControl);
            }

            if(requestObject.IsSetMaxPcrInterval())
            {
                context.Writer.WritePropertyName("maxPcrInterval");
                context.Writer.WriteNumberValue(requestObject.MaxPcrInterval.Value);
            }

            if(requestObject.IsSetNielsenId3())
            {
                context.Writer.WritePropertyName("nielsenId3");
                context.Writer.WriteStringValue(requestObject.NielsenId3);
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

            if(requestObject.IsSetPcrPid())
            {
                context.Writer.WritePropertyName("pcrPid");
                context.Writer.WriteNumberValue(requestObject.PcrPid.Value);
            }

            if(requestObject.IsSetPmtInterval())
            {
                context.Writer.WritePropertyName("pmtInterval");
                context.Writer.WriteNumberValue(requestObject.PmtInterval.Value);
            }

            if(requestObject.IsSetPmtPid())
            {
                context.Writer.WritePropertyName("pmtPid");
                context.Writer.WriteNumberValue(requestObject.PmtPid.Value);
            }

            if(requestObject.IsSetPrivateMetadataPid())
            {
                context.Writer.WritePropertyName("privateMetadataPid");
                context.Writer.WriteNumberValue(requestObject.PrivateMetadataPid.Value);
            }

            if(requestObject.IsSetProgramNumber())
            {
                context.Writer.WritePropertyName("programNumber");
                context.Writer.WriteNumberValue(requestObject.ProgramNumber.Value);
            }

            if(requestObject.IsSetPtsOffset())
            {
                context.Writer.WritePropertyName("ptsOffset");
                context.Writer.WriteNumberValue(requestObject.PtsOffset.Value);
            }

            if(requestObject.IsSetPtsOffsetMode())
            {
                context.Writer.WritePropertyName("ptsOffsetMode");
                context.Writer.WriteStringValue(requestObject.PtsOffsetMode);
            }

            if(requestObject.IsSetScte35Pid())
            {
                context.Writer.WritePropertyName("scte35Pid");
                context.Writer.WriteNumberValue(requestObject.Scte35Pid.Value);
            }

            if(requestObject.IsSetScte35Source())
            {
                context.Writer.WritePropertyName("scte35Source");
                context.Writer.WriteStringValue(requestObject.Scte35Source);
            }

            if(requestObject.IsSetTimedMetadata())
            {
                context.Writer.WritePropertyName("timedMetadata");
                context.Writer.WriteStringValue(requestObject.TimedMetadata);
            }

            if(requestObject.IsSetTimedMetadataPid())
            {
                context.Writer.WritePropertyName("timedMetadataPid");
                context.Writer.WriteNumberValue(requestObject.TimedMetadataPid.Value);
            }

            if(requestObject.IsSetTransportStreamId())
            {
                context.Writer.WritePropertyName("transportStreamId");
                context.Writer.WriteNumberValue(requestObject.TransportStreamId.Value);
            }

            if(requestObject.IsSetVideoPid())
            {
                context.Writer.WritePropertyName("videoPid");
                context.Writer.WriteNumberValue(requestObject.VideoPid.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static M3u8SettingsMarshaller Instance = new M3u8SettingsMarshaller();

    }
}