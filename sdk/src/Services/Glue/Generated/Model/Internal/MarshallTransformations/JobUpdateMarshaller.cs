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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JobUpdate Marshaller
    /// </summary>
    public class JobUpdateMarshaller : IRequestMarshaller<JobUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JobUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllocatedCapacity())
            {
                context.Writer.WritePropertyName("AllocatedCapacity");
                context.Writer.WriteNumberValue(requestObject.AllocatedCapacity.Value);
            }

            if(requestObject.IsSetCodeGenConfigurationNodes())
            {
                context.Writer.WritePropertyName("CodeGenConfigurationNodes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectCodeGenConfigurationNodesKvp in requestObject.CodeGenConfigurationNodes)
                {
                    context.Writer.WritePropertyName(requestObjectCodeGenConfigurationNodesKvp.Key);
                    var requestObjectCodeGenConfigurationNodesValue = requestObjectCodeGenConfigurationNodesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = CodeGenConfigurationNodeMarshaller.Instance;
                    marshaller.Marshall(requestObjectCodeGenConfigurationNodesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("Command");
                context.Writer.WriteStartObject();

                var marshaller = JobCommandMarshaller.Instance;
                marshaller.Marshall(requestObject.Command, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConnections())
            {
                context.Writer.WritePropertyName("Connections");
                context.Writer.WriteStartObject();

                var marshaller = ConnectionsListMarshaller.Instance;
                marshaller.Marshall(requestObject.Connections, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultArguments())
            {
                context.Writer.WritePropertyName("DefaultArguments");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDefaultArgumentsKvp in requestObject.DefaultArguments)
                {
                    context.Writer.WritePropertyName(requestObjectDefaultArgumentsKvp.Key);
                    var requestObjectDefaultArgumentsValue = requestObjectDefaultArgumentsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectDefaultArgumentsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetExecutionClass())
            {
                context.Writer.WritePropertyName("ExecutionClass");
                context.Writer.WriteStringValue(requestObject.ExecutionClass);
            }

            if(requestObject.IsSetExecutionProperty())
            {
                context.Writer.WritePropertyName("ExecutionProperty");
                context.Writer.WriteStartObject();

                var marshaller = ExecutionPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.ExecutionProperty, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGlueVersion())
            {
                context.Writer.WritePropertyName("GlueVersion");
                context.Writer.WriteStringValue(requestObject.GlueVersion);
            }

            if(requestObject.IsSetJobMode())
            {
                context.Writer.WritePropertyName("JobMode");
                context.Writer.WriteStringValue(requestObject.JobMode);
            }

            if(requestObject.IsSetJobRunQueuingEnabled())
            {
                context.Writer.WritePropertyName("JobRunQueuingEnabled");
                context.Writer.WriteBooleanValue(requestObject.JobRunQueuingEnabled.Value);
            }

            if(requestObject.IsSetLogUri())
            {
                context.Writer.WritePropertyName("LogUri");
                context.Writer.WriteStringValue(requestObject.LogUri);
            }

            if(requestObject.IsSetMaintenanceWindow())
            {
                context.Writer.WritePropertyName("MaintenanceWindow");
                context.Writer.WriteStringValue(requestObject.MaintenanceWindow);
            }

            if(requestObject.IsSetMaxCapacity())
            {
                context.Writer.WritePropertyName("MaxCapacity");
                if(StringUtils.IsSpecialDoubleValue(requestObject.MaxCapacity.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.MaxCapacity.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.MaxCapacity.Value);
                }
            }

            if(requestObject.IsSetMaxRetries())
            {
                context.Writer.WritePropertyName("MaxRetries");
                context.Writer.WriteNumberValue(requestObject.MaxRetries.Value);
            }

            if(requestObject.IsSetNonOverridableArguments())
            {
                context.Writer.WritePropertyName("NonOverridableArguments");
                context.Writer.WriteStartObject();
                foreach (var requestObjectNonOverridableArgumentsKvp in requestObject.NonOverridableArguments)
                {
                    context.Writer.WritePropertyName(requestObjectNonOverridableArgumentsKvp.Key);
                    var requestObjectNonOverridableArgumentsValue = requestObjectNonOverridableArgumentsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectNonOverridableArgumentsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNotificationProperty())
            {
                context.Writer.WritePropertyName("NotificationProperty");
                context.Writer.WriteStartObject();

                var marshaller = NotificationPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.NotificationProperty, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNumberOfWorkers())
            {
                context.Writer.WritePropertyName("NumberOfWorkers");
                context.Writer.WriteNumberValue(requestObject.NumberOfWorkers.Value);
            }

            if(requestObject.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(requestObject.Role);
            }

            if(requestObject.IsSetSecurityConfiguration())
            {
                context.Writer.WritePropertyName("SecurityConfiguration");
                context.Writer.WriteStringValue(requestObject.SecurityConfiguration);
            }

            if(requestObject.IsSetSourceControlDetails())
            {
                context.Writer.WritePropertyName("SourceControlDetails");
                context.Writer.WriteStartObject();

                var marshaller = SourceControlDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceControlDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimeout())
            {
                context.Writer.WritePropertyName("Timeout");
                context.Writer.WriteNumberValue(requestObject.Timeout.Value);
            }

            if(requestObject.IsSetWorkerType())
            {
                context.Writer.WritePropertyName("WorkerType");
                context.Writer.WriteStringValue(requestObject.WorkerType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JobUpdateMarshaller Instance = new JobUpdateMarshaller();

    }
}