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
                context.Writer.Write(requestObject.AudioPids);
            }

            if(requestObject.IsSetEcmPid())
            {
                context.Writer.WritePropertyName("ecmPid");
                context.Writer.Write(requestObject.EcmPid);
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

            if(requestObject.IsSetScte35Behavior())
            {
                context.Writer.WritePropertyName("scte35Behavior");
                context.Writer.Write(requestObject.Scte35Behavior);
            }

            if(requestObject.IsSetScte35Pid())
            {
                context.Writer.WritePropertyName("scte35Pid");
                context.Writer.Write(requestObject.Scte35Pid);
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
        public readonly static M3u8SettingsMarshaller Instance = new M3u8SettingsMarshaller();

    }
}