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
    /// OutputGroupSettings Marshaller
    /// </summary>
    public class OutputGroupSettingsMarshaller : IRequestMarshaller<OutputGroupSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OutputGroupSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArchiveGroupSettings())
            {
                context.Writer.WritePropertyName("archiveGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = ArchiveGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ArchiveGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCmafIngestGroupSettings())
            {
                context.Writer.WritePropertyName("cmafIngestGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = CmafIngestGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.CmafIngestGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFrameCaptureGroupSettings())
            {
                context.Writer.WritePropertyName("frameCaptureGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = FrameCaptureGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.FrameCaptureGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHlsGroupSettings())
            {
                context.Writer.WritePropertyName("hlsGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = HlsGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMediaPackageGroupSettings())
            {
                context.Writer.WritePropertyName("mediaPackageGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = MediaPackageGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MediaPackageGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMsSmoothGroupSettings())
            {
                context.Writer.WritePropertyName("msSmoothGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = MsSmoothGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MsSmoothGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMultiplexGroupSettings())
            {
                context.Writer.WritePropertyName("multiplexGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = MultiplexGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MultiplexGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRtmpGroupSettings())
            {
                context.Writer.WritePropertyName("rtmpGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = RtmpGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.RtmpGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSrtGroupSettings())
            {
                context.Writer.WritePropertyName("srtGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = SrtGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.SrtGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUdpGroupSettings())
            {
                context.Writer.WritePropertyName("udpGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = UdpGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.UdpGroupSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OutputGroupSettingsMarshaller Instance = new OutputGroupSettingsMarshaller();

    }
}