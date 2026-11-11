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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SpotFleetRequestConfigData Object
    /// </summary>
    public partial class SpotFleetRequestConfigDataUnmarshaller : IXmlUnmarshaller<SpotFleetRequestConfigData, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public SpotFleetRequestConfigData Unmarshall(XmlUnmarshallerContext context)
        {
            SpotFleetRequestConfigData unmarshalledObject = new SpotFleetRequestConfigData();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("allocationStrategy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AllocationStrategy = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("clientToken", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClientToken = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("context", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Context = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("excessCapacityTerminationPolicy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ExcessCapacityTerminationPolicy = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("fulfilledCapacity", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.FulfilledCapacity = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("iamFleetRole", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IamFleetRole = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("instanceInterruptionBehavior", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceInterruptionBehavior = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("instancePoolsToUseCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.InstancePoolsToUseCount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("launchSpecifications/item", targetDepth))
                    {
                        if (unmarshalledObject.LaunchSpecifications == null)
                        {
                            unmarshalledObject.LaunchSpecifications = new List<SpotFleetLaunchSpecification>();
                        }
                        var unmarshaller = SpotFleetLaunchSpecificationUnmarshaller.Instance;
                        unmarshalledObject.LaunchSpecifications.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("launchTemplateConfigs/item", targetDepth))
                    {
                        if (unmarshalledObject.LaunchTemplateConfigs == null)
                        {
                            unmarshalledObject.LaunchTemplateConfigs = new List<LaunchTemplateConfig>();
                        }
                        var unmarshaller = LaunchTemplateConfigUnmarshaller.Instance;
                        unmarshalledObject.LaunchTemplateConfigs.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("loadBalancersConfig", targetDepth))
                    {
                        var unmarshaller = LoadBalancersConfigUnmarshaller.Instance;
                        unmarshalledObject.LoadBalancersConfig = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("onDemandAllocationStrategy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OnDemandAllocationStrategy = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("onDemandFulfilledCapacity", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.OnDemandFulfilledCapacity = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("onDemandMaxTotalPrice", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OnDemandMaxTotalPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("onDemandTargetCapacity", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.OnDemandTargetCapacity = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("replaceUnhealthyInstances", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.ReplaceUnhealthyInstances = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("spotMaintenanceStrategies", targetDepth))
                    {
                        var unmarshaller = SpotMaintenanceStrategiesUnmarshaller.Instance;
                        unmarshalledObject.SpotMaintenanceStrategies = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("spotMaxTotalPrice", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SpotMaxTotalPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("spotPrice", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SpotPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("tagSpecification/item", targetDepth))
                    {
                        if (unmarshalledObject.TagSpecifications == null)
                        {
                            unmarshalledObject.TagSpecifications = new List<TagSpecification>();
                        }
                        var unmarshaller = TagSpecificationUnmarshaller.Instance;
                        unmarshalledObject.TagSpecifications.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("targetCapacity", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.TargetCapacity = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("targetCapacityUnitType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TargetCapacityUnitType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("terminateInstancesWithExpiration", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.TerminateInstancesWithExpiration = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("type", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("validFrom", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.ValidFrom = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("validUntil", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.ValidUntil = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static SpotFleetRequestConfigDataUnmarshaller _instance = new SpotFleetRequestConfigDataUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SpotFleetRequestConfigDataUnmarshaller Instance => _instance;
    }
}
