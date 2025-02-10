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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRContainers.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EMRContainers.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JobTemplateData Marshaller
    /// </summary>
    public class JobTemplateDataMarshaller : IRequestMarshaller<JobTemplateData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JobTemplateData requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConfigurationOverrides())
            {
                context.Writer.WritePropertyName("configurationOverrides");
                context.Writer.WriteStartObject();

                var marshaller = ParametricConfigurationOverridesMarshaller.Instance;
                marshaller.Marshall(requestObject.ConfigurationOverrides, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("executionRoleArn");
                context.Writer.WriteStringValue(requestObject.ExecutionRoleArn);
            }

            if(requestObject.IsSetJobDriver())
            {
                context.Writer.WritePropertyName("jobDriver");
                context.Writer.WriteStartObject();

                var marshaller = JobDriverMarshaller.Instance;
                marshaller.Marshall(requestObject.JobDriver, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJobTags())
            {
                context.Writer.WritePropertyName("jobTags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectJobTagsKvp in requestObject.JobTags)
                {
                    context.Writer.WritePropertyName(requestObjectJobTagsKvp.Key);
                    var requestObjectJobTagsValue = requestObjectJobTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectJobTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParameterConfiguration())
            {
                context.Writer.WritePropertyName("parameterConfiguration");
                context.Writer.WriteStartObject();
                foreach (var requestObjectParameterConfigurationKvp in requestObject.ParameterConfiguration)
                {
                    context.Writer.WritePropertyName(requestObjectParameterConfigurationKvp.Key);
                    var requestObjectParameterConfigurationValue = requestObjectParameterConfigurationKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = TemplateParameterConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectParameterConfigurationValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReleaseLabel())
            {
                context.Writer.WritePropertyName("releaseLabel");
                context.Writer.WriteStringValue(requestObject.ReleaseLabel);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JobTemplateDataMarshaller Instance = new JobTemplateDataMarshaller();

    }
}