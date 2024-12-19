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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AutoScalingGroup Object
    /// </summary>  
    public class AutoScalingGroupUnmarshaller : IXmlUnmarshaller<AutoScalingGroup, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AutoScalingGroup Unmarshall(XmlUnmarshallerContext context)
        {
            AutoScalingGroup unmarshalledObject = new AutoScalingGroup();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AutoScalingGroupARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AutoScalingGroupARN = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AutoScalingGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AutoScalingGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AvailabilityZones/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.AvailabilityZones == null)
                        {
                            unmarshalledObject.AvailabilityZones = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AvailabilityZones.Add(item);
                        continue;
                    }
                    if (context.TestExpression("CapacityRebalance", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.CapacityRebalance = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Context", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Context = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreatedTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultCooldown", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.DefaultCooldown = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultInstanceWarmup", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.DefaultInstanceWarmup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DesiredCapacity", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.DesiredCapacity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DesiredCapacityType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DesiredCapacityType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EnabledMetrics/member", targetDepth))
                    {
                        var unmarshaller = EnabledMetricUnmarshaller.Instance;
                        if (unmarshalledObject.EnabledMetrics == null)
                        {
                            unmarshalledObject.EnabledMetrics = new List<EnabledMetric>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.EnabledMetrics.Add(item);
                        continue;
                    }
                    if (context.TestExpression("HealthCheckGracePeriod", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.HealthCheckGracePeriod = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HealthCheckType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HealthCheckType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InstanceMaintenancePolicy", targetDepth))
                    {
                        var unmarshaller = InstanceMaintenancePolicyUnmarshaller.Instance;
                        unmarshalledObject.InstanceMaintenancePolicy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Instances/member", targetDepth))
                    {
                        var unmarshaller = InstanceUnmarshaller.Instance;
                        if (unmarshalledObject.Instances == null)
                        {
                            unmarshalledObject.Instances = new List<Instance>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Instances.Add(item);
                        continue;
                    }
                    if (context.TestExpression("LaunchConfigurationName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LaunchConfigurationName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LaunchTemplate", targetDepth))
                    {
                        var unmarshaller = LaunchTemplateSpecificationUnmarshaller.Instance;
                        unmarshalledObject.LaunchTemplate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LoadBalancerNames/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.LoadBalancerNames == null)
                        {
                            unmarshalledObject.LoadBalancerNames = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.LoadBalancerNames.Add(item);
                        continue;
                    }
                    if (context.TestExpression("MaxInstanceLifetime", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxInstanceLifetime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxSize", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxSize = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinSize", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MinSize = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MixedInstancesPolicy", targetDepth))
                    {
                        var unmarshaller = MixedInstancesPolicyUnmarshaller.Instance;
                        unmarshalledObject.MixedInstancesPolicy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NewInstancesProtectedFromScaleIn", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.NewInstancesProtectedFromScaleIn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PlacementGroup", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PlacementGroup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PredictedCapacity", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.PredictedCapacity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceLinkedRoleARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceLinkedRoleARN = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SuspendedProcesses/member", targetDepth))
                    {
                        var unmarshaller = SuspendedProcessUnmarshaller.Instance;
                        if (unmarshalledObject.SuspendedProcesses == null)
                        {
                            unmarshalledObject.SuspendedProcesses = new List<SuspendedProcess>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SuspendedProcesses.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Tags/member", targetDepth))
                    {
                        var unmarshaller = TagDescriptionUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<TagDescription>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("TargetGroupARNs/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.TargetGroupARNs == null)
                        {
                            unmarshalledObject.TargetGroupARNs = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.TargetGroupARNs.Add(item);
                        continue;
                    }
                    if (context.TestExpression("TerminationPolicies/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.TerminationPolicies == null)
                        {
                            unmarshalledObject.TerminationPolicies = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.TerminationPolicies.Add(item);
                        continue;
                    }
                    if (context.TestExpression("TrafficSources/member", targetDepth))
                    {
                        var unmarshaller = TrafficSourceIdentifierUnmarshaller.Instance;
                        if (unmarshalledObject.TrafficSources == null)
                        {
                            unmarshalledObject.TrafficSources = new List<TrafficSourceIdentifier>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.TrafficSources.Add(item);
                        continue;
                    }
                    if (context.TestExpression("VPCZoneIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VPCZoneIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("WarmPoolConfiguration", targetDepth))
                    {
                        var unmarshaller = WarmPoolConfigurationUnmarshaller.Instance;
                        unmarshalledObject.WarmPoolConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("WarmPoolSize", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.WarmPoolSize = unmarshaller.Unmarshall(context);
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

        private static AutoScalingGroupUnmarshaller _instance = new AutoScalingGroupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutoScalingGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}