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
            if(requestObject.IsSetCodec())
            {
                context.Writer.WritePropertyName("codec");
                context.Writer.Write(requestObject.Codec);
            }

            if(requestObject.IsSetFrameCaptureSettings())
            {
                context.Writer.WritePropertyName("frameCaptureSettings");
                context.Writer.WriteObjectStart();

                var marshaller = FrameCaptureSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.FrameCaptureSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetH264Settings())
            {
                context.Writer.WritePropertyName("h264Settings");
                context.Writer.WriteObjectStart();

                var marshaller = H264SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.H264Settings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetH265Settings())
            {
                context.Writer.WritePropertyName("h265Settings");
                context.Writer.WriteObjectStart();

                var marshaller = H265SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.H265Settings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMpeg2Settings())
            {
                context.Writer.WritePropertyName("mpeg2Settings");
                context.Writer.WriteObjectStart();

                var marshaller = Mpeg2SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Mpeg2Settings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetProresSettings())
            {
                context.Writer.WritePropertyName("proresSettings");
                context.Writer.WriteObjectStart();

                var marshaller = ProresSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ProresSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static VideoCodecSettingsMarshaller Instance = new VideoCodecSettingsMarshaller();

    }
}