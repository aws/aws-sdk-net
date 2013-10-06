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
     ///   AutoScalingInstanceDetails Unmarshaller
     /// </summary>
    internal class AutoScalingInstanceDetailsUnmarshaller : IUnmarshaller<AutoScalingInstanceDetails, XmlUnmarshallerContext>, IUnmarshaller<AutoScalingInstanceDetails, JsonUnmarshallerContext> 
    {
        public AutoScalingInstanceDetails Unmarshall(XmlUnmarshallerContext context) 
        {
            AutoScalingInstanceDetails autoScalingInstanceDetails = new AutoScalingInstanceDetails();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("InstanceId", targetDepth))
                    {
                        autoScalingInstanceDetails.InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AutoScalingGroupName", targetDepth))
                    {
                        autoScalingInstanceDetails.AutoScalingGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AvailabilityZone", targetDepth))
                    {
                        autoScalingInstanceDetails.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LifecycleState", targetDepth))
                    {
                        autoScalingInstanceDetails.LifecycleState = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("HealthStatus", targetDepth))
                    {
                        autoScalingInstanceDetails.HealthStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LaunchConfigurationName", targetDepth))
                    {
                        autoScalingInstanceDetails.LaunchConfigurationName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return autoScalingInstanceDetails;
                }
            }
                        


            return autoScalingInstanceDetails;
        }

        public AutoScalingInstanceDetails Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static AutoScalingInstanceDetailsUnmarshaller instance;

        public static AutoScalingInstanceDetailsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new AutoScalingInstanceDetailsUnmarshaller();

            return instance;
        }
    }
}
    
