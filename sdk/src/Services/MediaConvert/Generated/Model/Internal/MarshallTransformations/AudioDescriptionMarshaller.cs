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
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AudioDescription Marshaller
    /// </summary>
    public class AudioDescriptionMarshaller : IRequestMarshaller<AudioDescription, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AudioDescription requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudioChannelTaggingSettings())
            {
                context.Writer.WritePropertyName("audioChannelTaggingSettings");
                context.Writer.WriteStartObject();

                var marshaller = AudioChannelTaggingSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AudioChannelTaggingSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAudioNormalizationSettings())
            {
                context.Writer.WritePropertyName("audioNormalizationSettings");
                context.Writer.WriteStartObject();

                var marshaller = AudioNormalizationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AudioNormalizationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAudioSourceName())
            {
                context.Writer.WritePropertyName("audioSourceName");
                context.Writer.WriteStringValue(requestObject.AudioSourceName);
            }

            if(requestObject.IsSetAudioType())
            {
                context.Writer.WritePropertyName("audioType");
                context.Writer.WriteNumberValue(requestObject.AudioType.Value);
            }

            if(requestObject.IsSetAudioTypeControl())
            {
                context.Writer.WritePropertyName("audioTypeControl");
                context.Writer.WriteStringValue(requestObject.AudioTypeControl);
            }

            if(requestObject.IsSetCodecSettings())
            {
                context.Writer.WritePropertyName("codecSettings");
                context.Writer.WriteStartObject();

                var marshaller = AudioCodecSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.CodecSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomLanguageCode())
            {
                context.Writer.WritePropertyName("customLanguageCode");
                context.Writer.WriteStringValue(requestObject.CustomLanguageCode);
            }

            if(requestObject.IsSetLanguageCode())
            {
                context.Writer.WritePropertyName("languageCode");
                context.Writer.WriteStringValue(requestObject.LanguageCode);
            }

            if(requestObject.IsSetLanguageCodeControl())
            {
                context.Writer.WritePropertyName("languageCodeControl");
                context.Writer.WriteStringValue(requestObject.LanguageCodeControl);
            }

            if(requestObject.IsSetRemixSettings())
            {
                context.Writer.WritePropertyName("remixSettings");
                context.Writer.WriteStartObject();

                var marshaller = RemixSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.RemixSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStreamName())
            {
                context.Writer.WritePropertyName("streamName");
                context.Writer.WriteStringValue(requestObject.StreamName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AudioDescriptionMarshaller Instance = new AudioDescriptionMarshaller();

    }
}