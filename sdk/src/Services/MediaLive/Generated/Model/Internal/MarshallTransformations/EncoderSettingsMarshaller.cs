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
    /// EncoderSettings Marshaller
    /// </summary>
    public class EncoderSettingsMarshaller : IRequestMarshaller<EncoderSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EncoderSettings requestObject, JsonMarshallerContext context)
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

            if(requestObject.IsSetAvailBlanking())
            {
                context.Writer.WritePropertyName("availBlanking");
                context.Writer.WriteStartObject();

                var marshaller = AvailBlankingMarshaller.Instance;
                marshaller.Marshall(requestObject.AvailBlanking, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAvailConfiguration())
            {
                context.Writer.WritePropertyName("availConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AvailConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AvailConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBlackoutSlate())
            {
                context.Writer.WritePropertyName("blackoutSlate");
                context.Writer.WriteStartObject();

                var marshaller = BlackoutSlateMarshaller.Instance;
                marshaller.Marshall(requestObject.BlackoutSlate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCaptionDescriptions())
            {
                context.Writer.WritePropertyName("captionDescriptions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCaptionDescriptionsListValue in requestObject.CaptionDescriptions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CaptionDescriptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectCaptionDescriptionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetColorCorrectionSettings())
            {
                context.Writer.WritePropertyName("colorCorrectionSettings");
                context.Writer.WriteStartObject();

                var marshaller = ColorCorrectionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ColorCorrectionSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFeatureActivations())
            {
                context.Writer.WritePropertyName("featureActivations");
                context.Writer.WriteStartObject();

                var marshaller = FeatureActivationsMarshaller.Instance;
                marshaller.Marshall(requestObject.FeatureActivations, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGlobalConfiguration())
            {
                context.Writer.WritePropertyName("globalConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = GlobalConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.GlobalConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMotionGraphicsConfiguration())
            {
                context.Writer.WritePropertyName("motionGraphicsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = MotionGraphicsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.MotionGraphicsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNielsenConfiguration())
            {
                context.Writer.WritePropertyName("nielsenConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = NielsenConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NielsenConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOutputGroups())
            {
                context.Writer.WritePropertyName("outputGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOutputGroupsListValue in requestObject.OutputGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = OutputGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetThumbnailConfiguration())
            {
                context.Writer.WritePropertyName("thumbnailConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ThumbnailConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ThumbnailConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimecodeConfig())
            {
                context.Writer.WritePropertyName("timecodeConfig");
                context.Writer.WriteStartObject();

                var marshaller = TimecodeConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TimecodeConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVideoDescriptions())
            {
                context.Writer.WritePropertyName("videoDescriptions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVideoDescriptionsListValue in requestObject.VideoDescriptions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VideoDescriptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectVideoDescriptionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EncoderSettingsMarshaller Instance = new EncoderSettingsMarshaller();

    }
}