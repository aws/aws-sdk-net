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
    /// M2tsSettings Marshaller
    /// </summary>
    public class M2tsSettingsMarshaller : IRequestMarshaller<M2tsSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(M2tsSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudioBufferModel())
            {
                context.Writer.WritePropertyName("audioBufferModel");
                context.Writer.WriteStringValue(requestObject.AudioBufferModel);
            }

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

            if(requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                context.Writer.WriteNumberValue(requestObject.Bitrate.Value);
            }

            if(requestObject.IsSetBufferModel())
            {
                context.Writer.WritePropertyName("bufferModel");
                context.Writer.WriteStringValue(requestObject.BufferModel);
            }

            if(requestObject.IsSetDataPTSControl())
            {
                context.Writer.WritePropertyName("dataPTSControl");
                context.Writer.WriteStringValue(requestObject.DataPTSControl);
            }

            if(requestObject.IsSetDvbNitSettings())
            {
                context.Writer.WritePropertyName("dvbNitSettings");
                context.Writer.WriteStartObject();

                var marshaller = DvbNitSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DvbNitSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDvbSdtSettings())
            {
                context.Writer.WritePropertyName("dvbSdtSettings");
                context.Writer.WriteStartObject();

                var marshaller = DvbSdtSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DvbSdtSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDvbSubPids())
            {
                context.Writer.WritePropertyName("dvbSubPids");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDvbSubPidsListValue in requestObject.DvbSubPids)
                {
                        context.Writer.WriteNumberValue(requestObjectDvbSubPidsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDvbTdtSettings())
            {
                context.Writer.WritePropertyName("dvbTdtSettings");
                context.Writer.WriteStartObject();

                var marshaller = DvbTdtSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DvbTdtSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDvbTeletextPid())
            {
                context.Writer.WritePropertyName("dvbTeletextPid");
                context.Writer.WriteNumberValue(requestObject.DvbTeletextPid.Value);
            }

            if(requestObject.IsSetEbpAudioInterval())
            {
                context.Writer.WritePropertyName("ebpAudioInterval");
                context.Writer.WriteStringValue(requestObject.EbpAudioInterval);
            }

            if(requestObject.IsSetEbpPlacement())
            {
                context.Writer.WritePropertyName("ebpPlacement");
                context.Writer.WriteStringValue(requestObject.EbpPlacement);
            }

            if(requestObject.IsSetEsRateInPes())
            {
                context.Writer.WritePropertyName("esRateInPes");
                context.Writer.WriteStringValue(requestObject.EsRateInPes);
            }

            if(requestObject.IsSetForceTsVideoEbpOrder())
            {
                context.Writer.WritePropertyName("forceTsVideoEbpOrder");
                context.Writer.WriteStringValue(requestObject.ForceTsVideoEbpOrder);
            }

            if(requestObject.IsSetFragmentTime())
            {
                context.Writer.WritePropertyName("fragmentTime");
                if(StringUtils.IsSpecialDoubleValue(requestObject.FragmentTime.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.FragmentTime.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.FragmentTime.Value);
                }
            }

            if(requestObject.IsSetKlvMetadata())
            {
                context.Writer.WritePropertyName("klvMetadata");
                context.Writer.WriteStringValue(requestObject.KlvMetadata);
            }

            if(requestObject.IsSetMaxPcrInterval())
            {
                context.Writer.WritePropertyName("maxPcrInterval");
                context.Writer.WriteNumberValue(requestObject.MaxPcrInterval.Value);
            }

            if(requestObject.IsSetMinEbpInterval())
            {
                context.Writer.WritePropertyName("minEbpInterval");
                context.Writer.WriteNumberValue(requestObject.MinEbpInterval.Value);
            }

            if(requestObject.IsSetNielsenId3())
            {
                context.Writer.WritePropertyName("nielsenId3");
                context.Writer.WriteStringValue(requestObject.NielsenId3);
            }

            if(requestObject.IsSetNullPacketBitrate())
            {
                context.Writer.WritePropertyName("nullPacketBitrate");
                if(StringUtils.IsSpecialDoubleValue(requestObject.NullPacketBitrate.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.NullPacketBitrate.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.NullPacketBitrate.Value);
                }
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

            if(requestObject.IsSetPreventBufferUnderflow())
            {
                context.Writer.WritePropertyName("preventBufferUnderflow");
                context.Writer.WriteStringValue(requestObject.PreventBufferUnderflow);
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

            if(requestObject.IsSetRateMode())
            {
                context.Writer.WritePropertyName("rateMode");
                context.Writer.WriteStringValue(requestObject.RateMode);
            }

            if(requestObject.IsSetScte35Esam())
            {
                context.Writer.WritePropertyName("scte35Esam");
                context.Writer.WriteStartObject();

                var marshaller = M2tsScte35EsamMarshaller.Instance;
                marshaller.Marshall(requestObject.Scte35Esam, context);

                context.Writer.WriteEndObject();
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

            if(requestObject.IsSetSegmentationMarkers())
            {
                context.Writer.WritePropertyName("segmentationMarkers");
                context.Writer.WriteStringValue(requestObject.SegmentationMarkers);
            }

            if(requestObject.IsSetSegmentationStyle())
            {
                context.Writer.WritePropertyName("segmentationStyle");
                context.Writer.WriteStringValue(requestObject.SegmentationStyle);
            }

            if(requestObject.IsSetSegmentationTime())
            {
                context.Writer.WritePropertyName("segmentationTime");
                if(StringUtils.IsSpecialDoubleValue(requestObject.SegmentationTime.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.SegmentationTime.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.SegmentationTime.Value);
                }
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
        public readonly static M2tsSettingsMarshaller Instance = new M2tsSettingsMarshaller();

    }
}