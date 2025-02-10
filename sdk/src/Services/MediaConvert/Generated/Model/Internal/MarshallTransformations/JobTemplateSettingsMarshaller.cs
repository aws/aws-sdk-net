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
    /// JobTemplateSettings Marshaller
    /// </summary>
    public class JobTemplateSettingsMarshaller : IRequestMarshaller<JobTemplateSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JobTemplateSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdAvailOffset())
            {
                context.Writer.WritePropertyName("adAvailOffset");
                context.Writer.WriteNumberValue(requestObject.AdAvailOffset.Value);
            }

            if(requestObject.IsSetAvailBlanking())
            {
                context.Writer.WritePropertyName("availBlanking");
                context.Writer.WriteStartObject();

                var marshaller = AvailBlankingMarshaller.Instance;
                marshaller.Marshall(requestObject.AvailBlanking, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetColorConversion3DLUTSettings())
            {
                context.Writer.WritePropertyName("colorConversion3DLUTSettings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectColorConversion3DLUTSettingsListValue in requestObject.ColorConversion3DLUTSettings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ColorConversion3DLUTSettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectColorConversion3DLUTSettingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEsam())
            {
                context.Writer.WritePropertyName("esam");
                context.Writer.WriteStartObject();

                var marshaller = EsamSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Esam, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExtendedDataServices())
            {
                context.Writer.WritePropertyName("extendedDataServices");
                context.Writer.WriteStartObject();

                var marshaller = ExtendedDataServicesMarshaller.Instance;
                marshaller.Marshall(requestObject.ExtendedDataServices, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFollowSource())
            {
                context.Writer.WritePropertyName("followSource");
                context.Writer.WriteNumberValue(requestObject.FollowSource.Value);
            }

            if(requestObject.IsSetInputs())
            {
                context.Writer.WritePropertyName("inputs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInputsListValue in requestObject.Inputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputTemplateMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetKantarWatermark())
            {
                context.Writer.WritePropertyName("kantarWatermark");
                context.Writer.WriteStartObject();

                var marshaller = KantarWatermarkSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.KantarWatermark, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMotionImageInserter())
            {
                context.Writer.WritePropertyName("motionImageInserter");
                context.Writer.WriteStartObject();

                var marshaller = MotionImageInserterMarshaller.Instance;
                marshaller.Marshall(requestObject.MotionImageInserter, context);

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

            if(requestObject.IsSetNielsenNonLinearWatermark())
            {
                context.Writer.WritePropertyName("nielsenNonLinearWatermark");
                context.Writer.WriteStartObject();

                var marshaller = NielsenNonLinearWatermarkSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.NielsenNonLinearWatermark, context);

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

            if(requestObject.IsSetTimecodeConfig())
            {
                context.Writer.WritePropertyName("timecodeConfig");
                context.Writer.WriteStartObject();

                var marshaller = TimecodeConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TimecodeConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimedMetadataInsertion())
            {
                context.Writer.WritePropertyName("timedMetadataInsertion");
                context.Writer.WriteStartObject();

                var marshaller = TimedMetadataInsertionMarshaller.Instance;
                marshaller.Marshall(requestObject.TimedMetadataInsertion, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JobTemplateSettingsMarshaller Instance = new JobTemplateSettingsMarshaller();

    }
}