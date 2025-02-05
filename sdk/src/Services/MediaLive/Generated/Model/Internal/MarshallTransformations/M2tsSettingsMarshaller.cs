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
            if(requestObject.IsSetAbsentInputAudioBehavior())
            {
                context.Writer.WritePropertyName("absentInputAudioBehavior");
                context.Writer.WriteStringValue(requestObject.AbsentInputAudioBehavior);
            }

            if(requestObject.IsSetArib())
            {
                context.Writer.WritePropertyName("arib");
                context.Writer.WriteStringValue(requestObject.Arib);
            }

            if(requestObject.IsSetAribCaptionsPid())
            {
                context.Writer.WritePropertyName("aribCaptionsPid");
                context.Writer.WriteStringValue(requestObject.AribCaptionsPid);
            }

            if(requestObject.IsSetAribCaptionsPidControl())
            {
                context.Writer.WritePropertyName("aribCaptionsPidControl");
                context.Writer.WriteStringValue(requestObject.AribCaptionsPidControl);
            }

            if(requestObject.IsSetAudioBufferModel())
            {
                context.Writer.WritePropertyName("audioBufferModel");
                context.Writer.WriteStringValue(requestObject.AudioBufferModel);
            }

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

            if(requestObject.IsSetAudioStreamType())
            {
                context.Writer.WritePropertyName("audioStreamType");
                context.Writer.WriteStringValue(requestObject.AudioStreamType);
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

            if(requestObject.IsSetCcDescriptor())
            {
                context.Writer.WritePropertyName("ccDescriptor");
                context.Writer.WriteStringValue(requestObject.CcDescriptor);
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
                context.Writer.WriteStringValue(requestObject.DvbSubPids);
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
                context.Writer.WriteStringValue(requestObject.DvbTeletextPid);
            }

            if(requestObject.IsSetEbif())
            {
                context.Writer.WritePropertyName("ebif");
                context.Writer.WriteStringValue(requestObject.Ebif);
            }

            if(requestObject.IsSetEbpAudioInterval())
            {
                context.Writer.WritePropertyName("ebpAudioInterval");
                context.Writer.WriteStringValue(requestObject.EbpAudioInterval);
            }

            if(requestObject.IsSetEbpLookaheadMs())
            {
                context.Writer.WritePropertyName("ebpLookaheadMs");
                context.Writer.WriteNumberValue(requestObject.EbpLookaheadMs.Value);
            }

            if(requestObject.IsSetEbpPlacement())
            {
                context.Writer.WritePropertyName("ebpPlacement");
                context.Writer.WriteStringValue(requestObject.EbpPlacement);
            }

            if(requestObject.IsSetEcmPid())
            {
                context.Writer.WritePropertyName("ecmPid");
                context.Writer.WriteStringValue(requestObject.EcmPid);
            }

            if(requestObject.IsSetEsRateInPes())
            {
                context.Writer.WritePropertyName("esRateInPes");
                context.Writer.WriteStringValue(requestObject.EsRateInPes);
            }

            if(requestObject.IsSetEtvPlatformPid())
            {
                context.Writer.WritePropertyName("etvPlatformPid");
                context.Writer.WriteStringValue(requestObject.EtvPlatformPid);
            }

            if(requestObject.IsSetEtvSignalPid())
            {
                context.Writer.WritePropertyName("etvSignalPid");
                context.Writer.WriteStringValue(requestObject.EtvSignalPid);
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

            if(requestObject.IsSetKlv())
            {
                context.Writer.WritePropertyName("klv");
                context.Writer.WriteStringValue(requestObject.Klv);
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

            if(requestObject.IsSetRateMode())
            {
                context.Writer.WritePropertyName("rateMode");
                context.Writer.WriteStringValue(requestObject.RateMode);
            }

            if(requestObject.IsSetScte27Pids())
            {
                context.Writer.WritePropertyName("scte27Pids");
                context.Writer.WriteStringValue(requestObject.Scte27Pids);
            }

            if(requestObject.IsSetScte35Control())
            {
                context.Writer.WritePropertyName("scte35Control");
                context.Writer.WriteStringValue(requestObject.Scte35Control);
            }

            if(requestObject.IsSetScte35Pid())
            {
                context.Writer.WritePropertyName("scte35Pid");
                context.Writer.WriteStringValue(requestObject.Scte35Pid);
            }

            if(requestObject.IsSetScte35PrerollPullupMilliseconds())
            {
                context.Writer.WritePropertyName("scte35PrerollPullupMilliseconds");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Scte35PrerollPullupMilliseconds.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Scte35PrerollPullupMilliseconds.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Scte35PrerollPullupMilliseconds.Value);
                }
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
        public readonly static M2tsSettingsMarshaller Instance = new M2tsSettingsMarshaller();

    }
}