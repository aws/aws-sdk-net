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
    /// VideoCodecSettings Marshaller
    /// </summary>
    public class VideoCodecSettingsMarshaller : IRequestMarshaller<VideoCodecSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VideoCodecSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAv1Settings())
            {
                context.Writer.WritePropertyName("av1Settings");
                context.Writer.WriteStartObject();

                var marshaller = Av1SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Av1Settings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFrameCaptureSettings())
            {
                context.Writer.WritePropertyName("frameCaptureSettings");
                context.Writer.WriteStartObject();

                var marshaller = FrameCaptureSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.FrameCaptureSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetH264Settings())
            {
                context.Writer.WritePropertyName("h264Settings");
                context.Writer.WriteStartObject();

                var marshaller = H264SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.H264Settings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetH265Settings())
            {
                context.Writer.WritePropertyName("h265Settings");
                context.Writer.WriteStartObject();

                var marshaller = H265SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.H265Settings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMpeg2Settings())
            {
                context.Writer.WritePropertyName("mpeg2Settings");
                context.Writer.WriteStartObject();

                var marshaller = Mpeg2SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Mpeg2Settings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VideoCodecSettingsMarshaller Instance = new VideoCodecSettingsMarshaller();

    }
}