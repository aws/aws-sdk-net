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
    /// AudioSelectorSettings Marshaller
    /// </summary>
    public class AudioSelectorSettingsMarshaller : IRequestMarshaller<AudioSelectorSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AudioSelectorSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudioHlsRenditionSelection())
            {
                context.Writer.WritePropertyName("audioHlsRenditionSelection");
                context.Writer.WriteStartObject();

                var marshaller = AudioHlsRenditionSelectionMarshaller.Instance;
                marshaller.Marshall(requestObject.AudioHlsRenditionSelection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAudioLanguageSelection())
            {
                context.Writer.WritePropertyName("audioLanguageSelection");
                context.Writer.WriteStartObject();

                var marshaller = AudioLanguageSelectionMarshaller.Instance;
                marshaller.Marshall(requestObject.AudioLanguageSelection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAudioPidSelection())
            {
                context.Writer.WritePropertyName("audioPidSelection");
                context.Writer.WriteStartObject();

                var marshaller = AudioPidSelectionMarshaller.Instance;
                marshaller.Marshall(requestObject.AudioPidSelection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAudioTrackSelection())
            {
                context.Writer.WritePropertyName("audioTrackSelection");
                context.Writer.WriteStartObject();

                var marshaller = AudioTrackSelectionMarshaller.Instance;
                marshaller.Marshall(requestObject.AudioTrackSelection, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AudioSelectorSettingsMarshaller Instance = new AudioSelectorSettingsMarshaller();

    }
}