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

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Instance Unmarshaller
     /// </summary>
    internal class InstanceUnmarshaller : IUnmarshaller<Instance, XmlUnmarshallerContext>, IUnmarshaller<Instance, JsonUnmarshallerContext> 
    {
        public Instance Unmarshall(XmlUnmarshallerContext context) 
        {
            Instance instance = new Instance();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("instanceId", targetDepth))
                    {
                        instance.InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("imageId", targetDepth))
                    {
                        instance.ImageId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceState", targetDepth))
                    {
                        instance.State = InstanceStateUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("privateDnsName", targetDepth))
                    {
                        instance.PrivateDnsName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("dnsName", targetDepth))
                    {
                        instance.PublicDnsName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("reason", targetDepth))
                    {
                        instance.StateTransitionReason = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("keyName", targetDepth))
                    {
                        instance.KeyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("amiLaunchIndex", targetDepth))
                    {
                        instance.AmiLaunchIndex = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("productCodes/item", targetDepth))
                    {
                        instance.ProductCodes.Add(ProductCodeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("instanceType", targetDepth))
                    {
                        instance.InstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("launchTime", targetDepth))
                    {
                        instance.LaunchTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("placement", targetDepth))
                    {
                        instance.Placement = PlacementUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("kernelId", targetDepth))
                    {
                        instance.KernelId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ramdiskId", targetDepth))
                    {
                        instance.RamdiskId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("platform", targetDepth))
                    {
                        instance.Platform = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("monitoring", targetDepth))
                    {
                        instance.Monitoring = MonitoringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("subnetId", targetDepth))
                    {
                        instance.SubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        instance.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("privateIpAddress", targetDepth))
                    {
                        instance.PrivateIpAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ipAddress", targetDepth))
                    {
                        instance.PublicIpAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("stateReason", targetDepth))
                    {
                        instance.StateReason = StateReasonUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("architecture", targetDepth))
                    {
                        instance.Architecture = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("rootDeviceType", targetDepth))
                    {
                        instance.RootDeviceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("rootDeviceName", targetDepth))
                    {
                        instance.RootDeviceName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("blockDeviceMapping/item", targetDepth))
                    {
                        instance.BlockDeviceMappings.Add(InstanceBlockDeviceMappingUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("virtualizationType", targetDepth))
                    {
                        instance.VirtualizationType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceLifecycle", targetDepth))
                    {
                        instance.InstanceLifecycle = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("spotInstanceRequestId", targetDepth))
                    {
                        instance.SpotInstanceRequestId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("license", targetDepth))
                    {
                        instance.License = InstanceLicenseUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("clientToken", targetDepth))
                    {
                        instance.ClientToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        instance.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("groupSet/item", targetDepth))
                    {
                        instance.SecurityGroups.Add(GroupIdentifierUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("sourceDestCheck", targetDepth))
                    {
                        instance.SourceDestCheck = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("hypervisor", targetDepth))
                    {
                        instance.Hypervisor = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceSet/item", targetDepth))
                    {
                        instance.NetworkInterfaces.Add(InstanceNetworkInterfaceUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("iamInstanceProfile", targetDepth))
                    {
                        instance.IamInstanceProfile = IamInstanceProfileUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ebsOptimized", targetDepth))
                    {
                        instance.EbsOptimized = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("sriovNetSupport", targetDepth))
                    {
                        instance.SriovNetSupport = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return instance;
                }
            }
                        


            return instance;
        }

        public Instance Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static InstanceUnmarshaller instance;

        public static InstanceUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new InstanceUnmarshaller();

            return instance;
        }
    }
}
    
