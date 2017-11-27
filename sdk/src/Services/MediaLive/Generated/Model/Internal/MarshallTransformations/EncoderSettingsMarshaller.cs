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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAudioDescriptions())
            {
                context.Writer.WritePropertyName("audioDescriptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAudioDescriptionsListValue in requestObject.AudioDescriptions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AudioDescriptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectAudioDescriptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAvailBlanking())
            {
                context.Writer.WritePropertyName("availBlanking");
                context.Writer.WriteObjectStart();

                var marshaller = AvailBlankingMarshaller.Instance;
                marshaller.Marshall(requestObject.AvailBlanking, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAvailConfiguration())
            {
                context.Writer.WritePropertyName("availConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AvailConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AvailConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBlackoutSlate())
            {
                context.Writer.WritePropertyName("blackoutSlate");
                context.Writer.WriteObjectStart();

                var marshaller = BlackoutSlateMarshaller.Instance;
                marshaller.Marshall(requestObject.BlackoutSlate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCaptionDescriptions())
            {
                context.Writer.WritePropertyName("captionDescriptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCaptionDescriptionsListValue in requestObject.CaptionDescriptions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CaptionDescriptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectCaptionDescriptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetGlobalConfiguration())
            {
                context.Writer.WritePropertyName("globalConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = GlobalConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.GlobalConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOutputGroups())
            {
                context.Writer.WritePropertyName("outputGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOutputGroupsListValue in requestObject.OutputGroups)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = OutputGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputGroupsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTimecodeConfig())
            {
                context.Writer.WritePropertyName("timecodeConfig");
                context.Writer.WriteObjectStart();

                var marshaller = TimecodeConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TimecodeConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVideoDescriptions())
            {
                context.Writer.WritePropertyName("videoDescriptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVideoDescriptionsListValue in requestObject.VideoDescriptions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = VideoDescriptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectVideoDescriptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static EncoderSettingsMarshaller Instance = new EncoderSettingsMarshaller();

    }
}