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
            if(requestObject.IsSetAdAvailOffset())
            {
                context.Writer.WritePropertyName("adAvailOffset");
                context.Writer.Write(requestObject.AdAvailOffset);
            }

            if(requestObject.IsSetAvailBlanking())
            {
                context.Writer.WritePropertyName("availBlanking");
                context.Writer.WriteObjectStart();

                var marshaller = AvailBlankingMarshaller.Instance;
                marshaller.Marshall(requestObject.AvailBlanking, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEsam())
            {
                context.Writer.WritePropertyName("esam");
                context.Writer.WriteObjectStart();

                var marshaller = EsamSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Esam, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInputs())
            {
                context.Writer.WritePropertyName("inputs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInputsListValue in requestObject.Inputs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = InputTemplateMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMotionImageInserter())
            {
                context.Writer.WritePropertyName("motionImageInserter");
                context.Writer.WriteObjectStart();

                var marshaller = MotionImageInserterMarshaller.Instance;
                marshaller.Marshall(requestObject.MotionImageInserter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNielsenConfiguration())
            {
                context.Writer.WritePropertyName("nielsenConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = NielsenConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NielsenConfiguration, context);

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

            if(requestObject.IsSetTimedMetadataInsertion())
            {
                context.Writer.WritePropertyName("timedMetadataInsertion");
                context.Writer.WriteObjectStart();

                var marshaller = TimedMetadataInsertionMarshaller.Instance;
                marshaller.Marshall(requestObject.TimedMetadataInsertion, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static JobTemplateSettingsMarshaller Instance = new JobTemplateSettingsMarshaller();

    }
}