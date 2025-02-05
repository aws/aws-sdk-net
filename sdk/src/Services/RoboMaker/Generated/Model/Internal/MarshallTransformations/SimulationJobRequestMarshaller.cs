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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RoboMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RoboMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SimulationJobRequest Marshaller
    /// </summary>
    public class SimulationJobRequestMarshaller : IRequestMarshaller<SimulationJobRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SimulationJobRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCompute())
            {
                context.Writer.WritePropertyName("compute");
                context.Writer.WriteStartObject();

                var marshaller = ComputeMarshaller.Instance;
                marshaller.Marshall(requestObject.Compute, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataSources())
            {
                context.Writer.WritePropertyName("dataSources");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDataSourcesListValue in requestObject.DataSources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectDataSourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFailureBehavior())
            {
                context.Writer.WritePropertyName("failureBehavior");
                context.Writer.WriteStringValue(requestObject.FailureBehavior);
            }

            if(requestObject.IsSetIamRole())
            {
                context.Writer.WritePropertyName("iamRole");
                context.Writer.WriteStringValue(requestObject.IamRole);
            }

            if(requestObject.IsSetLoggingConfig())
            {
                context.Writer.WritePropertyName("loggingConfig");
                context.Writer.WriteStartObject();

                var marshaller = LoggingConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.LoggingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaxJobDurationInSeconds())
            {
                context.Writer.WritePropertyName("maxJobDurationInSeconds");
                context.Writer.WriteNumberValue(requestObject.MaxJobDurationInSeconds.Value);
            }

            if(requestObject.IsSetOutputLocation())
            {
                context.Writer.WritePropertyName("outputLocation");
                context.Writer.WriteStartObject();

                var marshaller = OutputLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputLocation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRobotApplications())
            {
                context.Writer.WritePropertyName("robotApplications");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRobotApplicationsListValue in requestObject.RobotApplications)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RobotApplicationConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectRobotApplicationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSimulationApplications())
            {
                context.Writer.WritePropertyName("simulationApplications");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSimulationApplicationsListValue in requestObject.SimulationApplications)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SimulationApplicationConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectSimulationApplicationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUseDefaultApplications())
            {
                context.Writer.WritePropertyName("useDefaultApplications");
                context.Writer.WriteBooleanValue(requestObject.UseDefaultApplications.Value);
            }

            if(requestObject.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("vpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = VPCConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SimulationJobRequestMarshaller Instance = new SimulationJobRequestMarshaller();

    }
}