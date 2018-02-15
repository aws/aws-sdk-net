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
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAudioPidsListValue in requestObject.AudioPids)
                {
                        context.Writer.Write(requestObjectAudioPidsListValue);
                }
                context.Writer.WriteArrayEnd();
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
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDvbSubPidsListValue in requestObject.DvbSubPids)
                {
                        context.Writer.Write(requestObjectDvbSubPidsListValue);
                }
                context.Writer.WriteArrayEnd();
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

            if(requestObject.IsSetEbpAudioInterval())
            {
                context.Writer.WritePropertyName("ebpAudioInterval");
                context.Writer.Write(requestObject.EbpAudioInterval);
            }

            if(requestObject.IsSetEbpPlacement())
            {
                context.Writer.WritePropertyName("ebpPlacement");
                context.Writer.Write(requestObject.EbpPlacement);
            }

            if(requestObject.IsSetEsRateInPes())
            {
                context.Writer.WritePropertyName("esRateInPes");
                context.Writer.Write(requestObject.EsRateInPes);
            }

            if(requestObject.IsSetFragmentTime())
            {
                context.Writer.WritePropertyName("fragmentTime");
                context.Writer.Write(requestObject.FragmentTime);
            }

            if(requestObject.IsSetMaxPcrInterval())
            {
                context.Writer.WritePropertyName("maxPcrInterval");
                context.Writer.Write(requestObject.MaxPcrInterval);
            }

            if(requestObject.IsSetMinEbpInterval())
            {
                context.Writer.WritePropertyName("minEbpInterval");
                context.Writer.Write(requestObject.MinEbpInterval);
            }

            if(requestObject.IsSetNielsenId3())
            {
                context.Writer.WritePropertyName("nielsenId3");
                context.Writer.Write(requestObject.NielsenId3);
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

            if(requestObject.IsSetPrivateMetadataPid())
            {
                context.Writer.WritePropertyName("privateMetadataPid");
                context.Writer.Write(requestObject.PrivateMetadataPid);
            }

            if(requestObject.IsSetProgramNumber())
            {
                context.Writer.WritePropertyName("programNumber");
                context.Writer.Write(requestObject.ProgramNumber);
            }

            if(requestObject.IsSetRateMode())
            {
                context.Writer.WritePropertyName("rateMode");
                context.Writer.Write(requestObject.RateMode);
            }

            if(requestObject.IsSetScte35Pid())
            {
                context.Writer.WritePropertyName("scte35Pid");
                context.Writer.Write(requestObject.Scte35Pid);
            }

            if(requestObject.IsSetScte35Source())
            {
                context.Writer.WritePropertyName("scte35Source");
                context.Writer.Write(requestObject.Scte35Source);
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