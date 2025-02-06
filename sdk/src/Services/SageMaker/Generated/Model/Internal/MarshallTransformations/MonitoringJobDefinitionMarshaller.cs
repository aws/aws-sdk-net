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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MonitoringJobDefinition Marshaller
    /// </summary>
    public class MonitoringJobDefinitionMarshaller : IRequestMarshaller<MonitoringJobDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MonitoringJobDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBaselineConfig())
            {
                context.Writer.WritePropertyName("BaselineConfig");
                context.Writer.WriteStartObject();

                var marshaller = MonitoringBaselineConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.BaselineConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEnvironmentKvp in requestObject.Environment)
                {
                    context.Writer.WritePropertyName(requestObjectEnvironmentKvp.Key);
                    var requestObjectEnvironmentValue = requestObjectEnvironmentKvp.Value;

                        context.Writer.WriteStringValue(requestObjectEnvironmentValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMonitoringAppSpecification())
            {
                context.Writer.WritePropertyName("MonitoringAppSpecification");
                context.Writer.WriteStartObject();

                var marshaller = MonitoringAppSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.MonitoringAppSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMonitoringInputs())
            {
                context.Writer.WritePropertyName("MonitoringInputs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMonitoringInputsListValue in requestObject.MonitoringInputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MonitoringInputMarshaller.Instance;
                    marshaller.Marshall(requestObjectMonitoringInputsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMonitoringOutputConfig())
            {
                context.Writer.WritePropertyName("MonitoringOutputConfig");
                context.Writer.WriteStartObject();

                var marshaller = MonitoringOutputConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.MonitoringOutputConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMonitoringResources())
            {
                context.Writer.WritePropertyName("MonitoringResources");
                context.Writer.WriteStartObject();

                var marshaller = MonitoringResourcesMarshaller.Instance;
                marshaller.Marshall(requestObject.MonitoringResources, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNetworkConfig())
            {
                context.Writer.WritePropertyName("NetworkConfig");
                context.Writer.WriteStartObject();

                var marshaller = NetworkConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetStoppingCondition())
            {
                context.Writer.WritePropertyName("StoppingCondition");
                context.Writer.WriteStartObject();

                var marshaller = MonitoringStoppingConditionMarshaller.Instance;
                marshaller.Marshall(requestObject.StoppingCondition, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MonitoringJobDefinitionMarshaller Instance = new MonitoringJobDefinitionMarshaller();

    }
}