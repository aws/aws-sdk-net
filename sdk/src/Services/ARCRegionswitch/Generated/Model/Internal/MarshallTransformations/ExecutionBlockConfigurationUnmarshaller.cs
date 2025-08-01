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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ARCRegionswitch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ARCRegionswitch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ExecutionBlockConfiguration Object
    /// </summary>  
    public class ExecutionBlockConfigurationUnmarshaller : IJsonUnmarshaller<ExecutionBlockConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ExecutionBlockConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ExecutionBlockConfiguration unmarshalledObject = new ExecutionBlockConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("arcRoutingControlConfig", targetDepth))
                {
                    var unmarshaller = ArcRoutingControlConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ArcRoutingControlConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("customActionLambdaConfig", targetDepth))
                {
                    var unmarshaller = CustomActionLambdaConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CustomActionLambdaConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ec2AsgCapacityIncreaseConfig", targetDepth))
                {
                    var unmarshaller = Ec2AsgCapacityIncreaseConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Ec2AsgCapacityIncreaseConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ecsCapacityIncreaseConfig", targetDepth))
                {
                    var unmarshaller = EcsCapacityIncreaseConfigurationUnmarshaller.Instance;
                    unmarshalledObject.EcsCapacityIncreaseConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("eksResourceScalingConfig", targetDepth))
                {
                    var unmarshaller = EksResourceScalingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.EksResourceScalingConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("executionApprovalConfig", targetDepth))
                {
                    var unmarshaller = ExecutionApprovalConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ExecutionApprovalConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("globalAuroraConfig", targetDepth))
                {
                    var unmarshaller = GlobalAuroraConfigurationUnmarshaller.Instance;
                    unmarshalledObject.GlobalAuroraConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parallelConfig", targetDepth))
                {
                    var unmarshaller = ParallelExecutionBlockConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ParallelConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("regionSwitchPlanConfig", targetDepth))
                {
                    var unmarshaller = RegionSwitchPlanConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RegionSwitchPlanConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("route53HealthCheckConfig", targetDepth))
                {
                    var unmarshaller = Route53HealthCheckConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Route53HealthCheckConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ExecutionBlockConfigurationUnmarshaller _instance = new ExecutionBlockConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExecutionBlockConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}