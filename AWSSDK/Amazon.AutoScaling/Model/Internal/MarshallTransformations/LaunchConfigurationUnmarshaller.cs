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
     ///   LaunchConfiguration Unmarshaller
     /// </summary>
    internal class LaunchConfigurationUnmarshaller : IUnmarshaller<LaunchConfiguration, XmlUnmarshallerContext>, IUnmarshaller<LaunchConfiguration, JsonUnmarshallerContext> 
    {
        public LaunchConfiguration Unmarshall(XmlUnmarshallerContext context) 
        {
            LaunchConfiguration launchConfiguration = new LaunchConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("LaunchConfigurationName", targetDepth))
                    {
                        launchConfiguration.LaunchConfigurationName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LaunchConfigurationARN", targetDepth))
                    {
                        launchConfiguration.LaunchConfigurationARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ImageId", targetDepth))
                    {
                        launchConfiguration.ImageId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("KeyName", targetDepth))
                    {
                        launchConfiguration.KeyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SecurityGroups/member", targetDepth))
                    {
                        launchConfiguration.SecurityGroups.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("UserData", targetDepth))
                    {
                        launchConfiguration.UserData = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("InstanceType", targetDepth))
                    {
                        launchConfiguration.InstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("KernelId", targetDepth))
                    {
                        launchConfiguration.KernelId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("RamdiskId", targetDepth))
                    {
                        launchConfiguration.RamdiskId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("BlockDeviceMappings/member", targetDepth))
                    {
                        launchConfiguration.BlockDeviceMappings.Add(BlockDeviceMappingUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("InstanceMonitoring", targetDepth))
                    {
                        launchConfiguration.InstanceMonitoring = InstanceMonitoringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SpotPrice", targetDepth))
                    {
                        launchConfiguration.SpotPrice = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("IamInstanceProfile", targetDepth))
                    {
                        launchConfiguration.IamInstanceProfile = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CreatedTime", targetDepth))
                    {
                        launchConfiguration.CreatedTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EbsOptimized", targetDepth))
                    {
                        launchConfiguration.EbsOptimized = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AssociatePublicIpAddress", targetDepth))
                    {
                        launchConfiguration.AssociatePublicIpAddress = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return launchConfiguration;
                }
            }
                        


            return launchConfiguration;
        }

        public LaunchConfiguration Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static LaunchConfigurationUnmarshaller instance;

        public static LaunchConfigurationUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new LaunchConfigurationUnmarshaller();

            return instance;
        }
    }
}
    
