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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ArtifactsConcatenationConfiguration Marshaller
    /// </summary>
    public class ArtifactsConcatenationConfigurationMarshaller : IRequestMarshaller<ArtifactsConcatenationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ArtifactsConcatenationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudio())
            {
                context.Writer.WritePropertyName("Audio");
                context.Writer.WriteObjectStart();

                var marshaller = AudioConcatenationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Audio, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCompositedVideo())
            {
                context.Writer.WritePropertyName("CompositedVideo");
                context.Writer.WriteObjectStart();

                var marshaller = CompositedVideoConcatenationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CompositedVideo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetContent())
            {
                context.Writer.WritePropertyName("Content");
                context.Writer.WriteObjectStart();

                var marshaller = ContentConcatenationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Content, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDataChannel())
            {
                context.Writer.WritePropertyName("DataChannel");
                context.Writer.WriteObjectStart();

                var marshaller = DataChannelConcatenationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DataChannel, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMeetingEvents())
            {
                context.Writer.WritePropertyName("MeetingEvents");
                context.Writer.WriteObjectStart();

                var marshaller = MeetingEventsConcatenationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.MeetingEvents, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTranscriptionMessages())
            {
                context.Writer.WritePropertyName("TranscriptionMessages");
                context.Writer.WriteObjectStart();

                var marshaller = TranscriptionMessagesConcatenationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.TranscriptionMessages, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVideo())
            {
                context.Writer.WritePropertyName("Video");
                context.Writer.WriteObjectStart();

                var marshaller = VideoConcatenationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Video, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ArtifactsConcatenationConfigurationMarshaller Instance = new ArtifactsConcatenationConfigurationMarshaller();

    }
}