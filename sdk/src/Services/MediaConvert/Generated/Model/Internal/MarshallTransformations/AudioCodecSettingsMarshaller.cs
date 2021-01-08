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
    /// AudioCodecSettings Marshaller
    /// </summary>       
    public class AudioCodecSettingsMarshaller : IRequestMarshaller<AudioCodecSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AudioCodecSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAacSettings())
            {
                context.Writer.WritePropertyName("aacSettings");
                context.Writer.WriteObjectStart();

                var marshaller = AacSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AacSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAc3Settings())
            {
                context.Writer.WritePropertyName("ac3Settings");
                context.Writer.WriteObjectStart();

                var marshaller = Ac3SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Ac3Settings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAiffSettings())
            {
                context.Writer.WritePropertyName("aiffSettings");
                context.Writer.WriteObjectStart();

                var marshaller = AiffSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AiffSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCodec())
            {
                context.Writer.WritePropertyName("codec");
                context.Writer.Write(requestObject.Codec);
            }

            if(requestObject.IsSetEac3AtmosSettings())
            {
                context.Writer.WritePropertyName("eac3AtmosSettings");
                context.Writer.WriteObjectStart();

                var marshaller = Eac3AtmosSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Eac3AtmosSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEac3Settings())
            {
                context.Writer.WritePropertyName("eac3Settings");
                context.Writer.WriteObjectStart();

                var marshaller = Eac3SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Eac3Settings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMp2Settings())
            {
                context.Writer.WritePropertyName("mp2Settings");
                context.Writer.WriteObjectStart();

                var marshaller = Mp2SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Mp2Settings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMp3Settings())
            {
                context.Writer.WritePropertyName("mp3Settings");
                context.Writer.WriteObjectStart();

                var marshaller = Mp3SettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Mp3Settings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOpusSettings())
            {
                context.Writer.WritePropertyName("opusSettings");
                context.Writer.WriteObjectStart();

                var marshaller = OpusSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.OpusSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVorbisSettings())
            {
                context.Writer.WritePropertyName("vorbisSettings");
                context.Writer.WriteObjectStart();

                var marshaller = VorbisSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.VorbisSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWavSettings())
            {
                context.Writer.WritePropertyName("wavSettings");
                context.Writer.WriteObjectStart();

                var marshaller = WavSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.WavSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AudioCodecSettingsMarshaller Instance = new AudioCodecSettingsMarshaller();

    }
}