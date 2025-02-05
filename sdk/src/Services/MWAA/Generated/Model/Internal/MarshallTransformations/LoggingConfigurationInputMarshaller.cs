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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MWAA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MWAA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LoggingConfigurationInput Marshaller
    /// </summary>
    public class LoggingConfigurationInputMarshaller : IRequestMarshaller<LoggingConfigurationInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LoggingConfigurationInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDagProcessingLogs())
            {
                context.Writer.WritePropertyName("DagProcessingLogs");
                context.Writer.WriteStartObject();

                var marshaller = ModuleLoggingConfigurationInputMarshaller.Instance;
                marshaller.Marshall(requestObject.DagProcessingLogs, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSchedulerLogs())
            {
                context.Writer.WritePropertyName("SchedulerLogs");
                context.Writer.WriteStartObject();

                var marshaller = ModuleLoggingConfigurationInputMarshaller.Instance;
                marshaller.Marshall(requestObject.SchedulerLogs, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTaskLogs())
            {
                context.Writer.WritePropertyName("TaskLogs");
                context.Writer.WriteStartObject();

                var marshaller = ModuleLoggingConfigurationInputMarshaller.Instance;
                marshaller.Marshall(requestObject.TaskLogs, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWebserverLogs())
            {
                context.Writer.WritePropertyName("WebserverLogs");
                context.Writer.WriteStartObject();

                var marshaller = ModuleLoggingConfigurationInputMarshaller.Instance;
                marshaller.Marshall(requestObject.WebserverLogs, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWorkerLogs())
            {
                context.Writer.WritePropertyName("WorkerLogs");
                context.Writer.WriteStartObject();

                var marshaller = ModuleLoggingConfigurationInputMarshaller.Instance;
                marshaller.Marshall(requestObject.WorkerLogs, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LoggingConfigurationInputMarshaller Instance = new LoggingConfigurationInputMarshaller();

    }
}