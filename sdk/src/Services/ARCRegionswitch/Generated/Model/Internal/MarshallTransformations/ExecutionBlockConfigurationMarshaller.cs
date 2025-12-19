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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ARCRegionswitch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ARCRegionswitch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExecutionBlockConfiguration Marshaller
    /// </summary>
    public class ExecutionBlockConfigurationMarshaller : IRequestMarshaller<ExecutionBlockConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExecutionBlockConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArcRoutingControlConfig())
            {
                context.Writer.WritePropertyName("arcRoutingControlConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ArcRoutingControlConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ArcRoutingControlConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCustomActionLambdaConfig())
            {
                context.Writer.WritePropertyName("customActionLambdaConfig");
                context.Writer.WriteObjectStart();

                var marshaller = CustomActionLambdaConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomActionLambdaConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDocumentDbConfig())
            {
                context.Writer.WritePropertyName("documentDbConfig");
                context.Writer.WriteObjectStart();

                var marshaller = DocumentDbConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DocumentDbConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEc2AsgCapacityIncreaseConfig())
            {
                context.Writer.WritePropertyName("ec2AsgCapacityIncreaseConfig");
                context.Writer.WriteObjectStart();

                var marshaller = Ec2AsgCapacityIncreaseConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Ec2AsgCapacityIncreaseConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEcsCapacityIncreaseConfig())
            {
                context.Writer.WritePropertyName("ecsCapacityIncreaseConfig");
                context.Writer.WriteObjectStart();

                var marshaller = EcsCapacityIncreaseConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EcsCapacityIncreaseConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEksResourceScalingConfig())
            {
                context.Writer.WritePropertyName("eksResourceScalingConfig");
                context.Writer.WriteObjectStart();

                var marshaller = EksResourceScalingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EksResourceScalingConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExecutionApprovalConfig())
            {
                context.Writer.WritePropertyName("executionApprovalConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ExecutionApprovalConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ExecutionApprovalConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGlobalAuroraConfig())
            {
                context.Writer.WritePropertyName("globalAuroraConfig");
                context.Writer.WriteObjectStart();

                var marshaller = GlobalAuroraConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.GlobalAuroraConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParallelConfig())
            {
                context.Writer.WritePropertyName("parallelConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ParallelExecutionBlockConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ParallelConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRegionSwitchPlanConfig())
            {
                context.Writer.WritePropertyName("regionSwitchPlanConfig");
                context.Writer.WriteObjectStart();

                var marshaller = RegionSwitchPlanConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RegionSwitchPlanConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRoute53HealthCheckConfig())
            {
                context.Writer.WritePropertyName("route53HealthCheckConfig");
                context.Writer.WriteObjectStart();

                var marshaller = Route53HealthCheckConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Route53HealthCheckConfig, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExecutionBlockConfigurationMarshaller Instance = new ExecutionBlockConfigurationMarshaller();

    }
}