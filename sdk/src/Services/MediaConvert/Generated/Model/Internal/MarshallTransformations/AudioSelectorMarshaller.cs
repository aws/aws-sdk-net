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

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AudioSelector Marshaller
    /// </summary>
    public class AudioSelectorMarshaller : IRequestMarshaller<AudioSelector, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AudioSelector requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudioDurationCorrection())
            {
                context.Writer.WritePropertyName("audioDurationCorrection");
                context.Writer.Write(requestObject.AudioDurationCorrection);
            }

            if(requestObject.IsSetCustomLanguageCode())
            {
                context.Writer.WritePropertyName("customLanguageCode");
                context.Writer.Write(requestObject.CustomLanguageCode);
            }

            if(requestObject.IsSetDefaultSelection())
            {
                context.Writer.WritePropertyName("defaultSelection");
                context.Writer.Write(requestObject.DefaultSelection);
            }

            if(requestObject.IsSetExternalAudioFileInput())
            {
                context.Writer.WritePropertyName("externalAudioFileInput");
                context.Writer.Write(requestObject.ExternalAudioFileInput);
            }

            if(requestObject.IsSetHlsRenditionGroupSettings())
            {
                context.Writer.WritePropertyName("hlsRenditionGroupSettings");
                context.Writer.WriteObjectStart();

                var marshaller = HlsRenditionGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsRenditionGroupSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLanguageCode())
            {
                context.Writer.WritePropertyName("languageCode");
                context.Writer.Write(requestObject.LanguageCode);
            }

            if(requestObject.IsSetOffset())
            {
                context.Writer.WritePropertyName("offset");
                context.Writer.Write(requestObject.Offset);
            }

            if(requestObject.IsSetPids())
            {
                context.Writer.WritePropertyName("pids");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPidsListValue in requestObject.Pids)
                {
                        context.Writer.Write(requestObjectPidsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProgramSelection())
            {
                context.Writer.WritePropertyName("programSelection");
                context.Writer.Write(requestObject.ProgramSelection);
            }

            if(requestObject.IsSetRemixSettings())
            {
                context.Writer.WritePropertyName("remixSettings");
                context.Writer.WriteObjectStart();

                var marshaller = RemixSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.RemixSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSelectorType())
            {
                context.Writer.WritePropertyName("selectorType");
                context.Writer.Write(requestObject.SelectorType);
            }

            if(requestObject.IsSetStreams())
            {
                context.Writer.WritePropertyName("streams");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStreamsListValue in requestObject.Streams)
                {
                        context.Writer.Write(requestObjectStreamsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTracks())
            {
                context.Writer.WritePropertyName("tracks");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTracksListValue in requestObject.Tracks)
                {
                        context.Writer.Write(requestObjectTracksListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AudioSelectorMarshaller Instance = new AudioSelectorMarshaller();

    }
}