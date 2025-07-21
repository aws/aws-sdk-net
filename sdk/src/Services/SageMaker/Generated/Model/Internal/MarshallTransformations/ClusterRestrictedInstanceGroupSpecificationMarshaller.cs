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
    /// ClusterRestrictedInstanceGroupSpecification Marshaller
    /// </summary>
    public class ClusterRestrictedInstanceGroupSpecificationMarshaller : IRequestMarshaller<ClusterRestrictedInstanceGroupSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ClusterRestrictedInstanceGroupSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnvironmentConfig())
            {
                context.Writer.WritePropertyName("EnvironmentConfig");
                context.Writer.WriteStartObject();

                var marshaller = EnvironmentConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.EnvironmentConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExecutionRole())
            {
                context.Writer.WritePropertyName("ExecutionRole");
                context.Writer.WriteStringValue(requestObject.ExecutionRole);
            }

            if(requestObject.IsSetInstanceCount())
            {
                context.Writer.WritePropertyName("InstanceCount");
                context.Writer.WriteNumberValue(requestObject.InstanceCount.Value);
            }

            if(requestObject.IsSetInstanceGroupName())
            {
                context.Writer.WritePropertyName("InstanceGroupName");
                context.Writer.WriteStringValue(requestObject.InstanceGroupName);
            }

            if(requestObject.IsSetInstanceStorageConfigs())
            {
                context.Writer.WritePropertyName("InstanceStorageConfigs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInstanceStorageConfigsListValue in requestObject.InstanceStorageConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ClusterInstanceStorageConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectInstanceStorageConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.WriteStringValue(requestObject.InstanceType);
            }

            if(requestObject.IsSetOnStartDeepHealthChecks())
            {
                context.Writer.WritePropertyName("OnStartDeepHealthChecks");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOnStartDeepHealthChecksListValue in requestObject.OnStartDeepHealthChecks)
                {
                        context.Writer.WriteStringValue(requestObjectOnStartDeepHealthChecksListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOverrideVpcConfig())
            {
                context.Writer.WritePropertyName("OverrideVpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = VpcConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.OverrideVpcConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScheduledUpdateConfig())
            {
                context.Writer.WritePropertyName("ScheduledUpdateConfig");
                context.Writer.WriteStartObject();

                var marshaller = ScheduledUpdateConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ScheduledUpdateConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetThreadsPerCore())
            {
                context.Writer.WritePropertyName("ThreadsPerCore");
                context.Writer.WriteNumberValue(requestObject.ThreadsPerCore.Value);
            }

            if(requestObject.IsSetTrainingPlanArn())
            {
                context.Writer.WritePropertyName("TrainingPlanArn");
                context.Writer.WriteStringValue(requestObject.TrainingPlanArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ClusterRestrictedInstanceGroupSpecificationMarshaller Instance = new ClusterRestrictedInstanceGroupSpecificationMarshaller();

    }
}