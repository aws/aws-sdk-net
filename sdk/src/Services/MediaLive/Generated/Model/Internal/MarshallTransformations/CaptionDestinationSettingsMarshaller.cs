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
    /// CaptionDestinationSettings Marshaller
    /// </summary>
    public class CaptionDestinationSettingsMarshaller : IRequestMarshaller<CaptionDestinationSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CaptionDestinationSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAribDestinationSettings())
            {
                context.Writer.WritePropertyName("aribDestinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = AribDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AribDestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBurnInDestinationSettings())
            {
                context.Writer.WritePropertyName("burnInDestinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = BurnInDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.BurnInDestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDvbSubDestinationSettings())
            {
                context.Writer.WritePropertyName("dvbSubDestinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = DvbSubDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DvbSubDestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEbuTtDDestinationSettings())
            {
                context.Writer.WritePropertyName("ebuTtDDestinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = EbuTtDDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.EbuTtDDestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEmbeddedDestinationSettings())
            {
                context.Writer.WritePropertyName("embeddedDestinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = EmbeddedDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.EmbeddedDestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEmbeddedPlusScte20DestinationSettings())
            {
                context.Writer.WritePropertyName("embeddedPlusScte20DestinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = EmbeddedPlusScte20DestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.EmbeddedPlusScte20DestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRtmpCaptionInfoDestinationSettings())
            {
                context.Writer.WritePropertyName("rtmpCaptionInfoDestinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = RtmpCaptionInfoDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.RtmpCaptionInfoDestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScte20PlusEmbeddedDestinationSettings())
            {
                context.Writer.WritePropertyName("scte20PlusEmbeddedDestinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = Scte20PlusEmbeddedDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Scte20PlusEmbeddedDestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScte27DestinationSettings())
            {
                context.Writer.WritePropertyName("scte27DestinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = Scte27DestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Scte27DestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSmpteTtDestinationSettings())
            {
                context.Writer.WritePropertyName("smpteTtDestinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = SmpteTtDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.SmpteTtDestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTeletextDestinationSettings())
            {
                context.Writer.WritePropertyName("teletextDestinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = TeletextDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.TeletextDestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTtmlDestinationSettings())
            {
                context.Writer.WritePropertyName("ttmlDestinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = TtmlDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.TtmlDestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWebvttDestinationSettings())
            {
                context.Writer.WritePropertyName("webvttDestinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = WebvttDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.WebvttDestinationSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CaptionDestinationSettingsMarshaller Instance = new CaptionDestinationSettingsMarshaller();

    }
}