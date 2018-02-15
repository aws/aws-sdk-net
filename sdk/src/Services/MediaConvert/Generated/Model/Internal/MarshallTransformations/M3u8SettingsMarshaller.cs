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

            if(requestObject.IsSetNielsenId3())
            {
                context.Writer.WritePropertyName("nielsenId3");
                context.Writer.Write(requestObject.NielsenId3);
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

            if(requestObject.IsSetTimedMetadata())
            {
                context.Writer.WritePropertyName("timedMetadata");
                context.Writer.Write(requestObject.TimedMetadata);
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
        public readonly static M3u8SettingsMarshaller Instance = new M3u8SettingsMarshaller();

    }
}