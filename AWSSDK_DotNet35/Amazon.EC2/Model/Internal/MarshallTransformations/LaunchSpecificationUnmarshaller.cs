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
     ///   LaunchSpecification Unmarshaller
     /// </summary>
    internal class LaunchSpecificationUnmarshaller : IUnmarshaller<LaunchSpecification, XmlUnmarshallerContext>, IUnmarshaller<LaunchSpecification, JsonUnmarshallerContext> 
    {
        public LaunchSpecification Unmarshall(XmlUnmarshallerContext context) 
        {
            LaunchSpecification launchSpecification = new LaunchSpecification();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("imageId", targetDepth))
                    {
                        launchSpecification.ImageId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("keyName", targetDepth))
                    {
                        launchSpecification.KeyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("groupSet/item", targetDepth))
                    {
                        launchSpecification.AllSecurityGroups.Add(GroupIdentifierUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("groupSet/item/groupName", targetDepth))
                    {
                        launchSpecification.SecurityGroups.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("userData", targetDepth))
                    {
                        launchSpecification.UserData = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("addressingType", targetDepth))
                    {
                        launchSpecification.AddressingType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceType", targetDepth))
                    {
                        launchSpecification.InstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("placement", targetDepth))
                    {
                        launchSpecification.Placement = SpotPlacementUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("kernelId", targetDepth))
                    {
                        launchSpecification.KernelId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ramdiskId", targetDepth))
                    {
                        launchSpecification.RamdiskId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("blockDeviceMapping/item", targetDepth))
                    {
                        launchSpecification.BlockDeviceMappings.Add(BlockDeviceMappingUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("monitoring/enabled", targetDepth))
                    {
                        launchSpecification.MonitoringEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("subnetId", targetDepth))
                    {
                        launchSpecification.SubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceSet/item", targetDepth))
                    {
                        launchSpecification.NetworkInterfaces.Add(InstanceNetworkInterfaceSpecificationUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("iamInstanceProfile", targetDepth))
                    {
                        launchSpecification.IamInstanceProfile = IamInstanceProfileSpecificationUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ebsOptimized", targetDepth))
                    {
                        launchSpecification.EbsOptimized = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return launchSpecification;
                }
            }
                        


            return launchSpecification;
        }

        public LaunchSpecification Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static LaunchSpecificationUnmarshaller instance;

        public static LaunchSpecificationUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new LaunchSpecificationUnmarshaller();

            return instance;
        }
    }
}
    
