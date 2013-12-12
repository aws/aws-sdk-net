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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   EnvironmentResourceDescription Unmarshaller
     /// </summary>
    internal class EnvironmentResourceDescriptionUnmarshaller : IUnmarshaller<EnvironmentResourceDescription, XmlUnmarshallerContext>, IUnmarshaller<EnvironmentResourceDescription, JsonUnmarshallerContext> 
    {
        public EnvironmentResourceDescription Unmarshall(XmlUnmarshallerContext context) 
        {
            EnvironmentResourceDescription environmentResourceDescription = new EnvironmentResourceDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("EnvironmentName", targetDepth))
                    {
                        environmentResourceDescription.EnvironmentName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("AutoScalingGroups/member", targetDepth))
                    {
                        environmentResourceDescription.AutoScalingGroups.Add(AutoScalingGroupUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("Instances/member", targetDepth))
                    {
                        environmentResourceDescription.Instances.Add(InstanceUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("LaunchConfigurations/member", targetDepth))
                    {
                        environmentResourceDescription.LaunchConfigurations.Add(LaunchConfigurationUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("LoadBalancers/member", targetDepth))
                    {
                        environmentResourceDescription.LoadBalancers.Add(LoadBalancerUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("Triggers/member", targetDepth))
                    {
                        environmentResourceDescription.Triggers.Add(TriggerUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("Queues/member", targetDepth))
                    {
                        environmentResourceDescription.Queues.Add(QueueUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return environmentResourceDescription;
                }
            }
                        


            return environmentResourceDescription;
        }

        public EnvironmentResourceDescription Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static EnvironmentResourceDescriptionUnmarshaller instance;

        public static EnvironmentResourceDescriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new EnvironmentResourceDescriptionUnmarshaller();

            return instance;
        }
    }
}
    
