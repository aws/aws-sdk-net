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
    /// PresetSettings Marshaller
    /// </summary>
    public class PresetSettingsMarshaller : IRequestMarshaller<PresetSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PresetSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudioDescriptions())
            {
                context.Writer.WritePropertyName("audioDescriptions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAudioDescriptionsListValue in requestObject.AudioDescriptions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AudioDescriptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectAudioDescriptionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCaptionDescriptions())
            {
                context.Writer.WritePropertyName("captionDescriptions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCaptionDescriptionsListValue in requestObject.CaptionDescriptions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CaptionDescriptionPresetMarshaller.Instance;
                    marshaller.Marshall(requestObjectCaptionDescriptionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetContainerSettings())
            {
                context.Writer.WritePropertyName("containerSettings");
                context.Writer.WriteStartObject();

                var marshaller = ContainerSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainerSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVideoDescription())
            {
                context.Writer.WritePropertyName("videoDescription");
                context.Writer.WriteStartObject();

                var marshaller = VideoDescriptionMarshaller.Instance;
                marshaller.Marshall(requestObject.VideoDescription, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PresetSettingsMarshaller Instance = new PresetSettingsMarshaller();

    }
}