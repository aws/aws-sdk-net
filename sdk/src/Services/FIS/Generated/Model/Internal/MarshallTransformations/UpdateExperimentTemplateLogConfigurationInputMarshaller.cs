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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FIS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.FIS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateExperimentTemplateLogConfigurationInput Marshaller
    /// </summary>
    public class UpdateExperimentTemplateLogConfigurationInputMarshaller : IRequestMarshaller<UpdateExperimentTemplateLogConfigurationInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateExperimentTemplateLogConfigurationInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudWatchLogsConfiguration())
            {
                context.Writer.WritePropertyName("cloudWatchLogsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ExperimentTemplateCloudWatchLogsLogConfigurationInputMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchLogsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLogSchemaVersion())
            {
                context.Writer.WritePropertyName("logSchemaVersion");
                context.Writer.WriteNumberValue(requestObject.LogSchemaVersion.Value);
            }

            if(requestObject.IsSetS3Configuration())
            {
                context.Writer.WritePropertyName("s3Configuration");
                context.Writer.WriteStartObject();

                var marshaller = ExperimentTemplateS3LogConfigurationInputMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Configuration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateExperimentTemplateLogConfigurationInputMarshaller Instance = new UpdateExperimentTemplateLogConfigurationInputMarshaller();

    }
}