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

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MultiplexProgramPacketIdentifiersMap Marshaller
    /// </summary>
    public class MultiplexProgramPacketIdentifiersMapMarshaller : IRequestMarshaller<MultiplexProgramPacketIdentifiersMap, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MultiplexProgramPacketIdentifiersMap requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAribCaptionsPid())
            {
                context.Writer.WritePropertyName("aribCaptionsPid");
                context.Writer.Write(requestObject.AribCaptionsPid);
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

            if(requestObject.IsSetDvbTeletextPid())
            {
                context.Writer.WritePropertyName("dvbTeletextPid");
                context.Writer.Write(requestObject.DvbTeletextPid);
            }

            if(requestObject.IsSetDvbTeletextPids())
            {
                context.Writer.WritePropertyName("dvbTeletextPids");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDvbTeletextPidsListValue in requestObject.DvbTeletextPids)
                {
                        context.Writer.Write(requestObjectDvbTeletextPidsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEcmPid())
            {
                context.Writer.WritePropertyName("ecmPid");
                context.Writer.Write(requestObject.EcmPid);
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

            if(requestObject.IsSetKlvDataPids())
            {
                context.Writer.WritePropertyName("klvDataPids");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectKlvDataPidsListValue in requestObject.KlvDataPids)
                {
                        context.Writer.Write(requestObjectKlvDataPidsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPcrPid())
            {
                context.Writer.WritePropertyName("pcrPid");
                context.Writer.Write(requestObject.PcrPid);
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

            if(requestObject.IsSetScte27Pids())
            {
                context.Writer.WritePropertyName("scte27Pids");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScte27PidsListValue in requestObject.Scte27Pids)
                {
                        context.Writer.Write(requestObjectScte27PidsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScte35Pid())
            {
                context.Writer.WritePropertyName("scte35Pid");
                context.Writer.Write(requestObject.Scte35Pid);
            }

            if(requestObject.IsSetSmpte2038Pid())
            {
                context.Writer.WritePropertyName("smpte2038Pid");
                context.Writer.Write(requestObject.Smpte2038Pid);
            }

            if(requestObject.IsSetTimedMetadataPid())
            {
                context.Writer.WritePropertyName("timedMetadataPid");
                context.Writer.Write(requestObject.TimedMetadataPid);
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
        public readonly static MultiplexProgramPacketIdentifiersMapMarshaller Instance = new MultiplexProgramPacketIdentifiersMapMarshaller();

    }
}