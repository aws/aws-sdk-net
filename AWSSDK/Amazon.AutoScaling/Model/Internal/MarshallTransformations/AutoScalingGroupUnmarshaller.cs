/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.AutoScaling.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   AutoScalingGroup Unmarshaller
     /// </summary>
    internal class AutoScalingGroupUnmarshaller : IUnmarshaller<AutoScalingGroup, XmlUnmarshallerContext>, IUnmarshaller<AutoScalingGroup, JsonUnmarshallerContext> 
    {
        public AutoScalingGroup Unmarshall(XmlUnmarshallerContext context) 
        {
            AutoScalingGroup autoScalingGroup = new AutoScalingGroup();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("AutoScalingGroupName", targetDepth))
                    {
                        autoScalingGroup.AutoScalingGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AutoScalingGroupARN", targetDepth))
                    {
                        autoScalingGroup.AutoScalingGroupARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LaunchConfigurationName", targetDepth))
                    {
                        autoScalingGroup.LaunchConfigurationName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MinSize", targetDepth))
                    {
                        autoScalingGroup.MinSize = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MaxSize", targetDepth))
                    {
                        autoScalingGroup.MaxSize = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DesiredCapacity", targetDepth))
                    {
                        autoScalingGroup.DesiredCapacity = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DefaultCooldown", targetDepth))
                    {
                        autoScalingGroup.DefaultCooldown = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AvailabilityZones/member", targetDepth))
                    {
                        autoScalingGroup.AvailabilityZones.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("LoadBalancerNames/member", targetDepth))
                    {
                        autoScalingGroup.LoadBalancerNames.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("HealthCheckType", targetDepth))
                    {
                        autoScalingGroup.HealthCheckType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("HealthCheckGracePeriod", targetDepth))
                    {
                        autoScalingGroup.HealthCheckGracePeriod = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Instances/member", targetDepth))
                    {
                        autoScalingGroup.Instances.Add(InstanceUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("CreatedTime", targetDepth))
                    {
                        autoScalingGroup.CreatedTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SuspendedProcesses/member", targetDepth))
                    {
                        autoScalingGroup.SuspendedProcesses.Add(SuspendedProcessUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("PlacementGroup", targetDepth))
                    {
                        autoScalingGroup.PlacementGroup = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("VPCZoneIdentifier", targetDepth))
                    {
                        autoScalingGroup.VPCZoneIdentifier = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EnabledMetrics/member", targetDepth))
                    {
                        autoScalingGroup.EnabledMetrics.Add(EnabledMetricUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("Status", targetDepth))
                    {
                        autoScalingGroup.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Tags/member", targetDepth))
                    {
                        autoScalingGroup.Tags.Add(TagDescriptionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("TerminationPolicies/member", targetDepth))
                    {
                        autoScalingGroup.TerminationPolicies.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return autoScalingGroup;
                }
            }
                        


            return autoScalingGroup;
        }

        public AutoScalingGroup Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static AutoScalingGroupUnmarshaller instance;

        public static AutoScalingGroupUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new AutoScalingGroupUnmarshaller();

            return instance;
        }
    }
}
    
