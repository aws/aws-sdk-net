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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAbsentInputAudioBehavior())
            {
                context.Writer.WritePropertyName("absentInputAudioBehavior");
                context.Writer.Write(requestObject.AbsentInputAudioBehavior);
            }

            if(requestObject.IsSetArib())
            {
                context.Writer.WritePropertyName("arib");
                context.Writer.Write(requestObject.Arib);
            }

            if(requestObject.IsSetAribCaptionsPid())
            {
                context.Writer.WritePropertyName("aribCaptionsPid");
                context.Writer.Write(requestObject.AribCaptionsPid);
            }

            if(requestObject.IsSetAribCaptionsPidControl())
            {
                context.Writer.WritePropertyName("aribCaptionsPidControl");
                context.Writer.Write(requestObject.AribCaptionsPidControl);
            }

            if(requestObject.IsSetAudioBufferModel())
            {
                context.Writer.WritePropertyName("audioBufferModel");
                context.Writer.Write(requestObject.AudioBufferModel);
            }

            if(requestObject.IsSetAudioFramesPerPes())
            {
                context.Writer.WritePropertyName("audioFramesPerPes");
                context.Writer.Write(requestObject.AudioFramesPerPes);
            }

            if(requestObject.IsSetAudioPids())
            {
                context.Writer.WritePropertyName("audioPids");
                context.Writer.Write(requestObject.AudioPids);
            }

            if(requestObject.IsSetAudioStreamType())
            {
                context.Writer.WritePropertyName("audioStreamType");
                context.Writer.Write(requestObject.AudioStreamType);
            }

            if(requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                context.Writer.Write(requestObject.Bitrate);
            }

            if(requestObject.IsSetBufferModel())
            {
                context.Writer.WritePropertyName("bufferModel");
                context.Writer.Write(requestObject.BufferModel);
            }

            if(requestObject.IsSetCcDescriptor())
            {
                context.Writer.WritePropertyName("ccDescriptor");
                context.Writer.Write(requestObject.CcDescriptor);
            }

            if(requestObject.IsSetDvbNitSettings())
            {
                context.Writer.WritePropertyName("dvbNitSettings");
                context.Writer.WriteObjectStart();

                var marshaller = DvbNitSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DvbNitSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDvbSdtSettings())
            {
                context.Writer.WritePropertyName("dvbSdtSettings");
                context.Writer.WriteObjectStart();

                var marshaller = DvbSdtSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DvbSdtSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDvbSubPids())
            {
                context.Writer.WritePropertyName("dvbSubPids");
                context.Writer.Write(requestObject.DvbSubPids);
            }

            if(requestObject.IsSetDvbTdtSettings())
            {
                context.Writer.WritePropertyName("dvbTdtSettings");
                context.Writer.WriteObjectStart();

                var marshaller = DvbTdtSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DvbTdtSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDvbTeletextPid())
            {
                context.Writer.WritePropertyName("dvbTeletextPid");
                context.Writer.Write(requestObject.DvbTeletextPid);
            }

            if(requestObject.IsSetEbif())
            {
                context.Writer.WritePropertyName("ebif");
                context.Writer.Write(requestObject.Ebif);
            }

            if(requestObject.IsSetEbpAudioInterval())
            {
                context.Writer.WritePropertyName("ebpAudioInterval");
                context.Writer.Write(requestObject.EbpAudioInterval);
            }

            if(requestObject.IsSetEbpLookaheadMs())
            {
                context.Writer.WritePropertyName("ebpLookaheadMs");
                context.Writer.Write(requestObject.EbpLookaheadMs);
            }

            if(requestObject.IsSetEbpPlacement())
            {
                context.Writer.WritePropertyName("ebpPlacement");
                context.Writer.Write(requestObject.EbpPlacement);
            }

            if(requestObject.IsSetEcmPid())
            {
                context.Writer.WritePropertyName("ecmPid");
                context.Writer.Write(requestObject.EcmPid);
            }

            if(requestObject.IsSetEsRateInPes())
            {
                context.Writer.WritePropertyName("esRateInPes");
                context.Writer.Write(requestObject.EsRateInPes);
            }

            if(requestObject.IsSetEtvPlatformPid())
            {
                context.Writer.WritePropertyName("etvPlatformPid");
                context.Writer.Write(requestObject.EtvPlatformPid);
            }

            if(requestObject.IsSetEtvSignalPid())
            {
                context.Writer.WritePropertyName("etvSignalPid");
                context.Writer.Write(requestObject.EtvSignalPid);
            }

            if(requestObject.IsSetFragmentTime())
            {
                context.Writer.WritePropertyName("fragmentTime");
                context.Writer.Write(requestObject.FragmentTime);
            }

            if(requestObject.IsSetKlv())
            {
                context.Writer.WritePropertyName("klv");
                context.Writer.Write(requestObject.Klv);
            }

            if(requestObject.IsSetKlvDataPids())
            {
                context.Writer.WritePropertyName("klvDataPids");
                context.Writer.Write(requestObject.KlvDataPids);
            }

            if(requestObject.IsSetNielsenId3Behavior())
            {
                context.Writer.WritePropertyName("nielsenId3Behavior");
                context.Writer.Write(requestObject.NielsenId3Behavior);
            }

            if(requestObject.IsSetNullPacketBitrate())
            {
                context.Writer.WritePropertyName("nullPacketBitrate");
                context.Writer.Write(requestObject.NullPacketBitrate);
            }

            if(requestObject.IsSetPatInterval())
            {
                context.Writer.WritePropertyName("patInterval");
                context.Writer.Write(requestObject.PatInterval);
            }

            if(requestObject.IsSetPcrControl())
            {
                context.Writer.WritePropertyName("pcrControl");
                context.Writer.Write(requestObject.PcrControl);
            }

            if(requestObject.IsSetPcrPeriod())
            {
                context.Writer.WritePropertyName("pcrPeriod");
                context.Writer.Write(requestObject.PcrPeriod);
            }

            if(requestObject.IsSetPcrPid())
            {
                context.Writer.WritePropertyName("pcrPid");
                context.Writer.Write(requestObject.PcrPid);
            }

            if(requestObject.IsSetPmtInterval())
            {
                context.Writer.WritePropertyName("pmtInterval");
                context.Writer.Write(requestObject.PmtInterval);
            }

            if(requestObject.IsSetPmtPid())
            {
                context.Writer.WritePropertyName("pmtPid");
                context.Writer.Write(requestObject.PmtPid);
            }

            if(requestObject.IsSetProgramNum())
            {
                context.Writer.WritePropertyName("programNum");
                context.Writer.Write(requestObject.ProgramNum);
            }

            if(requestObject.IsSetRateMode())
            {
                context.Writer.WritePropertyName("rateMode");
                context.Writer.Write(requestObject.RateMode);
            }

            if(requestObject.IsSetScte27Pids())
            {
                context.Writer.WritePropertyName("scte27Pids");
                context.Writer.Write(requestObject.Scte27Pids);
            }

            if(requestObject.IsSetScte35Control())
            {
                context.Writer.WritePropertyName("scte35Control");
                context.Writer.Write(requestObject.Scte35Control);
            }

            if(requestObject.IsSetScte35Pid())
            {
                context.Writer.WritePropertyName("scte35Pid");
                context.Writer.Write(requestObject.Scte35Pid);
            }

            if(requestObject.IsSetScte35PrerollPullupMilliseconds())
            {
                context.Writer.WritePropertyName("scte35PrerollPullupMilliseconds");
                context.Writer.Write(requestObject.Scte35PrerollPullupMilliseconds);
            }

            if(requestObject.IsSetSegmentationMarkers())
            {
                context.Writer.WritePropertyName("segmentationMarkers");
                context.Writer.Write(requestObject.SegmentationMarkers);
            }

            if(requestObject.IsSetSegmentationStyle())
            {
                context.Writer.WritePropertyName("segmentationStyle");
                context.Writer.Write(requestObject.SegmentationStyle);
            }

            if(requestObject.IsSetSegmentationTime())
            {
                context.Writer.WritePropertyName("segmentationTime");
                context.Writer.Write(requestObject.SegmentationTime);
            }

            if(requestObject.IsSetTimedMetadataBehavior())
            {
                context.Writer.WritePropertyName("timedMetadataBehavior");
                context.Writer.Write(requestObject.TimedMetadataBehavior);
            }

            if(requestObject.IsSetTimedMetadataPid())
            {
                context.Writer.WritePropertyName("timedMetadataPid");
                context.Writer.Write(requestObject.TimedMetadataPid);
            }

            if(requestObject.IsSetTransportStreamId())
            {
                context.Writer.WritePropertyName("transportStreamId");
                context.Writer.Write(requestObject.TransportStreamId);
            }

            if(requestObject.IsSetVideoPid())
            {
                context.Writer.WritePropertyName("videoPid");
                context.Writer.Write(requestObject.VideoPid);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static M2tsSettingsMarshaller Instance = new M2tsSettingsMarshaller();

    }
}